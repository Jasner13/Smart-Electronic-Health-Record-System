using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace SEHRS
{
    public partial class ManagePatientsControl : UserControl
    {
        public ManagePatientsControl()
        {
            InitializeComponent();
            RoundPictureBox(picBoxPatientOutput);

            // Set initial states
            ResetPanelColors();
           
            lblDelete.Visible = false;
            lblView.Visible = false;
            lblEdit.Visible = false;
            SetFieldsReadOnly(true); 

          
            LoadAndDisplayPatients(); 
        }
        private void LoadAndDisplayPatients(string searchTerm = "")
        {
            try
            {
                flowPatientProfilePanel.SuspendLayout();
                flowPatientProfilePanel.Controls.Clear();

                string query = "SELECT * FROM PatientQuery";
                var parameters = new List<OleDbParameter>();

                // Only add search conditions if searchTerm is provided
                if (!string.IsNullOrWhiteSpace(searchTerm))
                {
                    query += " WHERE FirstName LIKE ? OR LastName LIKE ? OR PatientID LIKE ?";
                    parameters.Add(new OleDbParameter("@term1", $"%{searchTerm}%"));
                    parameters.Add(new OleDbParameter("@term2", $"%{searchTerm}%"));
                    parameters.Add(new OleDbParameter("@term3", $"%{searchTerm}%"));
                }

                using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    if (parameters.Count > 0)
                    {
                        cmd.Parameters.AddRange(parameters.ToArray());
                    }

                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var profile = PatientProfileService.CreatePatientProfile(reader);

                            // Attach double-click handler
                            profile.ProfileDoubleClicked += (sender, e) =>
                            {
                                if (InvokeRequired)
                                {
                                    Invoke(new Action(() => DisplayPatientDetails(((PatientProfileControl)sender).Tag)));
                                }
                                else
                                {
                                    DisplayPatientDetails(((PatientProfileControl)sender).Tag);
                                }
                            };

                            flowPatientProfilePanel.Controls.Add(profile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}");
            }
            finally
            {
                flowPatientProfilePanel.ResumeLayout(true);
                Application.DoEvents();
            }
        }

        private string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
        }

        private Image ByteArrayToImage(byte[] imageBytes)
        {
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void OnPatientProfileDoubleClick(object sender, EventArgs e, PatientProfileControl profile)
        {
            dynamic data = profile.Tag;

            tbxFNameOutput.Text = data.FirstName;
            tbxLNameOutput.Text = data.LastName;
            tbxMNameOutput.Text = data.MiddleName;
            tbxPatientIDNumOutput.Text = data.PatientID;
            tbxBirthOutput.Text = ((DateTime)data.BirthDate).ToString("dd/MM/yyyy");
            tbxPurokNumOutput.Text = data.PurokNumber;
            tbxAgeOutput.Text = data.Age;
            tbxSexOutput.Text = data.Sex;
            tbxContactOutput.Text = data.ContactNumber;
            tbxEmailOutput.Text = data.Email;
            tbxMedicalHistoryOutput.Text = data.MedicalHistory;
            tbxPrescriptionOutput.Text = data.Prescription;

            if (data.PatientPhoto != null)
            {
                picBoxPatientOutput.Image = PatientProfileService.ByteArrayToImage(data.PatientPhoto);
            }
            else
            {
                picBoxPatientOutput.Image = CreateDefaultProfileImage(); 
            }
        }

        private PatientProfileControl CreatePatientProfile(OleDbDataReader reader)
        {
            var profile = new PatientProfileControl
            {
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                MiddleName = reader["MiddleName"].ToString(),
                PatientID = reader["PatientID"].ToString(),
                PurokNumber = reader["PurokNumber"].ToString(),
                Age = reader["Age"].ToString(),
                Sex = reader["Sex"].ToString(),
                ContactNumber = reader["ContactNumber"].ToString(),
                Email = reader["Email"].ToString(),
                MedicalHistory = reader["MedicalHistory"].ToString(),
                Prescription = reader["Prescription"].ToString(),
                PatientName = $"{reader["FirstName"]} {reader["LastName"]}",
                PatientBirthDate = Convert.ToDateTime(reader["BirthDate"]).ToString("dd/MM/yyyy")

            };

            if (reader["PatientPhoto"] != DBNull.Value)
            {
                byte[] imageBytes = (byte[])reader["PatientPhoto"];
                profile.PatientPhoto = ByteArrayToImage(imageBytes);
            }

            // Attach the double click event handler
            profile.DoubleClick += (sender, e) =>
            {
                var clickedProfile = (PatientProfileControl)sender;
                DisplayPatientDetails(clickedProfile);

                // Debug output
                Console.WriteLine($"Double-clicked: {clickedProfile.FirstName} {clickedProfile.LastName}");
                Console.WriteLine($"Setting tbxFNameOutput to: {clickedProfile.FirstName}");
            };

            return profile;
        }

        public void DisplayPatientDetails(dynamic patientData)
        {
            try
            {
                // Use BeginInvoke for thread safety
                if (InvokeRequired)
                {
                    BeginInvoke(new Action(() => DisplayPatientDetails(patientData)));
                    return;
                }

                // Basic Info
                tbxFNameOutput.Text = patientData.FirstName;
                tbxLNameOutput.Text = patientData.LastName;
                tbxMNameOutput.Text = patientData.MiddleName;
                tbxPatientIDNumOutput.Text = patientData.PatientID;
                tbxBirthOutput.Text = patientData.BirthDate.ToString("dd/MM/yyyy");

                // Demographic Info
                tbxPurokNumOutput.Text = patientData.PurokNumber;
                tbxAgeOutput.Text = patientData.Age;
                tbxSexOutput.Text = patientData.Sex;
                tbxContactOutput.Text = patientData.ContactNumber;
                tbxEmailOutput.Text = patientData.Email;
                tbxDateAddedOutput.Text = patientData.DateAdded.ToString("dd/MM/yyyy");

                // Medical Info
                tbxMedicalHistoryOutput.Text = patientData.MedicalHistory;
                tbxPrescriptionOutput.Text = patientData.Prescription;

              
                Task.Run(() =>
                {
                    Image photo = null;
                    if (patientData.PatientPhoto != null)
                    {
                        photo = PatientProfileService.ByteArrayToImage(patientData.PatientPhoto);
                    }
                    else
                    {
                        photo = CreateDefaultProfileImage();
                    }

                    if (picBoxPatientOutput.InvokeRequired)
                    {
                        picBoxPatientOutput.Invoke(new Action(() => picBoxPatientOutput.Image = photo));
                    }
                    else
                    {
                        picBoxPatientOutput.Image = photo;
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying patient details: {ex.Message}");
            }
        }


        private Image CreateDefaultProfileImage()
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


       
        private void btnSearchPatientMode_Click(object sender, EventArgs e)
        {
           
            string searchTerm = tbxSearchPatientMode.Text.Trim();
            LoadAndDisplayPatients(searchTerm);
        }

        private void btnChangePhoto_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Title = "Select Patient Photo";
                    openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                    openFileDialog.Multiselect = false;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Dispose current image if it exists
                        if (picBoxPatientOutput.Image != null)
                        {
                            picBoxPatientOutput.Image.Dispose();
                        }

                     
                        picBoxPatientOutput.Image = Image.FromFile(openFileDialog.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error uploading photo: " + ex.Message, "Upload Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void RoundPictureBox(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }
      

        private void SetFieldsReadOnly(bool readOnly)
        {
            tbxFNameOutput.ReadOnly = readOnly;
            tbxLNameOutput.ReadOnly = readOnly;
            tbxMNameOutput.ReadOnly = readOnly;
            tbxPatientIDNumOutput.ReadOnly = true; // ID should never be editable
            tbxBirthOutput.ReadOnly = readOnly;
            tbxAgeOutput.ReadOnly = readOnly;
            tbxSexOutput.ReadOnly = readOnly;
            tbxPurokNumOutput.ReadOnly = readOnly;
            tbxEmailOutput.ReadOnly = readOnly;
            tbxContactOutput.ReadOnly = readOnly;
            tbxMedicalHistoryOutput.ReadOnly = readOnly;
            tbxPrescriptionOutput.ReadOnly = readOnly;
            tbxDateAddedOutput.ReadOnly = readOnly;

            // Enable/disable photo change button based on mode
            btnChangePatientPhoto.Enabled = !readOnly;
        }
        private void btnPatientHistoryMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlViewPatient.BackColor = Color.FromArgb(255, 224, 192);

          
            tbxSearchPatientMode.Enabled = true;
            btnSearchPatientMode.Enabled = true;
            btnDeletePatientRecord.Visible = false;
            lblEdit.Visible = false;
            lblDelete.Visible = false;
            lblView.Visible = true;

            // Make fields read-only
            SetFieldsReadOnly(true);

            tbxSearchPatientMode.Focus();
          
        }

        private void btnEditPatientRecMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlEditPatient.BackColor = Color.FromArgb(255, 224, 192);

            // Enable search controls
            tbxSearchPatientMode.Enabled = true;
            btnSearchPatientMode.Enabled = true;
            btnSaveEditPatient.Visible = true;
            btnDeletePatientRecord.Visible = false;
            lblEdit.Visible = true;
            lblDelete.Visible = false;
            lblView.Visible = false;


            // Make fields editable
            SetFieldsReadOnly(false);

            tbxSearchPatientMode.Focus();

        }
        private void btnDeletePatientRecMode_Click(object sender, EventArgs e)
        {
            ResetPanelColors();
            pnlDeletePatient.BackColor = Color.FromArgb(255, 224, 192);

            tbxSearchPatientMode.Enabled = true;
            btnSearchPatientMode.Enabled = true;
            btnSaveEditPatient.Visible = false;
            btnDeletePatientRecord.Visible = true;
            lblEdit.Visible = false;
            lblDelete.Visible = true;
            lblView.Visible = false;
            SetFieldsReadOnly(true);

           
            tbxSearchPatientMode.Focus();

        }
        private void tbxSearchPatientMode_Click(object sender, EventArgs e)
        {
            string searchTerm = tbxSearchPatientMode.Text.Trim(); 

            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a name or ID to search.");
                return;
            }
            LoadAndDisplayPatients(searchTerm);
        }

        private void ResetPanelColors()
        {
            pnlViewPatient.BackColor = SystemColors.Control; 
            pnlEditPatient.BackColor = SystemColors.Control;
            pnlDeletePatient.BackColor = SystemColors.Control;
        }


        private void btnSaveEditPatient_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPatientIDNumOutput.Text))
            {
                MessageBox.Show("No patient selected to update.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to save changes to this patient record?",
                                       "Confirm Update",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                   
                    string cleanPatientId = new string(tbxPatientIDNumOutput.Text.Where(char.IsDigit).ToArray());

                    if (string.IsNullOrEmpty(cleanPatientId))
                    {
                        MessageBox.Show("Invalid Patient ID format", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int patientId = Convert.ToInt32(cleanPatientId);

                   
                    if (!DateTime.TryParseExact(tbxBirthOutput.Text, "dd/MM/yyyy",
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
                    {
                        MessageBox.Show("Please enter a valid date in dd/MM/yyyy format", "Invalid Date",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!DateTime.TryParseExact(tbxDateAddedOutput.Text, "dd/MM/yyyy",
                         CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateAdded))
                    {
                        MessageBox.Show("Please enter a valid Date Added in dd/MM/yyyy format", "Invalid Date",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }


                 
                    if (!int.TryParse(tbxAgeOutput.Text, out int age))
                    {
                        MessageBox.Show("Please enter a valid age (numeric value)", "Invalid Age",
                                      MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string updateQuery = @"UPDATE PatientQuery SET 
                        FirstName = ?, 
                        LastName = ?, 
                        MiddleName = ?,
                        BirthDate = ?,
                        PurokNumber = ?,
                        Age = ?,
                        Sex = ?,
                        ContactNumber = ?,
                        Email = ?,
                        MedicalHistory = ?,
                        Prescription = ?,
                        DateAdded = ?,
                        PatientPhoto = ?
                        WHERE PatientID = ?";



                    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                    using (OleDbCommand cmd = new OleDbCommand(updateQuery, conn))
                    {
                        // Add parameters with explicit data types
                        cmd.Parameters.Add("@FirstName", OleDbType.VarWChar).Value = tbxFNameOutput.Text;
                        cmd.Parameters.Add("@LastName", OleDbType.VarWChar).Value = tbxLNameOutput.Text;
                        cmd.Parameters.Add("@MiddleName", OleDbType.VarWChar).Value = tbxMNameOutput.Text;
                        cmd.Parameters.Add("@BirthDate", OleDbType.DBDate).Value = birthDate;
                        cmd.Parameters.Add("@PurokNumber", OleDbType.VarWChar).Value = tbxPurokNumOutput.Text;
                        cmd.Parameters.Add("@Age", OleDbType.Integer).Value = age;
                        cmd.Parameters.Add("@Sex", OleDbType.VarWChar).Value = tbxSexOutput.Text;
                        cmd.Parameters.Add("@ContactNumber", OleDbType.VarWChar).Value = tbxContactOutput.Text;
                        cmd.Parameters.Add("@Email", OleDbType.VarWChar).Value = tbxEmailOutput.Text;
                        cmd.Parameters.Add("@MedicalHistory", OleDbType.LongVarWChar).Value = tbxMedicalHistoryOutput.Text;
                        cmd.Parameters.Add("@Prescription", OleDbType.LongVarWChar).Value = tbxPrescriptionOutput.Text;
                        cmd.Parameters.Add("@DateAdded", OleDbType.DBDate).Value = dateAdded;


                        // Handle photo
                        byte[] photoBytes = ImageToByteArray(picBoxPatientOutput.Image);
                        if (photoBytes != null && photoBytes.Length > 0 &&
                            !picBoxPatientOutput.Image.Equals(CreateDefaultProfileImage()))
                        {
                            cmd.Parameters.Add("@PatientPhoto", OleDbType.LongVarBinary).Value = photoBytes;
                        }
                        else
                        {
                            cmd.Parameters.Add("@PatientPhoto", OleDbType.LongVarBinary).Value = DBNull.Value;
                        }

                        cmd.Parameters.Add("@PatientID", OleDbType.Integer).Value = patientId;

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Patient record updated successfully!", "Success",
                                          MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAndDisplayPatients();
                        }
                        else
                        {
                            MessageBox.Show("No records were updated.", "Warning",
                                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating patient record: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helper method to convert Image to byte array
        private byte[] ImageToByteArray(Image image)
        {
            try
            {
                
                if (image == null)
                {
                    return null;
                }

                // Create a new bitmap to avoid GDI+ errors (this also avoids issues with disposed images)
                using (Bitmap bmp = new Bitmap(image))
                using (MemoryStream ms = new MemoryStream())
                {
                    // Save in PNG format which is more reliable than JPEG
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    return ms.ToArray();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Image conversion error: {ex.Message}");
                return null;
            }
        }



        private void btnDeletePatientRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxPatientIDNumOutput.Text))
            {
                MessageBox.Show("No patient selected to delete.", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to permanently delete this patient record?",
                                       "Confirm Deletion",
                                       MessageBoxButtons.YesNo,
                                       MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Clean the PatientID by removing any non-numeric characters
                    string cleanPatientId = new string(tbxPatientIDNumOutput.Text.Where(char.IsDigit).ToArray());

                    if (string.IsNullOrEmpty(cleanPatientId))
                    {
                        MessageBox.Show("Invalid Patient ID format", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int patientId = Convert.ToInt32(cleanPatientId);

                    using (OleDbConnection conn = new OleDbConnection(GetConnectionString()))
                    {
                        conn.Open();

                        // Delete from PatientHistory first (due to potential foreign key constraints)
                        string deleteHistoryQuery = "DELETE FROM PatientHistory WHERE PatientID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteHistoryQuery, conn))
                        {
                            cmd.Parameters.Add("@PatientID", OleDbType.Integer).Value = patientId;
                            cmd.ExecuteNonQuery();
                        }

                        // Delete from PatientDemographic
                        string deleteDemographicQuery = "DELETE FROM PatientDemographic WHERE PatientID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteDemographicQuery, conn))
                        {
                            cmd.Parameters.Add("@PatientID", OleDbType.Integer).Value = patientId;
                            cmd.ExecuteNonQuery();
                        }

                        // Finally delete from PatientName
                        string deleteNameQuery = "DELETE FROM PatientName WHERE PatientID = ?";
                        using (OleDbCommand cmd = new OleDbCommand(deleteNameQuery, conn))
                        {
                            cmd.Parameters.Add("@PatientID", OleDbType.Integer).Value = patientId;
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Patient record deleted successfully!", "Success",
                                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear form fields and refresh the patient list
                                ClearFormFields();
                                LoadAndDisplayPatients();
                            }
                            else
                            {
                                MessageBox.Show("No records were deleted. Patient may not exist.", "Warning",
                                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting patient record: {ex.Message}", "Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearFormFields()
        {
            // Clear all text fields
            tbxFNameOutput.Clear();
            tbxLNameOutput.Clear();
            tbxMNameOutput.Clear();
            tbxPatientIDNumOutput.Clear();
            tbxBirthOutput.Clear();
            tbxAgeOutput.Clear();
            tbxSexOutput.Clear();
            tbxPurokNumOutput.Clear();
            tbxEmailOutput.Clear();
            tbxContactOutput.Clear();
            tbxMedicalHistoryOutput.Clear();
            tbxPrescriptionOutput.Clear();
            tbxDateAddedOutput.Clear();


            // Reset photo to default
            picBoxPatientOutput.Image = CreateDefaultProfileImage();
        }
        private void tbxMNameOutput_Click(object sender, EventArgs e) { }
        private void tbxLNameOutput_Click(object sender, EventArgs e) { }
        private void tbxContactOutput_TextChanged(object sender, EventArgs e) { }
        private void tbxEmailOutput_TextChanged(object sender, EventArgs e) { }
        private void tbxSexOutput_Click(object sender, EventArgs e) { }
        private void tbxAgeOutput_Click(object sender, EventArgs e) { }
        private void tbxPurokNumOutput_Click(object sender, EventArgs e) { }
        private void tbxPatientIDNumOutput_Click(object sender, EventArgs e) { }
        private void tbxMedicalHistoryOutput_Click(object sender, EventArgs e) { }
        private void tbxPrescriptionOutput_Click(object sender, EventArgs e) { }
        private void cyberButton1_Click(object sender, EventArgs e) { }
        private void panel7_Paint(object sender, PaintEventArgs e) { }
        private void bigLabel1_Click(object sender, EventArgs e) { }
        private void panel13_Paint(object sender, PaintEventArgs e) { }
        private void flowPatientPanel_Paint(object sender, PaintEventArgs e) { }
        private void pnlViewPatient_Paint(object sender, PaintEventArgs e) { }
        private void pnlEditPatient_Paint(object sender, PaintEventArgs e) { }
        private void pnlDeletePatient_Paint(object sender, PaintEventArgs e) { }
        private void lblEdit_Click(object sender, EventArgs e) { }
        private void gbxContactOutput_Enter(object sender, EventArgs e) { }
        private void tbxDateAddedOutput_TextChanged(object sender, EventArgs e) { }
        private void picBoxOutput_Click(object sender, EventArgs e) { }

        private void tbxFNameOutput_Click(object sender, EventArgs e) { }
    }
}