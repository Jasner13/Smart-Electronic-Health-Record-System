using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace SEHRS
{
    public static class DrugService
    {
        private static string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
        }

        public static void LoadAndDisplayDrugs(FlowLayoutPanel flowPanel, string searchTerm = "")
        {
            try
            {
                if (flowPanel == null || flowPanel.IsDisposed)
                    return;

                // Use BeginInvoke to ensure thread-safe UI updates
                flowPanel.BeginInvoke((MethodInvoker)delegate
                {
                    flowPanel.SuspendLayout();
                    flowPanel.Controls.Clear();

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
                                var profile = CreateDrugProfile(reader);
                                flowPanel.Controls.Add(profile);
                            }
                        }
                    }

                    flowPanel.ResumeLayout();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading drugs: {ex.Message}", "Error",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static DrugProfileControl CreateDrugProfile(OleDbDataReader reader)
        {
            var profile = new DrugProfileControl
            {
                DrugID = reader["DrugID"].ToString(),
                DrugName = reader["DrugName"].ToString(),
                GenericName = reader["GenericName"].ToString(),
                BrandName = reader["BrandName"].ToString(),
                ExpiryDate = Convert.ToDateTime(reader["ExpiryDate"]).ToString("MM/dd/yyyy"),
                ManufacturingDate = Convert.ToDateTime(reader["ManufacturingDate"]).ToString("MM/dd/yyyy"),
                DateAdded = Convert.ToDateTime(reader["DateAdded"]).ToString("MM/dd/yyyy"),
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

            return profile;
        }

        private static Image ByteArrayToImage(byte[] imageBytes)
        {
            if (imageBytes == null || imageBytes.Length == 0)
                return null;

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
    }
}