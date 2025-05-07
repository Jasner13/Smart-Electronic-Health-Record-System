namespace SEHRS
{
    partial class NotifyPatientsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotifyPatientsControl));
            panel1 = new Panel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            flowNotifyPanel = new FlowLayoutPanel();
            tbxSearchPatientMode = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel2 = new Panel();
            btnSearchReceiver = new FontAwesome.Sharp.IconButton();
            btnSearchPatientMode = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            btnSendSMS = new ReaLTaiizor.Controls.ParrotButton();
            btnSendEmail = new ReaLTaiizor.Controls.ParrotButton();
            lblComposeMessage = new ReaLTaiizor.Controls.BigLabel();
            chbxSendToAll = new CheckBox();
            lblReceiver = new ReaLTaiizor.Controls.BigLabel();
            lblPhone = new ReaLTaiizor.Controls.BigLabel();
            lblEmail = new ReaLTaiizor.Controls.BigLabel();
            tbxMessageInput = new TextBox();
            tbxMessageReceiver = new TextBox();
            tbxContactOutput = new TextBox();
            tbxEmailOutput = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(85, 205, 229);
            panel1.Controls.Add(bigLabel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 52);
            panel1.TabIndex = 0;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Dock = DockStyle.Top;
            bigLabel3.Font = new Font("Tahoma", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel3.Location = new Point(0, 0);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(382, 47);
            bigLabel3.TabIndex = 9;
            bigLabel3.Text = "NOTIFY PATIENTS";
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Dock = DockStyle.Top;
            bigLabel1.Font = new Font("Tahoma", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(0, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(382, 47);
            bigLabel1.TabIndex = 9;
            bigLabel1.Text = "NOTIFY PATIENTS";
            // 
            // flowNotifyPanel
            // 
            flowNotifyPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowNotifyPanel.AutoScroll = true;
            flowNotifyPanel.BackColor = Color.FromArgb(230, 239, 255);
            flowNotifyPanel.FlowDirection = FlowDirection.BottomUp;
            flowNotifyPanel.Location = new Point(4, 52);
            flowNotifyPanel.Name = "flowNotifyPanel";
            flowNotifyPanel.Size = new Size(884, 140);
            flowNotifyPanel.TabIndex = 10;
            // 
            // tbxSearchPatientMode
            // 
            tbxSearchPatientMode.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxSearchPatientMode.AnimateReadOnly = false;
            tbxSearchPatientMode.AutoCompleteMode = AutoCompleteMode.None;
            tbxSearchPatientMode.AutoCompleteSource = AutoCompleteSource.None;
            tbxSearchPatientMode.BackgroundImageLayout = ImageLayout.None;
            tbxSearchPatientMode.CharacterCasing = CharacterCasing.Normal;
            tbxSearchPatientMode.Depth = 0;
            tbxSearchPatientMode.ErrorMessage = "That can't be empty.";
            tbxSearchPatientMode.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSearchPatientMode.HelperText = "Try here";
            tbxSearchPatientMode.HideSelection = true;
            tbxSearchPatientMode.Hint = "Name or ID";
            tbxSearchPatientMode.LeadingIcon = null;
            tbxSearchPatientMode.LeaveOnEnterKey = true;
            tbxSearchPatientMode.Location = new Point(4, 3);
            tbxSearchPatientMode.MaxLength = 32767;
            tbxSearchPatientMode.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxSearchPatientMode.Name = "tbxSearchPatientMode";
            tbxSearchPatientMode.PasswordChar = '\0';
            tbxSearchPatientMode.PrefixSuffixText = null;
            tbxSearchPatientMode.ReadOnly = false;
            tbxSearchPatientMode.RightToLeft = RightToLeft.No;
            tbxSearchPatientMode.SelectedText = "";
            tbxSearchPatientMode.SelectionLength = 0;
            tbxSearchPatientMode.SelectionStart = 0;
            tbxSearchPatientMode.ShortcutsEnabled = true;
            tbxSearchPatientMode.Size = new Size(837, 48);
            tbxSearchPatientMode.TabIndex = 27;
            tbxSearchPatientMode.TabStop = false;
            tbxSearchPatientMode.TextAlign = HorizontalAlignment.Left;
            tbxSearchPatientMode.TrailingIcon = null;
            tbxSearchPatientMode.UseSystemPasswordChar = false;
            tbxSearchPatientMode.Click += tbxSearchPatientMode_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(163, 226, 225);
            panel2.Controls.Add(btnSearchReceiver);
            panel2.Controls.Add(tbxSearchPatientMode);
            panel2.Controls.Add(flowNotifyPanel);
            panel2.Location = new Point(0, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 202);
            panel2.TabIndex = 28;
            // 
            // btnSearchReceiver
            // 
            btnSearchReceiver.Anchor = AnchorStyles.Right;
            btnSearchReceiver.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearchReceiver.IconColor = Color.Black;
            btnSearchReceiver.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchReceiver.IconSize = 30;
            btnSearchReceiver.Location = new Point(838, 3);
            btnSearchReceiver.Name = "btnSearchReceiver";
            btnSearchReceiver.Size = new Size(50, 47);
            btnSearchReceiver.TabIndex = 28;
            btnSearchReceiver.UseVisualStyleBackColor = true;
            btnSearchReceiver.Click += btnSearchReceiver_Click;
            // 
            // btnSearchPatientMode
            // 
            btnSearchPatientMode.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearchPatientMode.IconColor = Color.Black;
            btnSearchPatientMode.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchPatientMode.IconSize = 30;
            btnSearchPatientMode.Location = new Point(840, 1);
            btnSearchPatientMode.Name = "btnSearchPatientMode";
            btnSearchPatientMode.Size = new Size(50, 45);
            btnSearchPatientMode.TabIndex = 28;
            btnSearchPatientMode.UseVisualStyleBackColor = true;
            btnSearchPatientMode.Click += btnSearchPatientMode_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(242, 247, 255);
            panel3.Controls.Add(btnSendSMS);
            panel3.Controls.Add(btnSendEmail);
            panel3.Controls.Add(lblComposeMessage);
            panel3.Controls.Add(chbxSendToAll);
            panel3.Controls.Add(lblReceiver);
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblEmail);
            panel3.Controls.Add(tbxMessageInput);
            panel3.Controls.Add(tbxMessageReceiver);
            panel3.Controls.Add(tbxContactOutput);
            panel3.Controls.Add(tbxEmailOutput);
            panel3.Location = new Point(0, 254);
            panel3.Name = "panel3";
            panel3.Size = new Size(891, 386);
            panel3.TabIndex = 29;
            panel3.Paint += panel3_Paint;
            // 
            // btnSendSMS
            // 
            btnSendSMS.Anchor = AnchorStyles.None;
            btnSendSMS.BackgroundColor = Color.Transparent;
            btnSendSMS.ButtonImage = (Image)resources.GetObject("btnSendSMS.ButtonImage");
            btnSendSMS.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSendSMS.ButtonText = "Send via SMS";
            btnSendSMS.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSendSMS.ClickTextColor = Color.DodgerBlue;
            btnSendSMS.CornerRadius = 5;
            btnSendSMS.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendSMS.Horizontal_Alignment = StringAlignment.Center;
            btnSendSMS.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSendSMS.HoverTextColor = Color.DodgerBlue;
            btnSendSMS.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSendSMS.Location = new Point(513, 338);
            btnSendSMS.Name = "btnSendSMS";
            btnSendSMS.Size = new Size(116, 28);
            btnSendSMS.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSendSMS.TabIndex = 11;
            btnSendSMS.TextColor = Color.Black;
            btnSendSMS.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSendSMS.Vertical_Alignment = StringAlignment.Center;
            btnSendSMS.Click += btnSendSMS_Click;
            // 
            // btnSendEmail
            // 
            btnSendEmail.Anchor = AnchorStyles.None;
            btnSendEmail.BackgroundColor = Color.Transparent;
            btnSendEmail.ButtonImage = (Image)resources.GetObject("btnSendEmail.ButtonImage");
            btnSendEmail.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSendEmail.ButtonText = "Send via Email";
            btnSendEmail.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSendEmail.ClickTextColor = Color.DodgerBlue;
            btnSendEmail.CornerRadius = 5;
            btnSendEmail.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSendEmail.Horizontal_Alignment = StringAlignment.Center;
            btnSendEmail.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnSendEmail.HoverTextColor = Color.DodgerBlue;
            btnSendEmail.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSendEmail.Location = new Point(315, 338);
            btnSendEmail.Name = "btnSendEmail";
            btnSendEmail.Size = new Size(119, 28);
            btnSendEmail.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSendEmail.TabIndex = 10;
            btnSendEmail.TextColor = Color.Black;
            btnSendEmail.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSendEmail.Vertical_Alignment = StringAlignment.Center;
            btnSendEmail.Click += btnSendEmail_Click;
            // 
            // lblComposeMessage
            // 
            lblComposeMessage.Anchor = AnchorStyles.None;
            lblComposeMessage.AutoSize = true;
            lblComposeMessage.BackColor = Color.Transparent;
            lblComposeMessage.Font = new Font("ISOCPEUR", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblComposeMessage.ForeColor = Color.FromArgb(80, 80, 80);
            lblComposeMessage.Location = new Point(360, 176);
            lblComposeMessage.Name = "lblComposeMessage";
            lblComposeMessage.Size = new Size(214, 36);
            lblComposeMessage.TabIndex = 9;
            lblComposeMessage.Text = "Compose Message";
            // 
            // chbxSendToAll
            // 
            chbxSendToAll.AutoSize = true;
            chbxSendToAll.FlatAppearance.BorderColor = Color.DarkTurquoise;
            chbxSendToAll.FlatAppearance.BorderSize = 2;
            chbxSendToAll.FlatAppearance.CheckedBackColor = Color.FromArgb(85, 205, 229);
            chbxSendToAll.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbxSendToAll.ForeColor = Color.Black;
            chbxSendToAll.Location = new Point(4, 8);
            chbxSendToAll.Name = "chbxSendToAll";
            chbxSendToAll.Size = new Size(100, 21);
            chbxSendToAll.TabIndex = 8;
            chbxSendToAll.Text = "Send To All";
            chbxSendToAll.UseVisualStyleBackColor = true;
            chbxSendToAll.CheckedChanged += chbxSendToAll_CheckedChanged;
            // 
            // lblReceiver
            // 
            lblReceiver.Anchor = AnchorStyles.Left;
            lblReceiver.AutoSize = true;
            lblReceiver.BackColor = Color.Transparent;
            lblReceiver.Font = new Font("ISOCPEUR", 19.8000011F);
            lblReceiver.ForeColor = Color.FromArgb(80, 80, 80);
            lblReceiver.Location = new Point(75, 131);
            lblReceiver.Name = "lblReceiver";
            lblReceiver.Size = new Size(58, 42);
            lblReceiver.TabIndex = 7;
            lblReceiver.Text = "To:";
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("ISOCPEUR", 19.8000011F);
            lblPhone.ForeColor = Color.FromArgb(80, 80, 80);
            lblPhone.Location = new Point(75, 79);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(103, 42);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("ISOCPEUR", 19.8000011F);
            lblEmail.ForeColor = Color.FromArgb(80, 80, 80);
            lblEmail.Location = new Point(75, 29);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(91, 42);
            lblEmail.TabIndex = 5;
            lblEmail.Text = "Email:";
            // 
            // tbxMessageInput
            // 
            tbxMessageInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMessageInput.BackColor = Color.FromArgb(163, 226, 225);
            tbxMessageInput.BorderStyle = BorderStyle.None;
            tbxMessageInput.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMessageInput.Location = new Point(201, 215);
            tbxMessageInput.Multiline = true;
            tbxMessageInput.Name = "tbxMessageInput";
            tbxMessageInput.RightToLeft = RightToLeft.No;
            tbxMessageInput.ScrollBars = ScrollBars.Vertical;
            tbxMessageInput.Size = new Size(522, 119);
            tbxMessageInput.TabIndex = 4;
            tbxMessageInput.TextChanged += tbxMessageInput_TextChanged;
            // 
            // tbxMessageReceiver
            // 
            tbxMessageReceiver.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMessageReceiver.BorderStyle = BorderStyle.None;
            tbxMessageReceiver.Font = new Font("Segoe UI", 15F);
            tbxMessageReceiver.Location = new Point(201, 129);
            tbxMessageReceiver.Multiline = true;
            tbxMessageReceiver.Name = "tbxMessageReceiver";
            tbxMessageReceiver.Size = new Size(522, 44);
            tbxMessageReceiver.TabIndex = 3;
            tbxMessageReceiver.TextChanged += tbxMessageReceiver_TextChanged;
            // 
            // tbxContactOutput
            // 
            tbxContactOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxContactOutput.BorderStyle = BorderStyle.None;
            tbxContactOutput.Font = new Font("Segoe UI", 15F);
            tbxContactOutput.Location = new Point(201, 77);
            tbxContactOutput.Multiline = true;
            tbxContactOutput.Name = "tbxContactOutput";
            tbxContactOutput.Size = new Size(522, 44);
            tbxContactOutput.TabIndex = 2;
            tbxContactOutput.TextChanged += tbxContactOutput_TextChanged;
            // 
            // tbxEmailOutput
            // 
            tbxEmailOutput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxEmailOutput.BorderStyle = BorderStyle.None;
            tbxEmailOutput.Font = new Font("Segoe UI", 15F);
            tbxEmailOutput.Location = new Point(201, 27);
            tbxEmailOutput.Multiline = true;
            tbxEmailOutput.Name = "tbxEmailOutput";
            tbxEmailOutput.Size = new Size(522, 44);
            tbxEmailOutput.TabIndex = 1;
            tbxEmailOutput.TextChanged += tbxEmailOutput_TextChanged;
            // 
            // NotifyPatientsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "NotifyPatientsControl";
            Size = new Size(891, 640);
            Load += NotifyPatientsControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private FlowLayoutPanel flowNotifyPanel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxSearchPatientMode;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnSearchPatientMode;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnSearchReceiver;
        private TextBox tbxMessageInput;
        private TextBox tbxMessageReceiver;
        private TextBox tbxContactOutput;
        private TextBox tbxEmailOutput;
        private ReaLTaiizor.Controls.BigLabel lblEmail;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel lblReceiver;
        private ReaLTaiizor.Controls.BigLabel lblPhone;
        private CheckBox chbxSendToAll;
        private ReaLTaiizor.Controls.BigLabel lblComposeMessage;
        private ReaLTaiizor.Controls.ParrotButton btnSendEmail;
        private ReaLTaiizor.Controls.ParrotButton btnSendSMS;
    }
}
