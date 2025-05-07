using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SEHRS.PatientProfileService;

namespace SEHRS
{
    public partial class NotifyPatientsControl : UserControl
    {
        public NotifyPatientsControl()
        {
            InitializeComponent();
            LoadPatientProfiles();
           

        }
        private string GetConnectionString()
        {
            return @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 
            SecondSem\FinalProject - WinForms\SEHRS(LatestUpdate)\SEHRS\Resources
            \SEHRSDB\SEHRS(db).accdb""";
        }

        private void LoadPatientProfiles(string searchTerm = "")
        {
            flowNotifyPanel.Controls.Clear();

            List<PatientModel> patients = PatientProfileService.GetAllPatients(searchTerm);

            foreach (var patient in patients)
            {
                var profile = new PatientProfileControl
                {
                    FirstName = patient.FirstName,
                    LastName = patient.LastName,
                    MiddleName = patient.MiddleName,
                    Email = patient.Email,
                    ContactNumber = patient.ContactNumber,
                    PatientName = $"{patient.LastName}, {patient.FirstName} {patient.MiddleName}",

                    PatientBirthDate = patient.BirthDate.ToString("dd/MM/yyyy"),

                    PatientID = patient.ID.ToString(),
                    PatientPhoto = patient.Photo
                };

                profile.ProfileDoubleClicked += (s, e) =>
                {
                    tbxMessageReceiver.Text = profile.PatientName;
                    tbxEmailOutput.Text = profile.Email;
                    tbxContactOutput.Text = profile.ContactNumber;
                };

                flowNotifyPanel.Controls.Add(profile);
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            try
            {
                string recipient = "";
                string subject = "SEHRS Notification";
                string body = tbxMessageInput.Text.Trim();

                if (chbxSendToAll.Checked)
                {
                    if (string.IsNullOrEmpty(body))
                    {
                        MessageBox.Show("Please enter a message to send.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    List<PatientModel> patients = PatientProfileService.GetAllPatients();
                    int sentCount = 0;

                    foreach (var patient in patients)
                    {
                        recipient = patient.Email?.Trim();

                        if (!string.IsNullOrEmpty(recipient) && recipient.Contains("@"))
                        {
                            try
                            {
                                EmailService.SendEmail(recipient, subject, body);
                                sentCount++;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine($"Failed to send to {recipient}: {ex.Message}");
                            }
                        }
                    }

                    MessageBox.Show($"Emails successfully sent to {sentCount} patient(s).", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                recipient = tbxEmailOutput.Text.Trim(); 

                if (string.IsNullOrEmpty(recipient) || string.IsNullOrEmpty(body))
                {
                    MessageBox.Show("Please select a patient and write a message.", "Missing Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EmailService.SendEmail(recipient, subject, body);
                MessageBox.Show("Email successfully sent!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSendSMS_Click(object sender, EventArgs e)
        {
            try
            {
                string recipientPhoneNumber = tbxContactOutput.Text.Trim();
                string message = tbxMessageInput.Text.Trim();

                if (string.IsNullOrEmpty(message))
                {
                    MessageBox.Show("Please enter a message.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (chbxSendToAll.Checked)
                {
                    var patients = PatientProfileService.GetAllPatients();
                    int successCount = 0;

                    foreach (var patient in patients)
                    {
                        try
                        {
                            if (!string.IsNullOrEmpty(patient.ContactNumber))
                            {
                                bool sent = await SmsService.SendSmsAsync(patient.ContactNumber, message);
                                if (sent) successCount++;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Failed to send to {patient.ContactNumber}: {ex.Message}");
                        }
                    }

                    MessageBox.Show($"Sent to {successCount}/{patients.Count} patients", "Result");
                    return;
                }

                // Single recipient case
                if (string.IsNullOrEmpty(recipientPhoneNumber))
                {
                    MessageBox.Show("Please select a recipient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                bool result = await SmsService.SendSmsAsync(recipientPhoneNumber, message);
                MessageBox.Show(result ? "SMS sent successfully!" : "Failed to send SMS");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxSendToAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSendToAll.Checked)
            {
                tbxMessageReceiver.Text = "All Patients";
                tbxEmailOutput.Text = "";
                tbxContactOutput.Text = "";

                tbxEmailOutput.ReadOnly = true;
                tbxContactOutput.ReadOnly = true;
                btnSendSMS.Enabled = false;
            }
            else
            {
                tbxMessageReceiver.Clear();
                tbxEmailOutput.Clear();
                tbxContactOutput.Clear();

                tbxEmailOutput.ReadOnly = false;
                tbxContactOutput.ReadOnly = false;
                btnSendSMS.Enabled = true;
            }
        }

        private void btnSearchReceiver_Click(object sender, EventArgs e)
        {
            string searchTerm = tbxSearchPatientMode.Text.Trim();
            LoadPatientProfiles(searchTerm);
        }
        private void NotifyPatientsControl_Load(object sender, EventArgs e) { }
        private void btnSearchPatientMode_Click(object sender, EventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void tbxSearchPatientMode_Click(object sender, EventArgs e) { }
        private void tbxContactOutput_TextChanged(object sender, EventArgs e) { }
        private void tbxEmailOutput_TextChanged(object sender, EventArgs e) { }
        private void tbxMessageReceiver_TextChanged(object sender, EventArgs e) { }
        private void tbxMessageInput_TextChanged(object sender, EventArgs e) { }
    }
}
