using System;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using System.Data.OleDb;
using System.Collections.Generic;
using OxyPlot.Legends;

namespace SEHRS
{
    public partial class FilterAnalyticsControl : UserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";

        public FilterAnalyticsControl()
        {
            InitializeComponent();
            // Hide all date controls by default
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            btnSetStart.Visible = false;
            btnSetEnd.Visible = false;
            lblSelectDate.Visible = false;
            SearchCondition.Visible = false;
            btnSearchCondition.Visible = false;
            pnlDatePicker.Visible = false;
            LoadDataAndCreateChart();
        }

        private void LoadDataAndCreateChart()
        {
            try
            {
                var purokCounts = GetPatientCountsByPurok();
                pltview.Model = CreateBarChart(purokCounts);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}");
            }
        }

        private Dictionary<string, int> GetPatientCountsByPurok()
        {
            var counts = new Dictionary<string, int>();
            int minPurok = int.MaxValue;
            int maxPurok = int.MinValue;

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // First verify the table structure
                VerifyTableStructure(connection);

                string query = @"SELECT [PurokNumber], COUNT(*) AS PatientCount 
                        FROM [PatientName] 
                        WHERE [PurokNumber] IS NOT NULL
                        GROUP BY [PurokNumber] 
                        ORDER BY [PurokNumber]";

                using (var command = new OleDbCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string purok = reader["PurokNumber"].ToString();
                        int count = Convert.ToInt32(reader["PatientCount"]);

                        counts.Add(purok, count);

                        // Track min and max purok numbers for range
                        int purokNum = Convert.ToInt32(purok);
                        minPurok = Math.Min(minPurok, purokNum);
                        maxPurok = Math.Max(maxPurok, purokNum);
                    }
                }

                // Add missing purok numbers with 0 count
                for (int i = minPurok; i <= maxPurok; i++)
                {
                    if (!counts.ContainsKey(i.ToString()))
                    {
                        counts.Add(i.ToString(), 0);
                    }
                }
            }
            // Sort the dictionary by purok number (key)
            var sortedCounts = counts.OrderBy(item => Convert.ToInt32(item.Key)).ToDictionary(item => item.Key, item => item.Value);

            return sortedCounts;
        }

        private void VerifyTableStructure(OleDbConnection connection)
        {
            try
            {
                var schema = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables,
                    new object[] { null, null, null, "TABLE" });

                bool tableExists = false;
                foreach (System.Data.DataRow row in schema.Rows)
                {
                    if (row["TABLE_NAME"].ToString() == "PatientName")
                    {
                        tableExists = true;
                        break;
                    }
                }

                if (!tableExists)
                {
                    throw new Exception("PatientName table not found in database");
                }

                var columns = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Columns,
                    new object[] { null, null, "PatientName", null });

                bool columnExists = false;
                foreach (System.Data.DataRow row in columns.Rows)
                {
                    if (row["COLUMN_NAME"].ToString() == "PurokNumber")
                    {
                        columnExists = true;
                        break;
                    }
                }

                if (!columnExists)
                {
                    throw new Exception("PurokNumber column not found in PatientName table");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Database structure verification failed: " + ex.Message);
            }
        }
        private PlotModel CreateBarChart(Dictionary<string, int> purokCounts)
        {
            var plotModel = new PlotModel
            {
                Title = "Patient Distribution by Purok",
                TitleFontSize = 16,
                DefaultFont = "Segoe UI",
                TitleFontWeight = FontWeights.Bold
            };


            var categoryAxis = new CategoryAxis
            {
                Position = AxisPosition.Left,
                Title = "Purok Number",
                TitleFontSize = 12,
                IsTickCentered = true,
                GapWidth = 0.5
            };

            var valueAxis = new LinearAxis
            {
                Position = AxisPosition.Bottom,
                Title = "Number of Patients",
                TitleFontSize = 12,
                Minimum = 0,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                MajorStep = 5
            };

            plotModel.Axes.Add(categoryAxis);
            plotModel.Axes.Add(valueAxis);

            var barSeries = new BarSeries
            {
                Title = "Patients",
                FillColor = OxyColor.FromRgb(70, 130, 180),
                StrokeColor = OxyColors.Black,
                StrokeThickness = 1,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0}",
                LabelMargin = 5
            };

            foreach (var item in purokCounts)
            {
                barSeries.Items.Add(new BarItem { Value = item.Value });
                categoryAxis.Labels.Add(item.Key); // This will ensure purok numbers are in order
            }

            plotModel.Series.Add(barSeries);


            plotModel.Legends.Add(new Legend
            {
                LegendPosition = LegendPosition.BottomCenter,
                LegendPlacement = LegendPlacement.Outside,
                LegendOrientation = LegendOrientation.Horizontal,
            });

            return plotModel;
        }

        private void parrotButton2_Click(object sender, EventArgs e)
        {

        }



        private void bigLabel1_Click(object sender, EventArgs e)
        {

        }

        private void cbxFilterPatientAnalytics_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset all controls visibility first
            SearchCondition.Visible = false;
            btnSearchCondition.Visible = false;
            dtpStartDate.Visible = false;
            dtpEndDate.Visible = false;
            btnSetStart.Visible = false;
            btnSetEnd.Visible = false;
            pnlDatePicker.Visible = false;

            if (cbxFilterPatientAnalytics.SelectedItem == null)
                return;

            string selectedOption = cbxFilterPatientAnalytics.SelectedItem.ToString();

            switch (selectedOption)
            {
                case "Medical Condition":
                    SearchCondition.Visible = true;
                    btnSearchCondition.Visible = true;
                    break;

                case "Date Range":
                    // Show start date picker and set button
                    pnlDatePicker.Visible = true;
                    dtpStartDate.Visible = true;
                    btnSetStart.Visible = true;
                    lblSelectDate.Visible = true;

                    dtpStartDate.Focus();
                    break;

                case "Overall Distribution":
                default:
                    LoadDataAndCreateChart();
                    break;
            }
        }

        private void btnSetStart_Click(object sender, EventArgs e)
        {
            // Hide start date controls
            dtpStartDate.Visible = false;
            btnSetStart.Visible = false;

            // Show end date controls
            dtpEndDate.Visible = true;
            btnSetEnd.Visible = true;
            dtpEndDate.Focus();
        }
        private void btnSetEnd_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime startDate = dtpStartDate.Date;
                DateTime endDate = dtpEndDate.Date;

                if (startDate > endDate)
                {
                    MessageBox.Show("End date must be after start date");
                    return;
                }

                // to hide end date controls
                pnlDatePicker.Visible = false;
                dtpEndDate.Visible = false;
                btnSetEnd.Visible = false;
                lblSelectDate.Visible = false;
                // Generate analytics immediately
                var dateRangeData = GetPatientCountsByDateRange(startDate, endDate);
                pltview.Model = CreateBarChart(dateRangeData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void SearchCondition_TextChanged(object sender, EventArgs e) { }

        private void btnSearchCondition_Click(object sender, EventArgs e)
        {
            // This now only handles Medical Condition searches
            if (cbxFilterPatientAnalytics.SelectedItem?.ToString() == "Medical Condition")
            {
                string condition = SearchCondition.Text.Trim();

                if (string.IsNullOrWhiteSpace(condition))
                {
                    MessageBox.Show("Please enter a medical condition to search.");
                    return;
                }

                try
                {
                    var filteredCounts = GetPatientCountsByConditionAndPurok(condition);
                    pltview.Model = CreateBarChart(filteredCounts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }
        private Dictionary<string, int> GetPatientCountsByConditionAndPurok(string condition)
        {
            var counts = new Dictionary<string, int>();
            int minPurok = int.MaxValue;
            int maxPurok = int.MinValue;

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
                SELECT PN.[PurokNumber], COUNT(*) AS PatientCount
                FROM [PatientName] PN
                INNER JOIN [PatientHistory] PH ON PN.PatientID = PH.PatientID
                WHERE PH.[MedicalHistory] LIKE @condition AND PN.[PurokNumber] IS NOT NULL
                GROUP BY PN.[PurokNumber]
                ORDER BY PN.[PurokNumber]";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@condition", "%" + condition + "%");

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string purok = reader["PurokNumber"].ToString();
                            int count = Convert.ToInt32(reader["PatientCount"]);

                            counts[purok] = count;

                            int purokNum = Convert.ToInt32(purok);
                            minPurok = Math.Min(minPurok, purokNum);
                            maxPurok = Math.Max(maxPurok, purokNum);
                        }
                    }
                }

                // Fill missing puroks
                for (int i = minPurok; i <= maxPurok; i++)
                {
                    if (!counts.ContainsKey(i.ToString()))
                        counts[i.ToString()] = 0;
                }
            }

            return counts.OrderBy(x => Convert.ToInt32(x.Key)).ToDictionary(x => x.Key, x => x.Value);
        }

        private void FilterAnalyticsControl_Load(object sender, EventArgs e)
        {

        }

        private Dictionary<string, int> GetPatientCountsByDateRange(DateTime startDate, DateTime endDate)
        {
            var counts = new Dictionary<string, int>();
            int minPurok = int.MaxValue;
            int maxPurok = int.MinValue;

            using (var connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                string query = @"
            SELECT PN.[PurokNumber], COUNT(*) AS PatientCount
            FROM [PatientName] PN
            INNER JOIN [PatientHistory] PH ON PN.PatientID = PH.PatientID
            WHERE PH.[DateAdded] BETWEEN @startDate AND @endDate
              AND PN.[PurokNumber] IS NOT NULL
            GROUP BY PN.[PurokNumber]
            ORDER BY PN.[PurokNumber]";

                using (var command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@startDate", startDate);
                    command.Parameters.AddWithValue("@endDate", endDate);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string purok = reader["PurokNumber"].ToString();
                            int count = Convert.ToInt32(reader["PatientCount"]);

                            counts[purok] = count;

                            int purokNum = Convert.ToInt32(purok);
                            minPurok = Math.Min(minPurok, purokNum);
                            maxPurok = Math.Max(maxPurok, purokNum);
                        }
                    }
                }

                // Fill missing puroks
                for (int i = minPurok; i <= maxPurok; i++)
                {
                    if (!counts.ContainsKey(i.ToString()))
                        counts[i.ToString()] = 0;
                }
            }

            return counts.OrderBy(x => Convert.ToInt32(x.Key)).ToDictionary(x => x.Key, x => x.Value);
        }


        private void dtpStartDate_Click(object sender, EventArgs e) { }
        
        private void dtpEndDate_Click(object sender, EventArgs e) { }
        
        private void lblSelectDate_Click(object sender, EventArgs e) { }
    }
}
