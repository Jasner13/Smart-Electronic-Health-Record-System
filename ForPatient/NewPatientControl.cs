using SEHRS.Repositories;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;
using System.Globalization;

namespace SEHRS
{
    public partial class NewPatientControl : UserControl
    {

        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;



        public NewPatientControl()
        {
            InitializeComponent();


            // Set up event handlers
            this.Load += NewPatientControl_Load;

            RoundPictureBox(picBoxPatientInput);
           
        }

        private void NewPatientControl_Load(object sender, EventArgs e)
        {

            LoadPatients();
            DisplayPatientProfiles();
        }

        private void LoadPatients()
        {
            try
            {
                string query = "SELECT * FROM PatientQuery"; // Adjust table name if needed
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\OOP2 SecondSem\\FinalProject - WinForms\\SEHRS(LatestUpdate)\\SEHRS\\Resources\\SEHRSDB\\SEHRS(db).accdb\""))
                {
                    conn.Open();
                    da = new OleDbDataAdapter(query, conn);
                    ds = new DataSet();
                    da.Fill(ds, "PatientQuery");
                    dgvPatientsRecords.DataSource = ds.Tables["PatientQuery"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading patients: " + ex.Message);
            }
        }

        public void DisplayPatientProfiles()
        {
            try
            {
                flowPatientPanel.Controls.Clear();

                string query = "SELECT PatientID, FirstName, LastName, BirthDate, PatientPhoto FROM  PatientQuery ORDER BY DateAdded DESC";
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\OOP2 SecondSem\\FinalProject - WinForms\\SEHRS(LatestUpdate)\\SEHRS\\Resources\\SEHRSDB\\SEHRS(db).accdb\""))
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PatientProfileControl patientProfile = new PatientProfileControl
                            {
                                PatientID = reader["PatientID"].ToString(),
                                PatientName = $"{reader["FirstName"]} {reader["LastName"]}",
                                PatientBirthDate = Convert.ToDateTime(reader["BirthDate"]).ToString("MM/dd/yyyy")
                            };

                            // Retrieve and convert the image
                            if (reader["PatientPhoto"] != DBNull.Value)
                            {
                                byte[] imageBytes = (byte[])reader["PatientPhoto"];
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    patientProfile.PatientPhoto = Image.FromStream(ms);
                                }
                            }

                            patientProfile.Margin = new Padding(5);
                            flowPatientPanel.Controls.Add(patientProfile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error displaying patient profiles: " + ex.Message);
            }
        }

        private void btnUploadPhoto_Click(object sender, EventArgs e)
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
                        // Load the selected image
                        Image originalImage = Image.FromFile(openFileDialog.FileName);

                        // Resize image if needed to save database space
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

                        // Create resized image
                        Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);

                        // Assign to PictureBox
                        picBoxPatientInput.Image = resizedImage;

                        // Dispose original image to free resources
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

        private void RoundPictureBox(PictureBox picBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, picBox.Width, picBox.Height);
            picBox.Region = new Region(path);
        }


        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxFNameInput.Text) ||
                    string.IsNullOrWhiteSpace(tbxLNameInput.Text) ||
                    string.IsNullOrWhiteSpace(tbxAgeInput.Text))
                {
                    MessageBox.Show("Please fill in all required fields.", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!DateTime.TryParseExact(tbxBirthInput.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
                {
                    MessageBox.Show("Please enter birth date in dd/MM/yyyy format", "Invalid Date",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

               
                if (!DateTime.TryParseExact(tbxDateAddedInput.Text.Trim(), "dd/MM/yyyy",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateAdded))
                {
                    MessageBox.Show("Please enter Date Added in dd/MM/yyyy format", "Invalid Date",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\OOP2 SecondSem\\FinalProject - WinForms\\SEHRS(LatestUpdate)\\SEHRS\\Resources\\SEHRSDB\\SEHRS(db).accdb\""))
                {
                    conn.Open();

                    // Insert into PatientName table
                    string query1 = "INSERT INTO PatientName (FirstName, MiddleName, LastName, PurokNumber) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query1, conn))
                    {
                        cmd.Parameters.AddWithValue("?", tbxFNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxMNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxLNameInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxPurokNumInput.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    // Get the auto-generated PatientID
                    int patientID;
                    string getIdQuery = "SELECT @@IDENTITY";
                    using (OleDbCommand cmd = new OleDbCommand(getIdQuery, conn))
                    {
                        patientID = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert into PatientDemographic table with correct date format
                    string query2 = "INSERT INTO PatientDemographic (PatientID, Age, Sex, BirthDate, ContactNumber) VALUES (?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query2, conn))
                    {
                        cmd.Parameters.AddWithValue("?", patientID);
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(tbxAgeInput.Text.Trim()));
                        cmd.Parameters.AddWithValue("?", tbxSexInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", birthDate); // Use the parsed DateTime object
                        cmd.Parameters.AddWithValue("?", tbxContactInput.Text.Trim());
                        cmd.ExecuteNonQuery();
                    }

                    // Insert into PatientHistory table
                    // Updated: Add DateAdded in PatientHistory table
                    string query3 = "INSERT INTO PatientHistory (PatientID, Email, MedicalHistory, Prescription, PatientPhoto, DateAdded) VALUES (?, ?, ?, ?, ?, ?)";
                    using (OleDbCommand cmd = new OleDbCommand(query3, conn))
                    {
                        cmd.Parameters.AddWithValue("?", patientID);
                        cmd.Parameters.AddWithValue("?", tbxEmailInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxMedicalHistoryInput.Text.Trim());
                        cmd.Parameters.AddWithValue("?", tbxPrescriptionInput.Text.Trim());

                        if (picBoxPatientInput.Image != null)
                        {
                            using (MemoryStream ms = new MemoryStream())
                            {
                                picBoxPatientInput.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                                byte[] photoBytes = ms.ToArray();
                                cmd.Parameters.AddWithValue("?", photoBytes);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("?", DBNull.Value);
                        }

                        // Add parsed dateAdded at the end
                        cmd.Parameters.AddWithValue("?", dateAdded);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Patient added successfully!", "Success",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPatients();
                    ClearFormFields();
                    DisplayPatientProfiles();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid age (numeric value) and date in dd/MM/yyyy format",
                              "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding patient: " + ex.Message, "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearFormFields()
        {
            tbxFNameInput.Clear();
            tbxMNameInput.Clear();
            tbxLNameInput.Clear();
            tbxPurokNumInput.Clear();
            tbxAgeInput.Clear();
            tbxSexInput.Clear();
            tbxBirthInput.Clear();
            tbxContactInput.Clear();
            tbxEmailInput.Clear();
            tbxMedicalHistoryInput.Clear();
            tbxPrescriptionInput.Clear();
            tbxDateAddedInput.Clear();
            picBoxPatientInput.Image = null;
        }

        private void flowPatientPanel_Click(object sender, EventArgs e)
        {

        }
        private void flowPatientPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e) { }
        private void materialTextBoxEdit2_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void picBoxPatientInput_Click(object sender, EventArgs e) { }
        private void panel10_Paint(object sender, PaintEventArgs e) { }
        private void tbxLNameInput_Click(object sender, EventArgs e) { }
        private void tbxMNameInput_Click(object sender, EventArgs e) { }
        private void tbxPurokNumInput_Click(object sender, EventArgs e) { }
        private void gbxBirthInput_Enter(object sender, EventArgs e) { }
        private void tbxBirthInput_TextChanged(object sender, EventArgs e) { }
        private void gbxContactInput_Enter(object sender, EventArgs e) { }
        private void tbxContactInput_TextChanged(object sender, EventArgs e) { }
        private void tbxAgeInput_Click(object sender, EventArgs e) { }
        private void gbxSerNumInput_Enter(object sender, EventArgs e) { }
        private void tbxEmailInput_TextChanged(object sender, EventArgs e) { }
        private void tbxSexInput_Click(object sender, EventArgs e) { }
        private void tbxMedicalHistoryInput_Click(object sender, EventArgs e) { }
        private void tbxPrescriptionInput_Click(object sender, EventArgs e) { }
        private void dgvPatientsRecords_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void tbxDateAddedInput_Click(object sender, EventArgs e)
        {

        }
    }
}