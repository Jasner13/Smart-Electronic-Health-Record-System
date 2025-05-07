using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SEHRS
{
    public partial class DrugProfileControl : BaseControl
    {
        public DrugProfileControl()
        {
            InitializeComponent();
            this.Load += new EventHandler(DrugDetailControl_Load);
            pnlDrugProfile.Margin = new Padding(5, 5, 5, 5);

            pnlDrugProfile.DoubleClick += (sender, e) =>
            {
                // Raise the DoubleClick event for the entire UserControl
                OnDoubleClick(e);
            };
            
            // Make sure all child controls forward their double-click events
            foreach (Control control in pnlDrugProfile.Controls)
            {
                control.DoubleClick += (sender, e) => OnDoubleClick(e);
            }
        }

        public string GenericName { get; set; }
        public string BrandName { get; set; }
        public string DateAdded { get; set; }
        public string ManufacturingDate { get; set; }
        public string Category { get; set; }
        public string Strength { get; set; }
        public string MeasurementType { get; set; }

        // Properties to set drug details
        public string DrugName
        {
            get => lbldrgName.Text;
            set => lbldrgName.Text = value;
        }
        public string ExpiryDate
        {
            get => lblexpDate.Text;
            set => lblexpDate.Text = $"Expiry: {value}";
        }
        public string DrugID
        {
            get => lbldrgID.Text;
            set => lbldrgID.Text = $"ID: {value}";
        }
        public string DrugQuantity
        {
            get => lblQuantity.Text;
            set => lblQuantity.Text = $"Quantity: {value}";
        }
        public Image DrugPhoto
        {
            get => picDrugDynamicProfile.Image;
            set => picDrugDynamicProfile.Image = value;
        }
        private void DrugDetailControl_Load(object sender, EventArgs e) { }
        private void picDrugDynamicProfile_Click(object sender, EventArgs e) { }
        private void pnlDrugProfile_DoubleClick(object sender, EventArgs e) { }
        private void pnlDrugProfile_MouseDoubleClick(object sender, MouseEventArgs e) { }
        private void lblexpDate_Click(object sender, EventArgs e) { }
    }
}