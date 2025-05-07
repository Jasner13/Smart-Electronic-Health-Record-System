using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEHRS
{
    public partial class ManageInventoryControl : UserControl
    {
        public ManageInventoryControl()
        {
            InitializeComponent();
          
            DisplayDrugProfiles();

            // Set initial states
            ResetPanelColors();
           
            lblViewDrug.Visible = false;
            lblEditDrug.Visible = false;
            lblDeleteDrug.Visible = false;
            SetFieldsReadOnly(true);
            btnSavEditDrug.Visible = false;
            btnDeleteDrug.Visible = false;

        }

        private void SetFieldsReadOnly(bool readOnly)
        {
            tbxDrugNameOutput.ReadOnly = readOnly;
            tbxGenNameOutput.ReadOnly = readOnly;
            tbxBrandNameOuput.ReadOnly = readOnly;
            tbxDrugIDNumOutput.ReadOnly = true; // ID should never be editable
            tbxDateAddedOutput.ReadOnly = true; // DateAdded should never be editable
            tbxExpiryOutput.ReadOnly = readOnly;
            tbxManuDateOutput.ReadOnly = readOnly;
            tbxCategoryOutput.ReadOnly = readOnly;
            tbxStrengthOutput.ReadOnly = readOnly;
            tbxMeasurementOutput.ReadOnly = readOnly;
            tbxQuantityOutput.ReadOnly = readOnly;
            btnChangeDrugPhoto.Enabled = !readOnly;
        }
        public void DisplayDrugProfiles()
        {
            LoadAndDisplayDrugs();
        }

        private string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
        }

        private void RoundPictureBox(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }


        private void ResetPanelColors()
        {
            pnlViewDrug.BackColor = SystemColors.Control;
            pnlEditDrug.BackColor = SystemColors.Control;
            pnlDeleteDrug.BackColor = SystemColors.Control;
        }


        private void LoadAndDisplayDrugs(string searchTerm = "")
        {
            try
            {
                flowDrugProfilePanel.Controls.Clear();

                string query = @"
                    SELECT dn.DrugID, dn.DrugName, dn.GenericName, dn.BrandName, 
                           dt.DateAdded, dt.ExpiryDate, dt.ManufacturingDate, 
                           dd.Category, dd.Strength, dd.MeasurementType, 
                           dd.Quantity, dd.DrugPhoto
                    FROM (DrugName dn
                    INNER JOIN DrugDates dt ON dn.DrugID = dt.DrugID)
                    INNER JOIN DrugDetail dd ON dn.DrugID = dd.DrugID";


                var parameters = new List<OleDbParameter>();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE dn.DrugName LIKE ? OR dn.GenericName LIKE ? OR dn.DrugID LIKE ?";
                    parameters.Add(new OleDbParameter("@term1", $"%{searchTerm}%"));
                    parameters.Add(new OleDbParameter("@term2", $"%{searchTerm}%"));
                    parameters.Add(new OleDbParameter("@term3", $"%{searchTerm}%"));
                }

                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DrugProfileControl drugProfile = CreateDrugProfile(reader);
                            flowDrugProfilePanel.Controls.Add(drugProfile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drugs: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DrugProfileControl CreateDrugProfile(OleDbDataReader reader)
        {
            var profile = new DrugProfileControl
            {
                DrugID = reader["DrugID"].ToString(),
                DrugName = reader["DrugName"].ToString(),
                GenericName = reader["GenericName"].ToString(),
                BrandName = reader["BrandName"].ToString(),
                ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]).ToString("dd/MM/yyyy"),
                ManufacturingDate = Convert.ToDateTime(reader["ManufacturingDate"]).ToString("dd/MM/yyyy"),
                DateAdded = Convert.ToDateTime(reader["DateAdded"]).ToString("dd/MM/yyyy"),
                Category = reader["Category"].ToString(),
                Strength = reader["Strength"].ToString(),
                MeasurementType = reader["MeasurementType"].ToString(),
                DrugQuantity = reader["Quantity"].ToString()
            };

            if (reader["DrugPhoto"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])reader["DrugPhoto"];
                profile.DrugPhoto = ByteArrayToImage(imageBytes);
            }

            // Store all data in Tag property for retrieval on double-click
            profile.Tag = new
            {
                DrugID = reader["DrugID"].ToString(),
                DrugName = reader["DrugName"].ToString(),
                GenericName = reader["GenericName"].ToString(),
                BrandName = reader["BrandName"].ToString(),
                ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]),
                ManufacturingDate = Convert.ToDateTime(reader["ManufacturingDate"]),
                DateAdded = Convert.ToDateTime(reader["DateAdded"]),
                Category = reader["Category"].ToString(),
                Strength = reader["Strength"].ToString(),
                MeasurementType = reader["MeasurementType"].ToString(),
                Quantity = reader["Quantity"].ToString(),
                DrugPhoto = reader["DrugPhoto"] != DBNull.Value ? (byte[])reader["DrugPhoto"] : null
            };

            profile.DoubleClick += (sender, e) => DisplayDrugDetails(profile);
            return profile;
        }

        private void DisplayDrugDetails(DrugProfileControl profile)
        {
            try
            {
                // Get the complete data from Tag
                var drugData = profile.Tag as dynamic;

                // Basic Info
                tbxDrugIDNumOutput.Text = drugData.DrugID;
                tbxDrugNameOutput.Text = drugData.DrugName;
                tbxGenNameOutput.Text = drugData.GenericName;
                tbxBrandNameOuput.Text = drugData.BrandName;

                // Dates
                tbxDateAddedOutput.Text = drugData.DateAdded.ToString("dd/MM/yyyy");
                tbxExpiryOutput.Text = drugData.ExpiryDate.ToString("dd/MM/yyyy");
                tbxManuDateOutput.Text = drugData.ManufacturingDate.ToString("dd/MM/yyyy");

                // Drug Details
                tbxCategoryOutput.Text = drugData.Category;
                tbxStrengthOutput.Text = drugData.Strength;
                tbxMeasurementOutput.Text = drugData.MeasurementType;
                tbxQuantityOutput.Text = drugData.Quantity;

                // Photo
                if (drugData.DrugPhoto != null)
                {
                    using (MemoryStream ms = new MemoryStream(drugData.DrugPhoto))
                    {
                        picBoxDrugOutput.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picBoxDrugOutput.Image = CreateDefaultDrugImage();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying drug details: {ex.Message}");
            }
        }
        private void btnViewDrugMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlViewDrug.BackColor = Color.FromArgb(255, 224, 192);
            SetFieldsReadOnly(true);
            btnSavEditDrug.Visible = false;
            btnDeleteDrug.Visible = false;
            tbxSearchDrugMode.Enabled = true;
            btnSearchDrugMode.Enabled = true;
            lblViewDrug.Visible = true;
            lblEditDrug.Visible = false;
            lblDeleteDrug.Visible = false;
            tbxSearchDrugMode.Focus();

        }

        private void btnEditDrugMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlEditDrug.BackColor = Color.FromArgb(255, 224, 192);
            SetFieldsReadOnly(false);
            btnSavEditDrug.Visible = true;
            btnDeleteDrug.Visible = false;
            tbxSearchDrugMode.Enabled = true;
            btnSearchDrugMode.Enabled = true;
            lblViewDrug.Visible = false;
            lblEditDrug.Visible = true;
            lblDeleteDrug.Visible = false;
            tbxSearchDrugMode.Focus();

        }

        private void btnDeleteDrugMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlDeleteDrug.BackColor = Color.FromArgb(255, 224, 192);
            SetFieldsReadOnly(true);
            btnSavEditDrug.Visible = false;
            btnDeleteDrug.Visible = true;
            tbxSearchDrugMode.Enabled = true;
            btnSearchDrugMode.Enabled = true;
            lblViewDrug.Visible = false;
            lblEditDrug.Visible = false;
            lblDeleteDrug.Visible = true;
            tbxSearchDrugMode.Focus();
        }
        private Image ByteArrayToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void btnSearchDrugMode_Click(object sender, EventArgs e)
        {
            string searchTerm = tbxSearchDrugMode.Text.Trim();
            LoadAndDisplayDrugs(searchTerm);
        }
        private void btnSavEditDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDrugIDNumOutput.Text))
            {
                MessageBox.Show("No drug selected to update.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Save changes to this drug record?",
                                       "Confirm Update",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int drugId = Convert.ToInt32(tbxDrugIDNumOutput.Text);

                    // Parse all data with validation
                    if (!DateTime.TryParseExact(tbxExpiryOutput.Text, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiryDate))
                    {
                        MessageBox.Show("Invalid expiry date format (use dd/MM/yyyy)");
                        return;
                    }

                    if (!DateTime.TryParseExact(tbxManuDateOutput.Text, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime manuDate))
                    {
                        MessageBox.Show("Invalid manufacturing date format (use dd/MM/yyyy)");
                        return;
                    }

                    if (!int.TryParse(tbxQuantityOutput.Text, out int quantity))
                    {
                        MessageBox.Show("Please enter a valid quantity");
                        return;
                    }

                    byte[] imageBytes = null;
                    if (picBoxDrugOutput.Image != null && !picBoxDrugOutput.Image.Equals(CreateDefaultDrugImage()))
                    {
                        using (Bitmap bmp = new Bitmap(picBoxDrugOutput.Image))
                        using (MemoryStream ms = new MemoryStream())
                        {
                            // Save in PNG format which is more reliable than JPEG
                            bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            imageBytes = ms.ToArray();
                        }
                    }

                    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                    {
                        conn.Open();
                        using (OleDbTransaction transaction = conn.BeginTransaction())
                        {
                            try
                            {
                                // 1. Update DrugName table
                                string updateNameQuery = @"UPDATE DrugName SET 
                            DrugName = ?, 
                            GenericName = ?, 
                            BrandName = ?
                            WHERE DrugID = ?";

                                using (OleDbCommand cmd = new OleDbCommand(updateNameQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("?", tbxDrugNameOutput.Text);
                                    cmd.Parameters.AddWithValue("?", tbxGenNameOutput.Text);
                                    cmd.Parameters.AddWithValue("?", tbxBrandNameOuput.Text);
                                    cmd.Parameters.AddWithValue("?", drugId);
                                    cmd.ExecuteNonQuery();
                                }

                                // 2. Update DrugDetail table
                                string updateDetailQuery = @"UPDATE DrugDetail SET 
                            Category = ?,
                            Strength = ?,
                            MeasurementType = ?,
                            Quantity = ?,
                            DrugPhoto = ?
                            WHERE DrugID = ?";

                                using (OleDbCommand cmd = new OleDbCommand(updateDetailQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("?", tbxCategoryOutput.Text);
                                    cmd.Parameters.AddWithValue("?", tbxStrengthOutput.Text);
                                    cmd.Parameters.AddWithValue("?", tbxMeasurementOutput.Text);
                                    cmd.Parameters.AddWithValue("?", quantity);
                                    cmd.Parameters.AddWithValue("?", imageBytes != null ? (object)imageBytes : DBNull.Value);
                                    cmd.Parameters.AddWithValue("?", drugId);
                                    cmd.ExecuteNonQuery();
                                }

                                // 3. Update DrugDates table
                                string updateDatesQuery = @"UPDATE DrugDates SET 
                            ExpiryDate = ?,
                            ManufacturingDate = ?
                            WHERE DrugID = ?";

                                using (OleDbCommand cmd = new OleDbCommand(updateDatesQuery, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("?", expiryDate);
                                    cmd.Parameters.AddWithValue("?", manuDate);
                                    cmd.Parameters.AddWithValue("?", drugId);
                                    cmd.ExecuteNonQuery();
                                }

                                transaction.Commit();
                                MessageBox.Show("Drug updated successfully!");
                                LoadAndDisplayDrugs();
                            }
                            catch (Exception ex)
                            {
                                transaction.Rollback();
                                MessageBox.Show($"Error updating drug: {ex.Message}");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
        }

        private void btnDeleteDrug_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxDrugIDNumOutput.Text))
            {
                MessageBox.Show("No drug selected to delete.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Permanently delete this drug record?",
                                       "Confirm Deletion",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    int drugId = Convert.ToInt32(tbxDrugIDNumOutput.Text);

                    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                    {
                        conn.Open();

                        // Delete from DrugDates first
                        string deleteDatesQuery = "DELETE FROM DrugDates WHERE DrugID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteDatesQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("?", drugId);
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from DrugDetail
                        string deleteDetailQuery = "DELETE FROM DrugDetail WHERE DrugID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteDetailQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("?", drugId);
                            cmd.ExecuteNonQuery();
                        }

                        // Finally delete from DrugName
                        string deleteNameQuery = "DELETE FROM DrugName WHERE DrugID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteNameQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("?", drugId);
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Drug deleted successfully!");
                                ClearFormFields();
                                LoadAndDisplayDrugs();
                            }
                            else
                            {
                                MessageBox.Show("No records were deleted.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting drug: {ex.Message}");
                }
            }
        }
        private Image CreateDefaultDrugImage()
        {
            Bitmap bmp = new Bitmap(100, 100);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.LightGray);
                using (Font font = new Font("Arial", 20))
                {
                    g.DrawString("No Image", font, Brushes.White, new PointF(10, 35));
                }
            }
            return bmp;
        }
        public void DisplayPatientProfiles()
        {
            LoadAndDisplayDrugs();
        }
        private void ClearFormFields()
        {
            tbxDrugNameOutput.Clear();
            tbxGenNameOutput.Clear();
            tbxBrandNameOuput.Clear();
            tbxDrugIDNumOutput.Clear();
            tbxDateAddedOutput.Clear();
            tbxExpiryOutput.Clear();
            tbxManuDateOutput.Clear();
            tbxCategoryOutput.Clear();
            tbxStrengthOutput.Clear();
            tbxMeasurementOutput.Clear();
            tbxQuantityOutput.Clear();
            picBoxDrugOutput.Image = CreateDefaultDrugImage();
        }
        private void btnChangeDrugPhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Drug Photo";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        if (picBoxDrugOutput.Image != null)
                        {
                            picBoxDrugOutput.Image.Dispose();
                        }
                        picBoxDrugOutput.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading photo: " + ex.Message);
            }
        }
        private void flowPatientPanel_Paint(object sender, PaintEventArgs e) { }

        private void panel6_Paint(object sender, PaintEventArgs e) { }

        private void tbxDrugNameOutput_Click(object sender, EventArgs e) { }

        private void tbxExpiryOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxDrugIDNumOutput_Click(object sender, EventArgs e) { }

        private void tbxBrandNameOuput_Click(object sender, EventArgs e) { }

        private void tbxGenNameOutput_Click(object sender, EventArgs e) { }

        private void tbxDateAddedOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxManuDateOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxCategoryOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxStrengthOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxMeasurementOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxQuantityOutput_TextChanged(object sender, EventArgs e) { }

        private void tbxSearchDrugMode_Click(object sender, EventArgs e) { }

        private void cbxFilterDrugMode_SelectedIndexChanged(object sender, EventArgs e) { }
        private void pnlViewDrug_Paint(object sender, PaintEventArgs e) { }
        private void pnlEditDrug_Paint(object sender, PaintEventArgs e) { }
        private void pnlDeleteDrug_Paint(object sender, PaintEventArgs e) { }
        private void lblViewDrug_Click(object sender, EventArgs e) { }
        private void picBoxDrugOutput_Click(object sender, EventArgs e) { }

    }
}
