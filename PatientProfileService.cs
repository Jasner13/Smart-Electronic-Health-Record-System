using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;

namespace SEHRS
{
    public static class PatientProfileService
    {
        private static string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRSFinal\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
        }

        public static Image ByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }

        public static void LoadAndDisplayPatients(FlowLayoutPanel flowPanel, string searchTerm = "")
        {
            try
            {
                flowPanel.Controls.Clear();

                string query = "SELECT * FROM PatientQuery";
                var parameters = new List<OleDbParameter>();

                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FirstName LIKE ? OR LastName LIKE ? OR PatientID LIKE ?";
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
                            var profile = CreatePatientProfile(reader);
                            flowPanel.Controls.Add(profile);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading patients: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static PatientProfileControl CreatePatientProfile(OleDbDataReader reader)
        {
            try
            {
                var profile = new PatientProfileControl
                {
                    // Basic info
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    MiddleName = reader["MiddleName"].ToString(),
                    PatientID = reader["PatientID"].ToString(),

                    // Display properties
                    PatientName = $"{reader["FirstName"]} {reader["LastName"]}",
                    PatientBirthDate = Convert.ToDateTime(reader["BirthDate"]).ToString("dd/MM/yyyy"),
                    Age = reader["Age"].ToString()
                };

                // Handle photo data
                byte[] imageBytes = null;
                if (reader["PatientPhoto"] != DBNull.Value)
                {
                    imageBytes = (byte[])reader["PatientPhoto"];
                    // Set image immediately (synchronously for the profile control)
                    profile.PatientPhoto = ByteArrayToImage(imageBytes);
                }

                // Store complete data in Tag
                profile.Tag = new
                {
                    // Personal Information
                    FirstName = reader["FirstName"].ToString(),
                    LastName = reader["LastName"].ToString(),
                    MiddleName = reader["MiddleName"].ToString(),
                    PatientID = reader["PatientID"].ToString(),
                    BirthDate = Convert.ToDateTime(reader["BirthDate"]),

                    // Demographic Information
                    PurokNumber = reader["PurokNumber"].ToString(),
                    Age = reader["Age"].ToString(),
                    Sex = reader["Sex"].ToString(),
                    ContactNumber = reader["ContactNumber"].ToString(),
                    Email = reader["Email"].ToString(),

                    // Medical Information
                    MedicalHistory = reader["MedicalHistory"].ToString(),
                    Prescription = reader["Prescription"].ToString(),
                    DateAdded = Convert.ToDateTime(reader["DateAdded"]),


                    // Photo (store raw bytes)
                    PatientPhoto = imageBytes
                };

                return profile;
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error creating patient profile: {ex.Message}");
                throw; // Re-throw to handle at higher level
            }
        }
        public static List<PatientModel> GetAllPatients(string searchTerm = "")
        {
            List<PatientModel> patients = new List<PatientModel>();

            string query = "SELECT * FROM PatientQuery";
            var parameters = new List<OleDbParameter>();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                query += " WHERE FirstName LIKE ? OR LastName LIKE ? OR PatientID LIKE ?";
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
                        PatientModel patient = new PatientModel
                        {
                            ID = Convert.ToInt32(reader["PatientID"]),
                            FirstName = reader["FirstName"].ToString(),
                            MiddleName = reader["MiddleName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            ContactNumber = reader["ContactNumber"].ToString(),
                            Email = reader["Email"].ToString(),
                            BirthDate = Convert.ToDateTime(reader["BirthDate"]),

                            Photo = reader["PatientPhoto"] != DBNull.Value ? 
                            PatientProfileService.ByteArrayToImage((byte[])reader["PatientPhoto"]) : null
                        };

                        patients.Add(patient);
                    }
                }
            }

            return patients;
        }

        public class PatientModel
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string MiddleName { get; set; }
            public string Email { get; set; }
            public string ContactNumber { get; set; }
            public DateTime BirthDate { get; set; }
            public Image Photo { get; set; }

        }
    }
}