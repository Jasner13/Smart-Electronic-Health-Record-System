namespace SEHRS
{
    partial class NewPatientControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatientControl));
            panel1 = new Panel();
            panel3 = new Panel();
            btnAddPatient = new ReaLTaiizor.Controls.ParrotButton();
            tbxDateAddedInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel11 = new Panel();
            panel12 = new Panel();
            panel5 = new Panel();
            btnUploadPatientPhoto = new ReaLTaiizor.Controls.CyberButton();
            tbxFNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxLNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxMNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            picBoxPatientInput = new PictureBox();
            panel7 = new Panel();
            panel9 = new Panel();
            panel6 = new Panel();
            panel8 = new Panel();
            tbxPrescriptionInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxMedicalHistoryInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            gbxSerNumInput = new GroupBox();
            label2 = new Label();
            tbxEmailInput = new TextBox();
            gbxBirthInput = new GroupBox();
            label1 = new Label();
            tbxBirthInput = new TextBox();
            tbxAgeInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxPurokNumInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            gbxContactInput = new GroupBox();
            label5 = new Label();
            tbxContactInput = new TextBox();
            tbxSexInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel4 = new Panel();
            panel10 = new Panel();
            dgvPatientsRecords = new DataGridView();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            flowPatientPanel = new FlowLayoutPanel();
            pnlNewPatientHeader = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxPatientInput).BeginInit();
            gbxSerNumInput.SuspendLayout();
            gbxBirthInput.SuspendLayout();
            gbxContactInput.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientsRecords).BeginInit();
            pnlNewPatientHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel10);
            panel1.Controls.Add(pnlNewPatientHeader);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 641);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint_1;
            // 
            // panel3
            // 
            panel3.AutoSize = true;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnAddPatient);
            panel3.Controls.Add(tbxDateAddedInput);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(tbxPrescriptionInput);
            panel3.Controls.Add(tbxMedicalHistoryInput);
            panel3.Controls.Add(gbxSerNumInput);
            panel3.Controls.Add(gbxBirthInput);
            panel3.Controls.Add(tbxAgeInput);
            panel3.Controls.Add(tbxPurokNumInput);
            panel3.Controls.Add(gbxContactInput);
            panel3.Controls.Add(tbxSexInput);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 589);
            panel3.TabIndex = 22;
            panel3.Paint += panel3_Paint;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Anchor = AnchorStyles.Right;
            btnAddPatient.BackgroundColor = Color.FromArgb(214, 242, 241);
            btnAddPatient.ButtonImage = (Image)resources.GetObject("btnAddPatient.ButtonImage");
            btnAddPatient.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnAddPatient.ButtonText = "Add Patient";
            btnAddPatient.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnAddPatient.ClickTextColor = Color.DodgerBlue;
            btnAddPatient.CornerRadius = 15;
            btnAddPatient.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPatient.Horizontal_Alignment = StringAlignment.Center;
            btnAddPatient.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnAddPatient.HoverTextColor = Color.DodgerBlue;
            btnAddPatient.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnAddPatient.Location = new Point(313, 519);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(124, 39);
            btnAddPatient.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAddPatient.TabIndex = 63;
            btnAddPatient.TextColor = Color.Blue;
            btnAddPatient.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAddPatient.Vertical_Alignment = StringAlignment.Center;
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // tbxDateAddedInput
            // 
            tbxDateAddedInput.Anchor = AnchorStyles.Left;
            tbxDateAddedInput.AnimateReadOnly = false;
            tbxDateAddedInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxDateAddedInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxDateAddedInput.BackgroundImageLayout = ImageLayout.None;
            tbxDateAddedInput.CharacterCasing = CharacterCasing.Normal;
            tbxDateAddedInput.Depth = 0;
            tbxDateAddedInput.ErrorMessage = "That can't be empty.";
            tbxDateAddedInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDateAddedInput.HelperText = "Try here";
            tbxDateAddedInput.HideSelection = true;
            tbxDateAddedInput.Hint = "Date Added";
            tbxDateAddedInput.LeadingIcon = null;
            tbxDateAddedInput.LeaveOnEnterKey = true;
            tbxDateAddedInput.Location = new Point(18, 252);
            tbxDateAddedInput.MaxLength = 32767;
            tbxDateAddedInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxDateAddedInput.Name = "tbxDateAddedInput";
            tbxDateAddedInput.PasswordChar = '\0';
            tbxDateAddedInput.PrefixSuffixText = null;
            tbxDateAddedInput.ReadOnly = false;
            tbxDateAddedInput.RightToLeft = RightToLeft.No;
            tbxDateAddedInput.SelectedText = "";
            tbxDateAddedInput.SelectionLength = 0;
            tbxDateAddedInput.SelectionStart = 0;
            tbxDateAddedInput.ShortcutsEnabled = true;
            tbxDateAddedInput.Size = new Size(148, 48);
            tbxDateAddedInput.TabIndex = 64;
            tbxDateAddedInput.TabStop = false;
            tbxDateAddedInput.TextAlign = HorizontalAlignment.Left;
            tbxDateAddedInput.TrailingIcon = null;
            tbxDateAddedInput.UseSystemPasswordChar = false;
            tbxDateAddedInput.Click += tbxDateAddedInput_Click;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(163, 226, 225);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 189);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 389);
            panel11.TabIndex = 25;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(163, 226, 225);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(449, 189);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 389);
            panel12.TabIndex = 26;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnUploadPatientPhoto);
            panel5.Controls.Add(tbxFNameInput);
            panel5.Controls.Add(tbxLNameInput);
            panel5.Controls.Add(tbxMNameInput);
            panel5.Controls.Add(picBoxPatientInput);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel9);
            panel5.Controls.Add(panel6);
            panel5.Controls.Add(panel8);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(459, 189);
            panel5.TabIndex = 24;
            // 
            // btnUploadPatientPhoto
            // 
            btnUploadPatientPhoto.Alpha = 20;
            btnUploadPatientPhoto.Anchor = AnchorStyles.Left;
            btnUploadPatientPhoto.BackColor = Color.Transparent;
            btnUploadPatientPhoto.Background = true;
            btnUploadPatientPhoto.Background_WidthPen = 4F;
            btnUploadPatientPhoto.BackgroundPen = true;
            btnUploadPatientPhoto.ColorBackground = Color.FromArgb(37, 52, 68);
            btnUploadPatientPhoto.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUploadPatientPhoto.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUploadPatientPhoto.ColorBackground_Pen = Color.LightCoral;
            btnUploadPatientPhoto.ColorLighting = Color.LightCoral;
            btnUploadPatientPhoto.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUploadPatientPhoto.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUploadPatientPhoto.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUploadPatientPhoto.Effect_1 = true;
            btnUploadPatientPhoto.Effect_1_ColorBackground = Color.LightCoral;
            btnUploadPatientPhoto.Effect_1_Transparency = 25;
            btnUploadPatientPhoto.Effect_2 = true;
            btnUploadPatientPhoto.Effect_2_ColorBackground = Color.White;
            btnUploadPatientPhoto.Effect_2_Transparency = 20;
            btnUploadPatientPhoto.Font = new Font("Arial", 11F);
            btnUploadPatientPhoto.ForeColor = Color.FromArgb(245, 245, 245);
            btnUploadPatientPhoto.Lighting = false;
            btnUploadPatientPhoto.LinearGradient_Background = false;
            btnUploadPatientPhoto.LinearGradientPen = false;
            btnUploadPatientPhoto.Location = new Point(22, 141);
            btnUploadPatientPhoto.Name = "btnUploadPatientPhoto";
            btnUploadPatientPhoto.PenWidth = 15;
            btnUploadPatientPhoto.Rounding = true;
            btnUploadPatientPhoto.RoundingInt = 70;
            btnUploadPatientPhoto.Size = new Size(131, 32);
            btnUploadPatientPhoto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUploadPatientPhoto.TabIndex = 4;
            btnUploadPatientPhoto.Tag = "Cyber";
            btnUploadPatientPhoto.TextButton = "Upload Photo";
            btnUploadPatientPhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUploadPatientPhoto.Timer_Effect_1 = 5;
            btnUploadPatientPhoto.Timer_RGB = 300;
            btnUploadPatientPhoto.Click += btnUploadPhoto_Click;
            // 
            // tbxFNameInput
            // 
            tbxFNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxFNameInput.AnimateReadOnly = false;
            tbxFNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxFNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxFNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxFNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxFNameInput.Depth = 0;
            tbxFNameInput.ErrorMessage = "That can't be empty.";
            tbxFNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxFNameInput.HideSelection = true;
            tbxFNameInput.Hint = "First Name";
            tbxFNameInput.LeadingIcon = null;
            tbxFNameInput.LeaveOnEnterKey = true;
            tbxFNameInput.Location = new Point(174, 71);
            tbxFNameInput.MaxLength = 32767;
            tbxFNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxFNameInput.Name = "tbxFNameInput";
            tbxFNameInput.PasswordChar = '\0';
            tbxFNameInput.PrefixSuffixText = null;
            tbxFNameInput.ReadOnly = false;
            tbxFNameInput.RightToLeft = RightToLeft.No;
            tbxFNameInput.SelectedText = "";
            tbxFNameInput.SelectionLength = 0;
            tbxFNameInput.SelectionStart = 0;
            tbxFNameInput.ShortcutsEnabled = true;
            tbxFNameInput.Size = new Size(249, 48);
            tbxFNameInput.TabIndex = 15;
            tbxFNameInput.TabStop = false;
            tbxFNameInput.TextAlign = HorizontalAlignment.Left;
            tbxFNameInput.TrailingIcon = null;
            tbxFNameInput.UseSystemPasswordChar = false;
            tbxFNameInput.Click += materialTextBoxEdit2_Click;
            // 
            // tbxLNameInput
            // 
            tbxLNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxLNameInput.AnimateReadOnly = false;
            tbxLNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxLNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxLNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxLNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxLNameInput.Depth = 0;
            tbxLNameInput.ErrorMessage = "That can't be empty.";
            tbxLNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxLNameInput.HelperText = "Try here";
            tbxLNameInput.HideSelection = true;
            tbxLNameInput.Hint = "Last Name";
            tbxLNameInput.LeadingIcon = null;
            tbxLNameInput.LeaveOnEnterKey = true;
            tbxLNameInput.Location = new Point(174, 17);
            tbxLNameInput.MaxLength = 32767;
            tbxLNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxLNameInput.Name = "tbxLNameInput";
            tbxLNameInput.PasswordChar = '\0';
            tbxLNameInput.PrefixSuffixText = null;
            tbxLNameInput.ReadOnly = false;
            tbxLNameInput.RightToLeft = RightToLeft.No;
            tbxLNameInput.SelectedText = "";
            tbxLNameInput.SelectionLength = 0;
            tbxLNameInput.SelectionStart = 0;
            tbxLNameInput.ShortcutsEnabled = true;
            tbxLNameInput.Size = new Size(249, 48);
            tbxLNameInput.TabIndex = 14;
            tbxLNameInput.TabStop = false;
            tbxLNameInput.TextAlign = HorizontalAlignment.Left;
            tbxLNameInput.TrailingIcon = null;
            tbxLNameInput.UseSystemPasswordChar = false;
            tbxLNameInput.Click += tbxLNameInput_Click;
            // 
            // tbxMNameInput
            // 
            tbxMNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMNameInput.AnimateReadOnly = false;
            tbxMNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxMNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxMNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxMNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxMNameInput.Depth = 0;
            tbxMNameInput.ErrorMessage = "This can't be empty.";
            tbxMNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMNameInput.HideSelection = true;
            tbxMNameInput.Hint = "Middle Name";
            tbxMNameInput.LeadingIcon = null;
            tbxMNameInput.LeaveOnEnterKey = true;
            tbxMNameInput.Location = new Point(173, 125);
            tbxMNameInput.MaxLength = 32767;
            tbxMNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxMNameInput.Name = "tbxMNameInput";
            tbxMNameInput.PasswordChar = '\0';
            tbxMNameInput.PrefixSuffixText = null;
            tbxMNameInput.ReadOnly = false;
            tbxMNameInput.RightToLeft = RightToLeft.No;
            tbxMNameInput.SelectedText = "";
            tbxMNameInput.SelectionLength = 0;
            tbxMNameInput.SelectionStart = 0;
            tbxMNameInput.ShortcutsEnabled = true;
            tbxMNameInput.Size = new Size(250, 48);
            tbxMNameInput.TabIndex = 16;
            tbxMNameInput.TabStop = false;
            tbxMNameInput.TextAlign = HorizontalAlignment.Left;
            tbxMNameInput.TrailingIcon = null;
            tbxMNameInput.UseSystemPasswordChar = false;
            tbxMNameInput.Click += tbxMNameInput_Click;
            // 
            // picBoxPatientInput
            // 
            picBoxPatientInput.Anchor = AnchorStyles.Left;
            picBoxPatientInput.BackColor = Color.White;
            picBoxPatientInput.BorderStyle = BorderStyle.FixedSingle;
            picBoxPatientInput.Image = (Image)resources.GetObject("picBoxPatientInput.Image");
            picBoxPatientInput.Location = new Point(22, 17);
            picBoxPatientInput.Name = "picBoxPatientInput";
            picBoxPatientInput.Size = new Size(137, 119);
            picBoxPatientInput.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPatientInput.TabIndex = 0;
            picBoxPatientInput.TabStop = false;
            picBoxPatientInput.Click += picBoxPatientInput_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(163, 226, 225);
            panel7.Dock = DockStyle.Bottom;
            panel7.Location = new Point(10, 178);
            panel7.Name = "panel7";
            panel7.Size = new Size(441, 11);
            panel7.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(163, 226, 225);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(451, 11);
            panel9.Name = "panel9";
            panel9.Size = new Size(8, 178);
            panel9.TabIndex = 3;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(163, 226, 225);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(10, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(449, 11);
            panel6.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(163, 226, 225);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(10, 189);
            panel8.TabIndex = 2;
            // 
            // tbxPrescriptionInput
            // 
            tbxPrescriptionInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxPrescriptionInput.AnimateReadOnly = false;
            tbxPrescriptionInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxPrescriptionInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxPrescriptionInput.BackgroundImageLayout = ImageLayout.None;
            tbxPrescriptionInput.CharacterCasing = CharacterCasing.Normal;
            tbxPrescriptionInput.Depth = 0;
            tbxPrescriptionInput.ErrorMessage = "This can't be empty.";
            tbxPrescriptionInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPrescriptionInput.HideSelection = true;
            tbxPrescriptionInput.Hint = "Prescription";
            tbxPrescriptionInput.LeadingIcon = null;
            tbxPrescriptionInput.LeaveOnEnterKey = true;
            tbxPrescriptionInput.Location = new Point(16, 465);
            tbxPrescriptionInput.MaxLength = 32767;
            tbxPrescriptionInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxPrescriptionInput.Name = "tbxPrescriptionInput";
            tbxPrescriptionInput.PasswordChar = '\0';
            tbxPrescriptionInput.PrefixSuffixText = null;
            tbxPrescriptionInput.ReadOnly = false;
            tbxPrescriptionInput.RightToLeft = RightToLeft.No;
            tbxPrescriptionInput.SelectedText = "";
            tbxPrescriptionInput.SelectionLength = 0;
            tbxPrescriptionInput.SelectionStart = 0;
            tbxPrescriptionInput.ShortcutsEnabled = true;
            tbxPrescriptionInput.Size = new Size(421, 48);
            tbxPrescriptionInput.TabIndex = 27;
            tbxPrescriptionInput.TabStop = false;
            tbxPrescriptionInput.TextAlign = HorizontalAlignment.Left;
            tbxPrescriptionInput.TrailingIcon = null;
            tbxPrescriptionInput.UseSystemPasswordChar = false;
            tbxPrescriptionInput.Click += tbxPrescriptionInput_Click;
            // 
            // tbxMedicalHistoryInput
            // 
            tbxMedicalHistoryInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMedicalHistoryInput.AnimateReadOnly = false;
            tbxMedicalHistoryInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxMedicalHistoryInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxMedicalHistoryInput.BackgroundImageLayout = ImageLayout.None;
            tbxMedicalHistoryInput.CharacterCasing = CharacterCasing.Normal;
            tbxMedicalHistoryInput.Depth = 0;
            tbxMedicalHistoryInput.ErrorMessage = "This can't be empty.";
            tbxMedicalHistoryInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxMedicalHistoryInput.HideSelection = true;
            tbxMedicalHistoryInput.Hint = "Medical History";
            tbxMedicalHistoryInput.LeadingIcon = null;
            tbxMedicalHistoryInput.LeaveOnEnterKey = true;
            tbxMedicalHistoryInput.Location = new Point(16, 413);
            tbxMedicalHistoryInput.MaxLength = 32767;
            tbxMedicalHistoryInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxMedicalHistoryInput.Name = "tbxMedicalHistoryInput";
            tbxMedicalHistoryInput.PasswordChar = '\0';
            tbxMedicalHistoryInput.PrefixSuffixText = null;
            tbxMedicalHistoryInput.ReadOnly = false;
            tbxMedicalHistoryInput.RightToLeft = RightToLeft.No;
            tbxMedicalHistoryInput.SelectedText = "";
            tbxMedicalHistoryInput.SelectionLength = 0;
            tbxMedicalHistoryInput.SelectionStart = 0;
            tbxMedicalHistoryInput.ShortcutsEnabled = true;
            tbxMedicalHistoryInput.Size = new Size(421, 48);
            tbxMedicalHistoryInput.TabIndex = 17;
            tbxMedicalHistoryInput.TabStop = false;
            tbxMedicalHistoryInput.TextAlign = HorizontalAlignment.Left;
            tbxMedicalHistoryInput.TrailingIcon = null;
            tbxMedicalHistoryInput.UseSystemPasswordChar = false;
            tbxMedicalHistoryInput.Click += tbxMedicalHistoryInput_Click;
            // 
            // gbxSerNumInput
            // 
            gbxSerNumInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxSerNumInput.Controls.Add(label2);
            gbxSerNumInput.Controls.Add(tbxEmailInput);
            gbxSerNumInput.ForeColor = Color.Black;
            gbxSerNumInput.Location = new Point(167, 342);
            gbxSerNumInput.Name = "gbxSerNumInput";
            gbxSerNumInput.Size = new Size(270, 69);
            gbxSerNumInput.TabIndex = 9;
            gbxSerNumInput.TabStop = false;
            gbxSerNumInput.Enter += gbxSerNumInput_Enter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(6, 8);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            label2.Click += label2_Click;
            // 
            // tbxEmailInput
            // 
            tbxEmailInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxEmailInput.BackColor = Color.FromArgb(235, 235, 235);
            tbxEmailInput.Location = new Point(5, 27);
            tbxEmailInput.Multiline = true;
            tbxEmailInput.Name = "tbxEmailInput";
            tbxEmailInput.Size = new Size(259, 37);
            tbxEmailInput.TabIndex = 0;
            tbxEmailInput.TextChanged += tbxEmailInput_TextChanged;
            // 
            // gbxBirthInput
            // 
            gbxBirthInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxBirthInput.Controls.Add(label1);
            gbxBirthInput.Controls.Add(tbxBirthInput);
            gbxBirthInput.ForeColor = Color.Black;
            gbxBirthInput.Location = new Point(167, 195);
            gbxBirthInput.Name = "gbxBirthInput";
            gbxBirthInput.Size = new Size(270, 69);
            gbxBirthInput.TabIndex = 9;
            gbxBirthInput.TabStop = false;
            gbxBirthInput.Enter += gbxBirthInput_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 7F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 1;
            label1.Text = "Birth Date (DD/MM/YYY)";
            label1.Click += label1_Click;
            // 
            // tbxBirthInput
            // 
            tbxBirthInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxBirthInput.BackColor = Color.FromArgb(235, 235, 235);
            tbxBirthInput.Location = new Point(5, 27);
            tbxBirthInput.Multiline = true;
            tbxBirthInput.Name = "tbxBirthInput";
            tbxBirthInput.Size = new Size(259, 37);
            tbxBirthInput.TabIndex = 0;
            tbxBirthInput.TextChanged += tbxBirthInput_TextChanged;
            // 
            // tbxAgeInput
            // 
            tbxAgeInput.Anchor = AnchorStyles.Left;
            tbxAgeInput.AnimateReadOnly = false;
            tbxAgeInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxAgeInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxAgeInput.BackgroundImageLayout = ImageLayout.None;
            tbxAgeInput.CharacterCasing = CharacterCasing.Normal;
            tbxAgeInput.Depth = 0;
            tbxAgeInput.ErrorMessage = "That can't be empty.";
            tbxAgeInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxAgeInput.HelperText = "Try here";
            tbxAgeInput.HideSelection = true;
            tbxAgeInput.Hint = "Age";
            tbxAgeInput.LeadingIcon = null;
            tbxAgeInput.LeaveOnEnterKey = true;
            tbxAgeInput.Location = new Point(16, 304);
            tbxAgeInput.MaxLength = 32767;
            tbxAgeInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxAgeInput.Name = "tbxAgeInput";
            tbxAgeInput.PasswordChar = '\0';
            tbxAgeInput.PrefixSuffixText = null;
            tbxAgeInput.ReadOnly = false;
            tbxAgeInput.RightToLeft = RightToLeft.No;
            tbxAgeInput.SelectedText = "";
            tbxAgeInput.SelectionLength = 0;
            tbxAgeInput.SelectionStart = 0;
            tbxAgeInput.ShortcutsEnabled = true;
            tbxAgeInput.Size = new Size(148, 48);
            tbxAgeInput.TabIndex = 18;
            tbxAgeInput.TabStop = false;
            tbxAgeInput.TextAlign = HorizontalAlignment.Left;
            tbxAgeInput.TrailingIcon = null;
            tbxAgeInput.UseSystemPasswordChar = false;
            tbxAgeInput.Click += tbxAgeInput_Click;
            // 
            // tbxPurokNumInput
            // 
            tbxPurokNumInput.Anchor = AnchorStyles.Left;
            tbxPurokNumInput.AnimateReadOnly = false;
            tbxPurokNumInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxPurokNumInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxPurokNumInput.BackgroundImageLayout = ImageLayout.None;
            tbxPurokNumInput.CharacterCasing = CharacterCasing.Normal;
            tbxPurokNumInput.Depth = 0;
            tbxPurokNumInput.ErrorMessage = "That can't be empty.";
            tbxPurokNumInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPurokNumInput.HelperText = "Try here";
            tbxPurokNumInput.HideSelection = true;
            tbxPurokNumInput.Hint = "Purok No.";
            tbxPurokNumInput.LeadingIcon = null;
            tbxPurokNumInput.LeaveOnEnterKey = true;
            tbxPurokNumInput.Location = new Point(18, 198);
            tbxPurokNumInput.MaxLength = 32767;
            tbxPurokNumInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxPurokNumInput.Name = "tbxPurokNumInput";
            tbxPurokNumInput.PasswordChar = '\0';
            tbxPurokNumInput.PrefixSuffixText = null;
            tbxPurokNumInput.ReadOnly = false;
            tbxPurokNumInput.RightToLeft = RightToLeft.No;
            tbxPurokNumInput.SelectedText = "";
            tbxPurokNumInput.SelectionLength = 0;
            tbxPurokNumInput.SelectionStart = 0;
            tbxPurokNumInput.ShortcutsEnabled = true;
            tbxPurokNumInput.Size = new Size(148, 48);
            tbxPurokNumInput.TabIndex = 20;
            tbxPurokNumInput.TabStop = false;
            tbxPurokNumInput.TextAlign = HorizontalAlignment.Left;
            tbxPurokNumInput.TrailingIcon = null;
            tbxPurokNumInput.UseSystemPasswordChar = false;
            tbxPurokNumInput.Click += tbxPurokNumInput_Click;
            // 
            // gbxContactInput
            // 
            gbxContactInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxContactInput.Controls.Add(label5);
            gbxContactInput.Controls.Add(tbxContactInput);
            gbxContactInput.ForeColor = Color.Black;
            gbxContactInput.Location = new Point(167, 267);
            gbxContactInput.Name = "gbxContactInput";
            gbxContactInput.Size = new Size(270, 69);
            gbxContactInput.TabIndex = 8;
            gbxContactInput.TabStop = false;
            gbxContactInput.Enter += gbxContactInput_Enter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 7F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(5, 8);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 1;
            label5.Text = "Contact No.";
            label5.Click += label5_Click;
            // 
            // tbxContactInput
            // 
            tbxContactInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxContactInput.BackColor = Color.FromArgb(235, 235, 235);
            tbxContactInput.Location = new Point(5, 27);
            tbxContactInput.Multiline = true;
            tbxContactInput.Name = "tbxContactInput";
            tbxContactInput.Size = new Size(259, 37);
            tbxContactInput.TabIndex = 0;
            tbxContactInput.TextChanged += tbxContactInput_TextChanged;
            // 
            // tbxSexInput
            // 
            tbxSexInput.Anchor = AnchorStyles.Left;
            tbxSexInput.AnimateReadOnly = false;
            tbxSexInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxSexInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxSexInput.BackgroundImageLayout = ImageLayout.None;
            tbxSexInput.CharacterCasing = CharacterCasing.Normal;
            tbxSexInput.Depth = 0;
            tbxSexInput.ErrorMessage = "That can't be empty.";
            tbxSexInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSexInput.HelperText = "Try here";
            tbxSexInput.HideSelection = true;
            tbxSexInput.Hint = "Sex";
            tbxSexInput.LeadingIcon = null;
            tbxSexInput.LeaveOnEnterKey = true;
            tbxSexInput.Location = new Point(16, 358);
            tbxSexInput.MaxLength = 32767;
            tbxSexInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxSexInput.Name = "tbxSexInput";
            tbxSexInput.PasswordChar = '\0';
            tbxSexInput.PrefixSuffixText = null;
            tbxSexInput.ReadOnly = false;
            tbxSexInput.RightToLeft = RightToLeft.No;
            tbxSexInput.SelectedText = "";
            tbxSexInput.SelectionLength = 0;
            tbxSexInput.SelectionStart = 0;
            tbxSexInput.ShortcutsEnabled = true;
            tbxSexInput.Size = new Size(148, 48);
            tbxSexInput.TabIndex = 19;
            tbxSexInput.TabStop = false;
            tbxSexInput.TextAlign = HorizontalAlignment.Left;
            tbxSexInput.TrailingIcon = null;
            tbxSexInput.UseSystemPasswordChar = false;
            tbxSexInput.Click += tbxSexInput_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(163, 226, 225);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 578);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 11);
            panel4.TabIndex = 23;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(163, 226, 225);
            panel10.Controls.Add(dgvPatientsRecords);
            panel10.Controls.Add(cyberTextBox2);
            panel10.Controls.Add(cyberTextBox1);
            panel10.Controls.Add(flowPatientPanel);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(459, 52);
            panel10.Name = "panel10";
            panel10.Size = new Size(432, 589);
            panel10.TabIndex = 29;
            panel10.Paint += panel10_Paint;
            // 
            // dgvPatientsRecords
            // 
            dgvPatientsRecords.Anchor = AnchorStyles.Top;
            dgvPatientsRecords.BackgroundColor = Color.White;
            dgvPatientsRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatientsRecords.Location = new Point(9, 56);
            dgvPatientsRecords.Name = "dgvPatientsRecords";
            dgvPatientsRecords.ReadOnly = true;
            dgvPatientsRecords.RowHeadersWidth = 51;
            dgvPatientsRecords.Size = new Size(409, 190);
            dgvPatientsRecords.TabIndex = 2;
            dgvPatientsRecords.CellContentClick += dgvPatientsRecords_CellContentClick;
            // 
            // cyberTextBox2
            // 
            cyberTextBox2.Alpha = 20;
            cyberTextBox2.Anchor = AnchorStyles.Top;
            cyberTextBox2.AutoSize = true;
            cyberTextBox2.BackColor = Color.Transparent;
            cyberTextBox2.Background_WidthPen = 5F;
            cyberTextBox2.BackgroundPen = true;
            cyberTextBox2.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox2.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            cyberTextBox2.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox2.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox2.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox2.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox2.Font = new Font("Arial", 10F);
            cyberTextBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox2.Lighting = false;
            cyberTextBox2.LinearGradientPen = false;
            cyberTextBox2.Location = new Point(6, 250);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = true;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 60;
            cyberTextBox2.Size = new Size(413, 42);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 40;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "R E C E N T L Y   A D D E D";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.Anchor = AnchorStyles.Top;
            cyberTextBox1.AutoSize = true;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 5F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox1.ColorBackground_Pen = Color.Cyan;
            cyberTextBox1.ColorLighting = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(29, 200, 238);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(37, 52, 68);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Font = new Font("Arial", 10F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(6, 6);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = true;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(413, 42);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 39;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "D A T A B A S E";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // flowPatientPanel
            // 
            flowPatientPanel.Anchor = AnchorStyles.Top;
            flowPatientPanel.AutoScroll = true;
            flowPatientPanel.BackColor = Color.FromArgb(117, 214, 227);
            flowPatientPanel.FlowDirection = FlowDirection.BottomUp;
            flowPatientPanel.Location = new Point(9, 302);
            flowPatientPanel.Name = "flowPatientPanel";
            flowPatientPanel.Size = new Size(409, 270);
            flowPatientPanel.TabIndex = 28;
            flowPatientPanel.Click += flowPatientPanel_Click;
            flowPatientPanel.Paint += flowPatientPanel_Paint;
            // 
            // pnlNewPatientHeader
            // 
            pnlNewPatientHeader.BackColor = Color.FromArgb(85, 205, 229);
            pnlNewPatientHeader.Controls.Add(bigLabel1);
            pnlNewPatientHeader.Controls.Add(iconButton2);
            pnlNewPatientHeader.Dock = DockStyle.Top;
            pnlNewPatientHeader.Location = new Point(0, 0);
            pnlNewPatientHeader.Name = "pnlNewPatientHeader";
            pnlNewPatientHeader.Size = new Size(891, 52);
            pnlNewPatientHeader.TabIndex = 21;
            pnlNewPatientHeader.Paint += panel2_Paint;
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
            bigLabel1.Size = new Size(260, 47);
            bigLabel1.TabIndex = 8;
            bigLabel1.Text = "New Patient";
            // 
            // iconButton2
            // 
            iconButton2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(811, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(69, 45);
            iconButton2.TabIndex = 24;
            iconButton2.Tag = "Home";
            iconButton2.TextAlign = ContentAlignment.TopCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // NewPatientControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 242, 253);
            Controls.Add(panel1);
            Name = "NewPatientControl";
            Size = new Size(891, 641);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxPatientInput).EndInit();
            gbxSerNumInput.ResumeLayout(false);
            gbxSerNumInput.PerformLayout();
            gbxBirthInput.ResumeLayout(false);
            gbxBirthInput.PerformLayout();
            gbxContactInput.ResumeLayout(false);
            gbxContactInput.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatientsRecords).EndInit();
            pnlNewPatientHeader.ResumeLayout(false);
            pnlNewPatientHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private DataGridView dgvPatientsRecords;
        private PictureBox picBoxPatientInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxFNameInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxLNameInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxMNameInput;
        private Panel panel3;
        private Panel pnlNewPatientHeader;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private ReaLTaiizor.Controls.CyberButton btnUploadPatientPhoto;
        private Panel panel11;
        private Panel panel12;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxPrescriptionInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxMedicalHistoryInput;
        private GroupBox gbxSerNumInput;
        private Label label2;
        private TextBox tbxEmailInput;
        private GroupBox gbxBirthInput;
        private Label label1;
        private TextBox tbxBirthInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxAgeInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxPurokNumInput;
        private GroupBox gbxContactInput;
        private Label label5;
        private TextBox tbxContactInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxSexInput;
        private FlowLayoutPanel flowPatientPanel;
        private Panel panel10;
        private Panel panel9;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxDateAddedInput;
        private ReaLTaiizor.Controls.ParrotButton btnAddPatient;
    }
}
