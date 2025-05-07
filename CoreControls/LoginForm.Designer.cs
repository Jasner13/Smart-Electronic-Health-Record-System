
namespace SEHRS
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            lblErrorMessage = new ReaLTaiizor.Controls.SmallLabel();
            pnlContainer = new Panel();
            pnlLogin = new Panel();
            btnLogin = new ReaLTaiizor.Controls.HopeRoundButton();
            tbxUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            pictureBox1 = new PictureBox();
            pnlContainer.SuspendLayout();
            pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblErrorMessage
            // 
            lblErrorMessage.Anchor = AnchorStyles.None;
            lblErrorMessage.AutoSize = true;
            lblErrorMessage.BackColor = Color.Transparent;
            lblErrorMessage.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrorMessage.ForeColor = Color.Red;
            lblErrorMessage.Location = new Point(89, 426);
            lblErrorMessage.Name = "lblErrorMessage";
            lblErrorMessage.Size = new Size(0, 17);
            lblErrorMessage.TabIndex = 7;
            lblErrorMessage.Visible = false;
            // 
            // pnlContainer
            // 
            pnlContainer.BackColor = Color.White;
            pnlContainer.Controls.Add(pnlLogin);
            pnlContainer.Dock = DockStyle.Fill;
            pnlContainer.Location = new Point(0, 0);
            pnlContainer.Name = "pnlContainer";
            pnlContainer.Size = new Size(594, 626);
            pnlContainer.TabIndex = 0;
            pnlContainer.Paint += pnlContainer_Paint_2;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = Color.White;
            pnlLogin.Controls.Add(lblErrorMessage);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(tbxUsername);
            pnlLogin.Controls.Add(tbxPassword);
            pnlLogin.Controls.Add(pictureBox1);
            pnlLogin.Dock = DockStyle.Fill;
            pnlLogin.Location = new Point(0, 0);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(594, 626);
            pnlLogin.TabIndex = 9;
            pnlLogin.Paint += pnlLogin_Paint;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.None;
            btnLogin.BackColor = Color.FromArgb(21, 101, 192);
            btnLogin.BorderColor = Color.FromArgb(220, 223, 230);
            btnLogin.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnLogin.DangerColor = Color.FromArgb(245, 108, 108);
            btnLogin.DefaultColor = Color.FromArgb(255, 255, 255);
            btnLogin.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnLogin.InfoColor = Color.FromArgb(144, 147, 153);
            btnLogin.Location = new Point(381, 465);
            btnLogin.Name = "btnLogin";
            btnLogin.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnLogin.Size = new Size(123, 33);
            btnLogin.SuccessColor = Color.FromArgb(103, 194, 58);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.TextColor = Color.White;
            btnLogin.WarningColor = Color.FromArgb(230, 162, 60);
            btnLogin.Click += btnLogin_Click;
            // 
            // tbxUsername
            // 
            tbxUsername.Anchor = AnchorStyles.None;
            tbxUsername.AnimateReadOnly = false;
            tbxUsername.AutoCompleteMode = AutoCompleteMode.None;
            tbxUsername.AutoCompleteSource = AutoCompleteSource.None;
            tbxUsername.BackgroundImageLayout = ImageLayout.None;
            tbxUsername.CharacterCasing = CharacterCasing.Normal;
            tbxUsername.Depth = 0;
            tbxUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.HideSelection = true;
            tbxUsername.Hint = "Enter Username";
            tbxUsername.LeadingIcon = null;
            tbxUsername.LeaveOnEnterKey = true;
            tbxUsername.Location = new Point(89, 285);
            tbxUsername.MaxLength = 32767;
            tbxUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxUsername.Name = "tbxUsername";
            tbxUsername.PasswordChar = '\0';
            tbxUsername.PrefixSuffixText = null;
            tbxUsername.ReadOnly = false;
            tbxUsername.RightToLeft = RightToLeft.No;
            tbxUsername.SelectedText = "";
            tbxUsername.SelectionLength = 0;
            tbxUsername.SelectionStart = 0;
            tbxUsername.ShortcutsEnabled = true;
            tbxUsername.Size = new Size(415, 48);
            tbxUsername.TabIndex = 1;
            tbxUsername.TabStop = false;
            tbxUsername.TextAlign = HorizontalAlignment.Left;
            tbxUsername.TrailingIcon = null;
            tbxUsername.UseSystemPasswordChar = false;
            tbxUsername.Click += tbxUsername_Click;
            // 
            // tbxPassword
            // 
            tbxPassword.Anchor = AnchorStyles.None;
            tbxPassword.AnimateReadOnly = false;
            tbxPassword.AutoCompleteMode = AutoCompleteMode.None;
            tbxPassword.AutoCompleteSource = AutoCompleteSource.None;
            tbxPassword.BackgroundImageLayout = ImageLayout.None;
            tbxPassword.CharacterCasing = CharacterCasing.Normal;
            tbxPassword.Depth = 0;
            tbxPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPassword.HideSelection = true;
            tbxPassword.Hint = "Enter Password";
            tbxPassword.LeadingIcon = null;
            tbxPassword.LeaveOnEnterKey = true;
            tbxPassword.Location = new Point(89, 373);
            tbxPassword.MaxLength = 32767;
            tbxPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxPassword.Name = "tbxPassword";
            tbxPassword.PasswordChar = '●';
            tbxPassword.PrefixSuffixText = null;
            tbxPassword.ReadOnly = false;
            tbxPassword.RightToLeft = RightToLeft.No;
            tbxPassword.SelectedText = "";
            tbxPassword.SelectionLength = 0;
            tbxPassword.SelectionStart = 0;
            tbxPassword.ShortcutsEnabled = true;
            tbxPassword.Size = new Size(415, 48);
            tbxPassword.TabIndex = 2;
            tbxPassword.TabStop = false;
            tbxPassword.TextAlign = HorizontalAlignment.Left;
            tbxPassword.TrailingIcon = null;
            tbxPassword.UseSystemPasswordChar = true;
            tbxPassword.Click += tbxPassword_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.White;
            pictureBox1.ErrorImage = null;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(594, 279);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(594, 626);
            Controls.Add(pnlContainer);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(1919, 1018);
            MinimumSize = new Size(189, 54);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += LoginForm_Load;
            pnlContainer.ResumeLayout(false);
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        private void pnlContainer_Paint_2(object sender, PaintEventArgs e)
        {
           
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ReaLTaiizor.Controls.SmallLabel lblErrorMessage;
        private Panel pnlContainer;
        private Panel pnlLogin;
        private ReaLTaiizor.Controls.HopeRoundButton btnLogin;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxUsername;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxPassword;
        private PictureBox pictureBox1;
    }
}
