using System.Text;
using System.Security.Cryptography;
using System.Data.OleDb;

namespace SEHRS
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            this.lblErrorMessage.BringToFront();
            this.lblErrorMessage.Visible = !DesignMode;
        }

      

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;

            if (string.IsNullOrWhiteSpace(tbxUsername.Text) || string.IsNullOrWhiteSpace(tbxPassword.Text))
            {
                lblErrorMessage.Text = "Username and Password are required!";
                lblErrorMessage.Visible = true;
                return;
            }

            AuthenticateUser(tbxUsername.Text, tbxPassword.Text);
        }

        private void AuthenticateUser(string username, string password)
        {
            string hashedPassword = HashPassword(password);

            string connStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""C:\OOP2 SecondSem\FinalProject - WinForms\SEHRSFinal\SEHRS\Resources\SEHRSDB\SEHRS(db).accdb""";
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = ? AND Password = ?";

            using (OleDbConnection conn = new OleDbConnection(connStr))
            using (OleDbCommand cmd = new OleDbCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("?", username);
                cmd.Parameters.AddWithValue("?", hashedPassword);

                conn.Open();
                int userCount = (int)cmd.ExecuteScalar();

                if (userCount > 0)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblErrorMessage.Text = "Invalid username or password!";
                    lblErrorMessage.Visible = true;
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; 
                return cp;
            }
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            pnlContainer.Left = (this.ClientSize.Width - pnlContainer.Width) / 2;
            pnlContainer.Top = (this.ClientSize.Height - pnlContainer.Height) / 2;
        }

        private void pnlLogin_Paint(object sender, PaintEventArgs e) { }
        private void tbxUsername_Click(object sender, EventArgs e) { }
        private void tbxPassword_Click(object sender, EventArgs e) { }
    }
}
