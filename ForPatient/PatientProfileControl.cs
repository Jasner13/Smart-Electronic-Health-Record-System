using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SEHRS
{
    public partial class PatientProfileControl : BaseControl
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string PurokNumber { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string MedicalHistory { get; set; }
        public string Prescription { get; set; }
        //public Image PatientPhoto { get; set; }
        public event EventHandler ProfileDoubleClicked;


        public PatientProfileControl()
        {
            InitializeComponent();
            ApplyRoundedCorners();

            this.DoubleClick += (sender, e) => OnProfileDoubleClick();
            EnableDoubleClickRecursive(this);
        }
        private void EnableDoubleClickRecursive(Control control)
        {
            control.DoubleClick += (sender, e) => OnProfileDoubleClick();
            foreach (Control child in control.Controls)
            {
                EnableDoubleClickRecursive(child);
            }
        }
        private void EnableDoubleClick(Control control)
        {
            control.DoubleClick += (sender, e) => OnDoubleClick(e);
            foreach (Control child in control.Controls)
            {
                EnableDoubleClick(child);
            }
        }
        private void OnProfileDoubleClick()
        {
            ProfileDoubleClicked?.Invoke(this, EventArgs.Empty);
        }

        private void PatientProfileControl_DoubleClick(object sender, EventArgs e)
        {
            ProfileDoubleClicked?.Invoke(this, EventArgs.Empty);
        }

        private DateTime _lastClickTime;

      
        private void SetDoubleClick(Control control)
        {
            control.DoubleClick += (sender, e) => OnDoubleClick(e);
            control.MouseDoubleClick += (sender, e) => OnDoubleClick(e);

            foreach (Control child in control.Controls)
            {
                SetDoubleClick(child); // Recursively set for all child controls
            }
        }
        protected override void OnDoubleClick(EventArgs e)
        {
            base.OnDoubleClick(e);
            ProfileDoubleClicked?.Invoke(this, e);
        }

        public string PatientName
        {
            get => lblName.Text;
            set => lblName.Text = value;
        }

        public string PatientBirthDate
        {
            get => lblBirthDate.Text;
            set => lblBirthDate.Text = $"DOB: {value}";
        }

        public string PatientID
        {
            get => lblID.Text;
            set => lblID.Text = $"ID: {value}";
        }
        public Image PatientPhoto
        {
            get => picPatientDynamicProfile.Image;
            set => picPatientDynamicProfile.Image = value;
        }

        public NewPatientControl NewPatientControl
        {
            get => default;
            set
            {
            }
        }

   
       
       



       
        private void lblName_Click(object sender, EventArgs e)
        {
            
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picPatientDynamicProfile_Click(object sender, EventArgs e)
        {

        }

        private void pnlPatientProfile_DoubleClick(object sender, EventArgs e)
        {

        }

        private void pnlPatientProfile_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}