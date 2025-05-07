using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Text;

namespace SEHRS
{
    public partial class NewDrugControl : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        public NewDrugControl()
        {
            InitializeComponent();
         
            LoadDrugs();
            DisplayDrugProfiles();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
        }
        private string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
        }

        private void LoadDrugs()
        {
            try
            {
                string query = @"SELECT DrugName.DrugID, DrugName.DrugName, DrugName.GenericName, DrugName.BrandName, 
                        DrugDates.DateAdded, DrugDates.ExpiryDate, DrugDates.ManufacturingDate, 
                        DrugDetail.Category, DrugDetail.Strength, DrugDetail.MeasurementType, 
                        DrugDetail.Quantity, DrugDetail.DrugPhoto
                        FROM (DrugName INNER JOIN DrugDates ON DrugName.DrugID = DrugDates.[DrugID]) 
                        INNER JOIN DrugDetail ON DrugName.DrugID = DrugDetail.[DrugID]";

                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "DrugData");
                    dgvDrugRecords.DataSource = ds.Tables["DrugData"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading drugs: " + ex.Message);
            }
        }

        public void DisplayDrugProfiles()
        {
            try
            {
                flowNewDrugPanel.Controls.Clear();

                string query = @"SELECT DrugName.DrugID, DrugName.DrugName, DrugDates.ExpiryDate, 
                        DrugDetail.Quantity, DrugDetail.DrugPhoto
                        FROM (DrugName INNER JOIN DrugDates ON DrugName.DrugID = DrugDates.[DrugID]) 
                        INNER JOIN DrugDetail ON DrugName.DrugID = DrugDetail.[DrugID]";

                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DrugProfileControl drugProfile = new DrugProfileControl
                            {
                                DrugID = reader["DrugID"].ToString(),
                                DrugName = reader["DrugName"].ToString(),
                                ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]).ToString("MM/dd/yyyy"),
                                DrugQuantity = reader["Quantity"].ToString()
                            };

                            if (reader["DrugPhoto"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["DrugPhoto"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    drugProfile.DrugPhoto = Image.FromStream(ms);
                                }
                            }

                            drugProfile.Margin = new Padding(5);
                            flowNewDrugPanel.Controls.Add(drugProfile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying drug profiles: " + ex.Message);
            }
        }

        private void btnUploadDrugPhoto_Click(object sender, EventArgs e)
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
                        Image originalImage = Image.FromFile(openFileDialog.FileName);
                        int maxWidth = 300;
                        int maxHeight = 300;
                        int newWidth, newHeight;

                        if (originalImage.Width > originalImage.Height)
                        {
                            newWidth = maxWidth;
                         newHeight = (int)(originalImage.Height * maxWidth / (double)originalImage.Width);
                        }
                        else
                        {
                            newHeight = maxHeight;
                          newWidth = (int)(originalImage.Width * maxHeight / (double)originalImage.Height);
                        }

                        Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);
                        picBoxDrugInput.Image = resizedImage;
                        originalImage.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading photo: " + ex.Message, "Upload Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields
                if (string.IsNullOrWhiteSpace(tbxDrugNameInput.Text) ||
                    string.IsNullOrWhiteSpace(tbxQuantityInput.Text) ||
                    string.IsNullOrWhiteSpace(tbxStrengthInput.Text))
                {
                    MessageBox.Show("Please fill in all required fields.");
                    return;
                }

                // Parse quantity
                if (!int.TryParse(tbxQuantityInput.Text.Trim(), out int quantity))
                {
                    MessageBox.Show("Please enter a valid numeric quantity");
                    return;
                }

                // Parse dates
                if (!DateTime.TryParseExact(tbxExpiryInput.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime expiryDate))
                {
                    MessageBox.Show("Please enter expiry date in dd/MM/yyyy format");
                    return;
                }

                if (!DateTime.TryParseExact(tbxManuDateInput.Text, "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime manuDate))
                {
                    MessageBox.Show("Please enter manufacturing date in dd/MM/yyyy format");
                    return;
                }

                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                {
                    conn.Open();

                    // Insert into DrugName
                    string query1 = "INSERT INTO DrugName (DrugName, GenericName, BrandName) VALUES (?, ?, ?)";
                    int drugId;
                    using (OleDbCommand cmd = new OleDbCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("?", tbxDrugNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxGenNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxBrandNameInput.Text.Trim());
                        cmd.ExecuteNonQuery();
                        drugId = Convert.ToInt32(new OleDbCommand("SELECT @@IDENTITY", conn).ExecuteScalar());
                    }

                    // Insert into DrugDetail
                    string query2 = "INSERT INTO DrugDetail (DrugID, Category, Strength, MeasurementType, Quantity, DrugPhoto) VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("?", drugId);
                        cmd.Parameters.AddWithValue("?", tbxCategoryInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxStrengthInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxMeasurementInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", quantity); // Use parsed integer

                        if (picBoxDrugInput.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                picBoxDrugInput.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                cmd.Parameters.AddWithValue("?", ms.ToArray());
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("?", DBNull.Value);
                        }
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into DrugDates
                    string query3 = "INSERT INTO DrugDates (DrugID, DateAdded, ExpiryDate, ManufacturingDate) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query3, conn))
                    {
                        cmd.Parameters.AddWithValue("?", drugId);
                        cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("?", expiryDate.ToString("MM/dd/yyyy"));
                        cmd.Parameters.AddWithValue("?", manuDate.ToString("MM/dd/yyyy"));
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Drug added successfully!");
                    LoadDrugs();
                    ClearFormFields();
                    DisplayDrugProfiles();
                }
            }
            catch (OleDbException dbEx)
            {
                MessageBox.Show($"Database Error: {dbEx.Message}");
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error adding drug: " + ex.Message);
            }
        }

        private void ClearFormFields()
        {
            tbxDrugNameInput.Clear();
            tbxGenNameInput.Clear();
            tbxBrandNameInput.Clear();
            tbxExpiryInput.Clear();
            tbxManuDateInput.Clear();
            tbxCategoryInput.Clear();
            tbxStrengthInput.Clear();
            tbxMeasurementInput.Clear();
            tbxQuantityInput.Clear();
            tbxDateAddedInput.Clear();
            picBoxDrugInput.Image = null;
        }

        private void dgvDrugRecords_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void flowDrugPanel_Paint_1(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel10_Paint(object sender, PaintEventArgs e) { }
        private void NewDrugControl_Load_1(object sender, EventArgs e) { }
        private void tbxDateAddedInput_TextChanged(object sender, EventArgs e) { }
        private void tbxDrugNameInput_Click(object sender, EventArgs e) { }
        private void tbxGenNameInput_Click(object sender, EventArgs e) { }
        private void tbxBrandNameInput_Click(object sender, EventArgs e) { }
        private void tbxExpiryInput_TextChanged(object sender, EventArgs e) { }
        private void tbxManuDateInput_TextChanged(object sender, EventArgs e) { }
        private void tbxCategoryInput_TextChanged(object sender, EventArgs e) { }
        private void tbxStrengthInput_TextChanged(object sender, EventArgs e) { }
        private void tbxMeasurementInput_TextChanged(object sender, EventArgs e) { }
        private void tbxQuantityInput_TextChanged(object sender, EventArgs e) { }
        private void picBoxDrugInput_Click(object sender, EventArgs e) { }
        private void flowNewDrugPanel_Click(object sender, EventArgs e) { }
        private void dgvDrugRecords_Click(object sender, EventArgs e) { }


    }
}