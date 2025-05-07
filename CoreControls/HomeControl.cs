using System;
using System.Drawing;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.Legends;
using OxyPlot.WindowsForms;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace SEHRS
{
    public partial class HomeControl : UserControl
    {
        private System.Windows.Forms.Timer clockTimer;
        private Label lblClock;

        public HomeControl()
        {
            InitializeComponent();
            InitializeClock();
            LoadCharts();
            this.Load += HomeControl_Load;
            this.Disposed += HomeControl_Disposed;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }

        private void HomeControl_Disposed(object sender, EventArgs e)
        {
            if (clockTimer != null)
            {
                clockTimer.Stop();
                clockTimer.Dispose();
                clockTimer = null;
            }

            if (lblClock != null)
            {
                lblClock.Dispose();
                lblClock = null;
            }
        }

        private void InitializeClock()
        {
            lblClock = this.ClockLabel;

            clockTimer = new System.Windows.Forms.Timer
            {
                Interval = 500
            };
            clockTimer.Tick += UpdateClock;
            clockTimer.Start();
            UpdateClock(null, EventArgs.Empty);
        }
        private void LoadCharts()
        {
            try
            {
                //Overall patient distribution (count + year)
                var overallData = AnalyticsChartService.GetPatientCountsAndYearByPurok();
                pltHomeViewOverall.Model = AnalyticsChartService.CreateHorizontalBarChart(
                    overallData,
                    "Overall Patients"
                );

                //Gets all conditions and their counts for the last 30 days
                var conditions = new List<string> 
                { "Cough", "Fever", "Asthma", "Diabetes", "Hypertension" };
                var conditionCounts = new Dictionary<string, int>();

                foreach (var condition in conditions)
                {

                    var conditionData = AnalyticsChartService.GetConditionPuroksByYear(
                        condition: condition,
                        startDate: DateTime.Now.AddDays(-30),
                        endDate: DateTime.Now
                    );


                    conditionCounts[condition] = conditionData.Count;
                }

                // Finds condition with the highest number of cases
                var mostCommonCondition = conditionCounts
                    .OrderByDescending(kvp => kvp.Value)
                    .FirstOrDefault();

                // If there is a condition with cases generate the chart
                if (mostCommonCondition.Key != null)
                {
                    var mostCommonConditionData = AnalyticsChartService.GetConditionPuroksByYear(
                        condition: mostCommonCondition.Key,
                        startDate: DateTime.Now.AddDays(-30),
                        endDate: DateTime.Now
                    );

                    // Convert to the format required by CreateHorizontalBarChart
                    var conditionData = mostCommonConditionData
                        .GroupBy(kv => kv.Key)  // Group by PurokNumber
                        .ToDictionary(
                            group => group.Key,
                            group => new Tuple<int, List<int>>(
                                group.Count(),  // Count = Number of cases
                                group.Select(g => g.Value).ToList()  // List of years
                            )
                        );

                    pltHomeViewSpecific.Model = AnalyticsChartService.CreateHorizontalBarChart(
                        conditionData,
                        $"{mostCommonCondition.Key} - Last 30 Days"
                    );
                }
                else
                {
                    MessageBox.Show("No data found for the selected conditions.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading charts: " + ex.Message);
            }
        }




        private void UpdateClock(object sender, EventArgs e)
        {
            if (lblClock == null || lblClock.IsDisposed)
                return;

            var now = DateTime.Now;
            string date = now.ToString("MMM dd, yyyy");
            string time = now.ToString("hh:mm:ss tt").ToLower();

            lblClock.Text = $"{date}\n{time}";
            lblClock.ForeColor = now.Hour < 12 ? Color.Black : Color.Black;
        }

        private void LoadDrugProfiles()
        {
            DrugService.LoadAndDisplayDrugs(flowHomeMedPanel);
        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            LoadPatientProfiles();
            LoadDrugProfiles();
        }



        private void btnJumpInventory_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                var inventoryControl = new ManageInventoryControl();
                inventoryControl.Dock = DockStyle.Fill;
                parent.Controls.Add(inventoryControl);
                inventoryControl.BringToFront();
            }
        }

        private void btnJumpPatRecords_Click(object sender, EventArgs e)
        {
            Control parent = this.Parent;
            if (parent != null)
            {
                parent.Controls.Clear();
                var managePatientControl = new ManagePatientsControl();
                managePatientControl.Dock = DockStyle.Fill;
                parent.Controls.Add(managePatientControl);
                managePatientControl.BringToFront();
            }
        }
          private void LoadPatientProfiles()
        {
            PatientProfileService.LoadAndDisplayPatients(flowHomePanel);
        }

        private void pltHomeViewSpecific_Click(object sender, EventArgs e) { }
        private void pltHomeViewOverall_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void timerDateTime_Tick_1(object sender, EventArgs e) { }
        private void ClockLabel_Click(object sender, EventArgs e) { }
        private void bigLabel1_Click(object sender, EventArgs e){ }
    }
}