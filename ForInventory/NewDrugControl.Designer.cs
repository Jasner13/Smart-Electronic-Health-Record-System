namespace SEHRS
{
    partial class NewDrugControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewDrugControl));
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            dgvDrugRecords = new DataGridView();
            panel3 = new Panel();
            gbxDateAddedInput = new GroupBox();
            label1 = new Label();
            tbxDateAddedInput = new TextBox();
            panel10 = new Panel();
            btnUploadDrugPhoto = new ReaLTaiizor.Controls.CyberButton();
            tbxGenNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxDrugNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            tbxBrandNameInput = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            picBoxDrugInput = new PictureBox();
            panel13 = new Panel();
            panel15 = new Panel();
            panel11 = new Panel();
            panel12 = new Panel();
            gbxExpiryInput = new GroupBox();
            tbxExpiryInput = new TextBox();
            btnAddDrug = new ReaLTaiizor.Controls.ParrotButton();
            gbxManuDateInput = new GroupBox();
            tbxManuDateInput = new TextBox();
            gbxQuantityInput = new GroupBox();
            tbxQuantityInput = new TextBox();
            gbxMeasurementInput = new GroupBox();
            tbxMeasurementInput = new TextBox();
            gbxStrengthInput = new GroupBox();
            tbxStrengthInput = new TextBox();
            gbxCategoryInput = new GroupBox();
            tbxCategoryInput = new TextBox();
            materialTextBoxEdit8 = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel4 = new Panel();
            textBox1 = new TextBox();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            dateTimePicker1 = new DateTimePicker();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            comboBox11 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            flowNewDrugPanel = new FlowLayoutPanel();
            panel6 = new Panel();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrugRecords).BeginInit();
            panel3.SuspendLayout();
            gbxDateAddedInput.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxDrugInput).BeginInit();
            gbxExpiryInput.SuspendLayout();
            gbxManuDateInput.SuspendLayout();
            gbxQuantityInput.SuspendLayout();
            gbxMeasurementInput.SuspendLayout();
            gbxStrengthInput.SuspendLayout();
            gbxCategoryInput.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(184, 94, 108);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(bigLabel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 52);
            panel1.TabIndex = 0;
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
            iconButton2.Location = new Point(807, 1);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(68, 46);
            iconButton2.TabIndex = 27;
            iconButton2.Tag = "Home";
            iconButton2.TextAlign = ContentAlignment.TopCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = true;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Tahoma", 22.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(3, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(216, 47);
            bigLabel1.TabIndex = 9;
            bigLabel1.Text = "New Drug";
            // 
            // dgvDrugRecords
            // 
            dgvDrugRecords.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dgvDrugRecords.BackgroundColor = Color.WhiteSmoke;
            dgvDrugRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDrugRecords.Location = new Point(10, 54);
            dgvDrugRecords.Name = "dgvDrugRecords";
            dgvDrugRecords.RowHeadersWidth = 51;
            dgvDrugRecords.Size = new Size(413, 190);
            dgvDrugRecords.TabIndex = 1;
            dgvDrugRecords.CellContentClick += dgvDrugRecords_CellContentClick;
            dgvDrugRecords.Click += dgvDrugRecords_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(gbxDateAddedInput);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel11);
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(gbxExpiryInput);
            panel3.Controls.Add(btnAddDrug);
            panel3.Controls.Add(gbxManuDateInput);
            panel3.Controls.Add(gbxQuantityInput);
            panel3.Controls.Add(gbxMeasurementInput);
            panel3.Controls.Add(gbxStrengthInput);
            panel3.Controls.Add(gbxCategoryInput);
            panel3.Controls.Add(materialTextBoxEdit8);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 52);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 589);
            panel3.TabIndex = 23;
            panel3.Paint += panel3_Paint;
            // 
            // gbxDateAddedInput
            // 
            gbxDateAddedInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxDateAddedInput.Controls.Add(label1);
            gbxDateAddedInput.Controls.Add(tbxDateAddedInput);
            gbxDateAddedInput.Font = new Font("Verdana", 9F);
            gbxDateAddedInput.Location = new Point(16, 199);
            gbxDateAddedInput.Name = "gbxDateAddedInput";
            gbxDateAddedInput.Size = new Size(423, 65);
            gbxDateAddedInput.TabIndex = 63;
            gbxDateAddedInput.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(168, 4);
            label1.Name = "label1";
            label1.Size = new Size(94, 18);
            label1.TabIndex = 44;
            label1.Text = "Date Added";
            // 
            // tbxDateAddedInput
            // 
            tbxDateAddedInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxDateAddedInput.BackColor = SystemColors.ControlLight;
            tbxDateAddedInput.BorderStyle = BorderStyle.None;
            tbxDateAddedInput.Location = new Point(5, 25);
            tbxDateAddedInput.Multiline = true;
            tbxDateAddedInput.Name = "tbxDateAddedInput";
            tbxDateAddedInput.Size = new Size(414, 34);
            tbxDateAddedInput.TabIndex = 43;
            tbxDateAddedInput.TextChanged += tbxDateAddedInput_TextChanged;
            // 
            // panel10
            // 
            panel10.BackColor = Color.WhiteSmoke;
            panel10.Controls.Add(btnUploadDrugPhoto);
            panel10.Controls.Add(tbxGenNameInput);
            panel10.Controls.Add(tbxDrugNameInput);
            panel10.Controls.Add(tbxBrandNameInput);
            panel10.Controls.Add(picBoxDrugInput);
            panel10.Controls.Add(panel13);
            panel10.Controls.Add(panel15);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(10, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(439, 193);
            panel10.TabIndex = 25;
            panel10.Paint += panel10_Paint;
            // 
            // btnUploadDrugPhoto
            // 
            btnUploadDrugPhoto.Alpha = 20;
            btnUploadDrugPhoto.Anchor = AnchorStyles.Left;
            btnUploadDrugPhoto.BackColor = Color.Transparent;
            btnUploadDrugPhoto.Background = true;
            btnUploadDrugPhoto.Background_WidthPen = 4F;
            btnUploadDrugPhoto.BackgroundPen = true;
            btnUploadDrugPhoto.ColorBackground = Color.FromArgb(37, 52, 68);
            btnUploadDrugPhoto.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnUploadDrugPhoto.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnUploadDrugPhoto.ColorBackground_Pen = Color.LightCoral;
            btnUploadDrugPhoto.ColorLighting = Color.LightCoral;
            btnUploadDrugPhoto.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnUploadDrugPhoto.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnUploadDrugPhoto.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnUploadDrugPhoto.Effect_1 = true;
            btnUploadDrugPhoto.Effect_1_ColorBackground = Color.LightCoral;
            btnUploadDrugPhoto.Effect_1_Transparency = 25;
            btnUploadDrugPhoto.Effect_2 = true;
            btnUploadDrugPhoto.Effect_2_ColorBackground = Color.White;
            btnUploadDrugPhoto.Effect_2_Transparency = 20;
            btnUploadDrugPhoto.Font = new Font("Arial", 11F);
            btnUploadDrugPhoto.ForeColor = Color.FromArgb(245, 245, 245);
            btnUploadDrugPhoto.Lighting = false;
            btnUploadDrugPhoto.LinearGradient_Background = false;
            btnUploadDrugPhoto.LinearGradientPen = false;
            btnUploadDrugPhoto.Location = new Point(26, 145);
            btnUploadDrugPhoto.Name = "btnUploadDrugPhoto";
            btnUploadDrugPhoto.PenWidth = 15;
            btnUploadDrugPhoto.Rounding = true;
            btnUploadDrugPhoto.RoundingInt = 70;
            btnUploadDrugPhoto.Size = new Size(131, 32);
            btnUploadDrugPhoto.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnUploadDrugPhoto.TabIndex = 4;
            btnUploadDrugPhoto.Tag = "Cyber";
            btnUploadDrugPhoto.TextButton = "Upload Photo";
            btnUploadDrugPhoto.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnUploadDrugPhoto.Timer_Effect_1 = 5;
            btnUploadDrugPhoto.Timer_RGB = 300;
            btnUploadDrugPhoto.Click += btnUploadDrugPhoto_Click;
            // 
            // tbxGenNameInput
            // 
            tbxGenNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxGenNameInput.AnimateReadOnly = false;
            tbxGenNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxGenNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxGenNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxGenNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxGenNameInput.Depth = 0;
            tbxGenNameInput.ErrorMessage = "That can't be empty.";
            tbxGenNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxGenNameInput.HideSelection = true;
            tbxGenNameInput.Hint = "Generic Name";
            tbxGenNameInput.LeadingIcon = null;
            tbxGenNameInput.LeaveOnEnterKey = true;
            tbxGenNameInput.Location = new Point(184, 72);
            tbxGenNameInput.MaxLength = 32767;
            tbxGenNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxGenNameInput.Name = "tbxGenNameInput";
            tbxGenNameInput.PasswordChar = '\0';
            tbxGenNameInput.PrefixSuffixText = null;
            tbxGenNameInput.ReadOnly = false;
            tbxGenNameInput.RightToLeft = RightToLeft.No;
            tbxGenNameInput.SelectedText = "";
            tbxGenNameInput.SelectionLength = 0;
            tbxGenNameInput.SelectionStart = 0;
            tbxGenNameInput.ShortcutsEnabled = true;
            tbxGenNameInput.Size = new Size(229, 48);
            tbxGenNameInput.TabIndex = 15;
            tbxGenNameInput.TabStop = false;
            tbxGenNameInput.TextAlign = HorizontalAlignment.Left;
            tbxGenNameInput.TrailingIcon = null;
            tbxGenNameInput.UseSystemPasswordChar = false;
            tbxGenNameInput.Click += tbxGenNameInput_Click;
            // 
            // tbxDrugNameInput
            // 
            tbxDrugNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxDrugNameInput.AnimateReadOnly = false;
            tbxDrugNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxDrugNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxDrugNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxDrugNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxDrugNameInput.Depth = 0;
            tbxDrugNameInput.ErrorMessage = "That can't be empty.";
            tbxDrugNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxDrugNameInput.HelperText = "Try here";
            tbxDrugNameInput.HideSelection = true;
            tbxDrugNameInput.Hint = "Drug Name";
            tbxDrugNameInput.LeadingIcon = null;
            tbxDrugNameInput.LeaveOnEnterKey = true;
            tbxDrugNameInput.Location = new Point(184, 18);
            tbxDrugNameInput.MaxLength = 32767;
            tbxDrugNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxDrugNameInput.Name = "tbxDrugNameInput";
            tbxDrugNameInput.PasswordChar = '\0';
            tbxDrugNameInput.PrefixSuffixText = null;
            tbxDrugNameInput.ReadOnly = false;
            tbxDrugNameInput.RightToLeft = RightToLeft.No;
            tbxDrugNameInput.SelectedText = "";
            tbxDrugNameInput.SelectionLength = 0;
            tbxDrugNameInput.SelectionStart = 0;
            tbxDrugNameInput.ShortcutsEnabled = true;
            tbxDrugNameInput.Size = new Size(229, 48);
            tbxDrugNameInput.TabIndex = 14;
            tbxDrugNameInput.TabStop = false;
            tbxDrugNameInput.TextAlign = HorizontalAlignment.Left;
            tbxDrugNameInput.TrailingIcon = null;
            tbxDrugNameInput.UseSystemPasswordChar = false;
            tbxDrugNameInput.Click += tbxDrugNameInput_Click;
            // 
            // tbxBrandNameInput
            // 
            tbxBrandNameInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxBrandNameInput.AnimateReadOnly = false;
            tbxBrandNameInput.AutoCompleteMode = AutoCompleteMode.None;
            tbxBrandNameInput.AutoCompleteSource = AutoCompleteSource.None;
            tbxBrandNameInput.BackgroundImageLayout = ImageLayout.None;
            tbxBrandNameInput.CharacterCasing = CharacterCasing.Normal;
            tbxBrandNameInput.Depth = 0;
            tbxBrandNameInput.ErrorMessage = "This can't be empty.";
            tbxBrandNameInput.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxBrandNameInput.HideSelection = true;
            tbxBrandNameInput.Hint = "Brand Name";
            tbxBrandNameInput.LeadingIcon = null;
            tbxBrandNameInput.LeaveOnEnterKey = true;
            tbxBrandNameInput.Location = new Point(183, 126);
            tbxBrandNameInput.MaxLength = 32767;
            tbxBrandNameInput.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            tbxBrandNameInput.Name = "tbxBrandNameInput";
            tbxBrandNameInput.PasswordChar = '\0';
            tbxBrandNameInput.PrefixSuffixText = null;
            tbxBrandNameInput.ReadOnly = false;
            tbxBrandNameInput.RightToLeft = RightToLeft.No;
            tbxBrandNameInput.SelectedText = "";
            tbxBrandNameInput.SelectionLength = 0;
            tbxBrandNameInput.SelectionStart = 0;
            tbxBrandNameInput.ShortcutsEnabled = true;
            tbxBrandNameInput.Size = new Size(230, 48);
            tbxBrandNameInput.TabIndex = 16;
            tbxBrandNameInput.TabStop = false;
            tbxBrandNameInput.TextAlign = HorizontalAlignment.Left;
            tbxBrandNameInput.TrailingIcon = null;
            tbxBrandNameInput.UseSystemPasswordChar = false;
            tbxBrandNameInput.Click += tbxBrandNameInput_Click;
            // 
            // picBoxDrugInput
            // 
            picBoxDrugInput.Anchor = AnchorStyles.Left;
            picBoxDrugInput.BackColor = Color.White;
            picBoxDrugInput.BorderStyle = BorderStyle.FixedSingle;
            picBoxDrugInput.Image = (Image)resources.GetObject("picBoxDrugInput.Image");
            picBoxDrugInput.Location = new Point(26, 17);
            picBoxDrugInput.Name = "picBoxDrugInput";
            picBoxDrugInput.Size = new Size(137, 119);
            picBoxDrugInput.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxDrugInput.TabIndex = 0;
            picBoxDrugInput.TabStop = false;
            picBoxDrugInput.Click += picBoxDrugInput_Click;
            // 
            // panel13
            // 
            panel13.BackColor = Color.FromArgb(213, 163, 170);
            panel13.Dock = DockStyle.Bottom;
            panel13.Location = new Point(0, 183);
            panel13.Name = "panel13";
            panel13.Size = new Size(439, 10);
            panel13.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.BackColor = Color.FromArgb(213, 163, 170);
            panel15.Dock = DockStyle.Top;
            panel15.Location = new Point(0, 0);
            panel15.Name = "panel15";
            panel15.Size = new Size(439, 10);
            panel15.TabIndex = 0;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(213, 163, 170);
            panel11.Dock = DockStyle.Left;
            panel11.Location = new Point(0, 0);
            panel11.Name = "panel11";
            panel11.Size = new Size(10, 579);
            panel11.TabIndex = 25;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(213, 163, 170);
            panel12.Dock = DockStyle.Right;
            panel12.Location = new Point(449, 0);
            panel12.Name = "panel12";
            panel12.Size = new Size(10, 579);
            panel12.TabIndex = 26;
            // 
            // gbxExpiryInput
            // 
            gbxExpiryInput.Anchor = AnchorStyles.Left;
            gbxExpiryInput.Controls.Add(tbxExpiryInput);
            gbxExpiryInput.Font = new Font("Verdana", 9F);
            gbxExpiryInput.Location = new Point(16, 280);
            gbxExpiryInput.Name = "gbxExpiryInput";
            gbxExpiryInput.Size = new Size(207, 53);
            gbxExpiryInput.TabIndex = 58;
            gbxExpiryInput.TabStop = false;
            gbxExpiryInput.Text = "Expiry Date";
            // 
            // tbxExpiryInput
            // 
            tbxExpiryInput.Anchor = AnchorStyles.Left;
            tbxExpiryInput.BackColor = SystemColors.ControlLight;
            tbxExpiryInput.BorderStyle = BorderStyle.None;
            tbxExpiryInput.Location = new Point(5, 19);
            tbxExpiryInput.Multiline = true;
            tbxExpiryInput.Name = "tbxExpiryInput";
            tbxExpiryInput.Size = new Size(197, 34);
            tbxExpiryInput.TabIndex = 43;
            tbxExpiryInput.TextChanged += tbxExpiryInput_TextChanged;
            // 
            // btnAddDrug
            // 
            btnAddDrug.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddDrug.BackgroundColor = Color.FromArgb(255, 234, 234);
            btnAddDrug.ButtonImage = (Image)resources.GetObject("btnAddDrug.ButtonImage");
            btnAddDrug.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnAddDrug.ButtonText = "Add Drug";
            btnAddDrug.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnAddDrug.ClickTextColor = Color.DodgerBlue;
            btnAddDrug.CornerRadius = 5;
            btnAddDrug.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDrug.Horizontal_Alignment = StringAlignment.Center;
            btnAddDrug.HoverBackgroundColor = Color.FromArgb(225, 225, 225);
            btnAddDrug.HoverTextColor = Color.DodgerBlue;
            btnAddDrug.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnAddDrug.Location = new Point(315, 530);
            btnAddDrug.Name = "btnAddDrug";
            btnAddDrug.Size = new Size(124, 39);
            btnAddDrug.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAddDrug.TabIndex = 62;
            btnAddDrug.TextColor = Color.FromArgb(184, 94, 108);
            btnAddDrug.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAddDrug.Vertical_Alignment = StringAlignment.Center;
            btnAddDrug.Click += btnAddDrug_Click;
            // 
            // gbxManuDateInput
            // 
            gbxManuDateInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxManuDateInput.Controls.Add(tbxManuDateInput);
            gbxManuDateInput.Font = new Font("Verdana", 9F);
            gbxManuDateInput.Location = new Point(229, 280);
            gbxManuDateInput.Name = "gbxManuDateInput";
            gbxManuDateInput.Size = new Size(207, 53);
            gbxManuDateInput.TabIndex = 61;
            gbxManuDateInput.TabStop = false;
            gbxManuDateInput.Text = "Manufacturing Date";
            // 
            // tbxManuDateInput
            // 
            tbxManuDateInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxManuDateInput.BackColor = SystemColors.ControlLight;
            tbxManuDateInput.BorderStyle = BorderStyle.None;
            tbxManuDateInput.Location = new Point(10, 19);
            tbxManuDateInput.Multiline = true;
            tbxManuDateInput.Name = "tbxManuDateInput";
            tbxManuDateInput.Size = new Size(191, 34);
            tbxManuDateInput.TabIndex = 43;
            tbxManuDateInput.TextChanged += tbxManuDateInput_TextChanged;
            // 
            // gbxQuantityInput
            // 
            gbxQuantityInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxQuantityInput.Controls.Add(tbxQuantityInput);
            gbxQuantityInput.Font = new Font("Verdana", 9F);
            gbxQuantityInput.Location = new Point(229, 436);
            gbxQuantityInput.Name = "gbxQuantityInput";
            gbxQuantityInput.Size = new Size(207, 53);
            gbxQuantityInput.TabIndex = 59;
            gbxQuantityInput.TabStop = false;
            gbxQuantityInput.Text = "Quantity";
            // 
            // tbxQuantityInput
            // 
            tbxQuantityInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxQuantityInput.BackColor = SystemColors.ControlLight;
            tbxQuantityInput.BorderStyle = BorderStyle.None;
            tbxQuantityInput.Location = new Point(10, 19);
            tbxQuantityInput.Multiline = true;
            tbxQuantityInput.Name = "tbxQuantityInput";
            tbxQuantityInput.Size = new Size(193, 34);
            tbxQuantityInput.TabIndex = 43;
            tbxQuantityInput.TextChanged += tbxQuantityInput_TextChanged;
            // 
            // gbxMeasurementInput
            // 
            gbxMeasurementInput.Anchor = AnchorStyles.Left;
            gbxMeasurementInput.Controls.Add(tbxMeasurementInput);
            gbxMeasurementInput.Font = new Font("Verdana", 9F);
            gbxMeasurementInput.Location = new Point(16, 436);
            gbxMeasurementInput.Name = "gbxMeasurementInput";
            gbxMeasurementInput.Size = new Size(207, 53);
            gbxMeasurementInput.TabIndex = 60;
            gbxMeasurementInput.TabStop = false;
            gbxMeasurementInput.Text = "Measurement Type";
            // 
            // tbxMeasurementInput
            // 
            tbxMeasurementInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxMeasurementInput.BackColor = SystemColors.ControlLight;
            tbxMeasurementInput.BorderStyle = BorderStyle.None;
            tbxMeasurementInput.Location = new Point(10, 19);
            tbxMeasurementInput.Multiline = true;
            tbxMeasurementInput.Name = "tbxMeasurementInput";
            tbxMeasurementInput.Size = new Size(192, 34);
            tbxMeasurementInput.TabIndex = 43;
            tbxMeasurementInput.TextChanged += tbxMeasurementInput_TextChanged;
            // 
            // gbxStrengthInput
            // 
            gbxStrengthInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            gbxStrengthInput.Controls.Add(tbxStrengthInput);
            gbxStrengthInput.Font = new Font("Verdana", 9F);
            gbxStrengthInput.Location = new Point(229, 358);
            gbxStrengthInput.Name = "gbxStrengthInput";
            gbxStrengthInput.Size = new Size(207, 53);
            gbxStrengthInput.TabIndex = 58;
            gbxStrengthInput.TabStop = false;
            gbxStrengthInput.Text = "Strength";
            // 
            // tbxStrengthInput
            // 
            tbxStrengthInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxStrengthInput.BackColor = SystemColors.ControlLight;
            tbxStrengthInput.BorderStyle = BorderStyle.None;
            tbxStrengthInput.Location = new Point(10, 19);
            tbxStrengthInput.Multiline = true;
            tbxStrengthInput.Name = "tbxStrengthInput";
            tbxStrengthInput.Size = new Size(191, 34);
            tbxStrengthInput.TabIndex = 43;
            tbxStrengthInput.TextChanged += tbxStrengthInput_TextChanged;
            // 
            // gbxCategoryInput
            // 
            gbxCategoryInput.Anchor = AnchorStyles.Left;
            gbxCategoryInput.Controls.Add(tbxCategoryInput);
            gbxCategoryInput.Font = new Font("Verdana", 9F);
            gbxCategoryInput.Location = new Point(16, 358);
            gbxCategoryInput.Name = "gbxCategoryInput";
            gbxCategoryInput.Size = new Size(207, 53);
            gbxCategoryInput.TabIndex = 57;
            gbxCategoryInput.TabStop = false;
            gbxCategoryInput.Text = "Category";
            // 
            // tbxCategoryInput
            // 
            tbxCategoryInput.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbxCategoryInput.BackColor = SystemColors.ControlLight;
            tbxCategoryInput.BorderStyle = BorderStyle.None;
            tbxCategoryInput.Location = new Point(10, 19);
            tbxCategoryInput.Multiline = true;
            tbxCategoryInput.Name = "tbxCategoryInput";
            tbxCategoryInput.Size = new Size(192, 34);
            tbxCategoryInput.TabIndex = 43;
            tbxCategoryInput.TextChanged += tbxCategoryInput_TextChanged;
            // 
            // materialTextBoxEdit8
            // 
            materialTextBoxEdit8.Anchor = AnchorStyles.None;
            materialTextBoxEdit8.AnimateReadOnly = false;
            materialTextBoxEdit8.AutoCompleteMode = AutoCompleteMode.None;
            materialTextBoxEdit8.AutoCompleteSource = AutoCompleteSource.None;
            materialTextBoxEdit8.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxEdit8.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxEdit8.Depth = 0;
            materialTextBoxEdit8.ErrorMessage = "This can't be empty.";
            materialTextBoxEdit8.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            materialTextBoxEdit8.HideSelection = true;
            materialTextBoxEdit8.Hint = "Prescription";
            materialTextBoxEdit8.LeadingIcon = null;
            materialTextBoxEdit8.LeaveOnEnterKey = true;
            materialTextBoxEdit8.Location = new Point(151, 719);
            materialTextBoxEdit8.MaxLength = 32767;
            materialTextBoxEdit8.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            materialTextBoxEdit8.Name = "materialTextBoxEdit8";
            materialTextBoxEdit8.PasswordChar = '\0';
            materialTextBoxEdit8.PrefixSuffixText = null;
            materialTextBoxEdit8.ReadOnly = false;
            materialTextBoxEdit8.RightToLeft = RightToLeft.No;
            materialTextBoxEdit8.SelectedText = "";
            materialTextBoxEdit8.SelectionLength = 0;
            materialTextBoxEdit8.SelectionStart = 0;
            materialTextBoxEdit8.ShortcutsEnabled = true;
            materialTextBoxEdit8.Size = new Size(409, 48);
            materialTextBoxEdit8.TabIndex = 27;
            materialTextBoxEdit8.TabStop = false;
            materialTextBoxEdit8.TextAlign = HorizontalAlignment.Left;
            materialTextBoxEdit8.TrailingIcon = null;
            materialTextBoxEdit8.UseSystemPasswordChar = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(213, 163, 170);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 579);
            panel4.Name = "panel4";
            panel4.Size = new Size(459, 10);
            panel4.TabIndex = 23;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(299, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(115, 27);
            textBox1.TabIndex = 36;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel2.Location = new Point(222, 108);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(78, 18);
            bigLabel2.TabIndex = 10;
            bigLabel2.Text = "Quantity:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(3, 7);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(203, 27);
            dateTimePicker1.TabIndex = 35;
            // 
            // comboBox7
            // 
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox7.Location = new Point(7, 104);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(199, 28);
            comboBox7.TabIndex = 34;
            comboBox7.Text = "Measurement Type";
            // 
            // comboBox8
            // 
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox8.Location = new Point(222, 53);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(199, 28);
            comboBox8.TabIndex = 33;
            comboBox8.Text = "Manufacturer";
            // 
            // comboBox9
            // 
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox9.Location = new Point(222, 6);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(199, 28);
            comboBox9.TabIndex = 32;
            comboBox9.Text = "Side Effects";
            // 
            // comboBox11
            // 
            comboBox11.FormattingEnabled = true;
            comboBox11.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox11.Location = new Point(3, 53);
            comboBox11.Name = "comboBox11";
            comboBox11.Size = new Size(199, 28);
            comboBox11.TabIndex = 30;
            comboBox11.Text = "Storage Condtitions";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox4.Location = new Point(222, 102);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(199, 28);
            comboBox4.TabIndex = 34;
            comboBox4.Text = "Measurement Type";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox5.Location = new Point(222, 53);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(199, 28);
            comboBox5.TabIndex = 33;
            comboBox5.Text = "Mild";
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox6.Location = new Point(222, 6);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(199, 28);
            comboBox6.TabIndex = 32;
            comboBox6.Text = "Dosage Form";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox3.Location = new Point(7, 102);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(199, 28);
            comboBox3.TabIndex = 31;
            comboBox3.Text = "Classification";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox1.Location = new Point(7, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 28);
            comboBox1.TabIndex = 30;
            comboBox1.Text = "Classification";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Age ", "Sex", "Medical Condition" });
            comboBox2.Location = new Point(7, 6);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(199, 28);
            comboBox2.TabIndex = 29;
            comboBox2.Text = "Category";
            // 
            // flowNewDrugPanel
            // 
            flowNewDrugPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowNewDrugPanel.AutoScroll = true;
            flowNewDrugPanel.BackColor = Color.FromArgb(230, 223, 222);
            flowNewDrugPanel.FlowDirection = FlowDirection.BottomUp;
            flowNewDrugPanel.Location = new Point(10, 299);
            flowNewDrugPanel.Name = "flowNewDrugPanel";
            flowNewDrugPanel.Size = new Size(409, 270);
            flowNewDrugPanel.TabIndex = 26;
            flowNewDrugPanel.Click += flowNewDrugPanel_Click;
            flowNewDrugPanel.Paint += flowDrugPanel_Paint_1;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(238, 220, 222);
            panel6.Controls.Add(cyberTextBox2);
            panel6.Controls.Add(flowNewDrugPanel);
            panel6.Controls.Add(cyberTextBox1);
            panel6.Controls.Add(dgvDrugRecords);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(459, 52);
            panel6.Name = "panel6";
            panel6.Size = new Size(432, 589);
            panel6.TabIndex = 27;
            // 
            // cyberTextBox2
            // 
            cyberTextBox2.Alpha = 20;
            cyberTextBox2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cyberTextBox2.AutoSize = true;
            cyberTextBox2.BackColor = Color.Transparent;
            cyberTextBox2.Background_WidthPen = 3F;
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
            cyberTextBox2.Location = new Point(10, 252);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = true;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 60;
            cyberTextBox2.Size = new Size(413, 42);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 39;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "R E C E N T L Y   A D D E D";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cyberTextBox1.AutoSize = true;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(37, 52, 68);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
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
            cyberTextBox1.TabIndex = 38;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "D A T A B A S E";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // NewDrugControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "NewDrugControl";
            Size = new Size(891, 641);
            Load += NewDrugControl_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDrugRecords).EndInit();
            panel3.ResumeLayout(false);
            gbxDateAddedInput.ResumeLayout(false);
            gbxDateAddedInput.PerformLayout();
            panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxDrugInput).EndInit();
            gbxExpiryInput.ResumeLayout(false);
            gbxExpiryInput.PerformLayout();
            gbxManuDateInput.ResumeLayout(false);
            gbxManuDateInput.PerformLayout();
            gbxQuantityInput.ResumeLayout(false);
            gbxQuantityInput.PerformLayout();
            gbxMeasurementInput.ResumeLayout(false);
            gbxMeasurementInput.PerformLayout();
            gbxStrengthInput.ResumeLayout(false);
            gbxStrengthInput.PerformLayout();
            gbxCategoryInput.ResumeLayout(false);
            gbxCategoryInput.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private DataGridView dgvDrugRecords;
        private Panel panel3;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit materialTextBoxEdit8;
        private Panel panel4;
        private Panel panel11;
        private Panel panel10;
        private ReaLTaiizor.Controls.CyberButton btnUploadDrugPhoto;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxGenNameInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxDrugNameInput;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit tbxBrandNameInput;
        private PictureBox picBoxDrugInput;
        private Panel panel13;
        private Panel panel15;
        
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private ComboBox comboBox11;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private FlowLayoutPanel flowNewDrugPanel;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel6;
        private GroupBox gbxManuDateInput;
        private TextBox tbxManuDateInput;
        private GroupBox gbxQuantityInput;
        private TextBox tbxQuantityInput;
        private GroupBox gbxMeasurementInput;
        private TextBox tbxMeasurementInput;
        private GroupBox gbxStrengthInput;
        private TextBox tbxStrengthInput;
        private GroupBox gbxCategoryInput;
        private TextBox tbxCategoryInput;
        private Panel panel12;
        private ReaLTaiizor.Controls.ParrotButton btnAddDrug;
        private GroupBox gbxExpiryInput;
        private TextBox tbxExpiryInput;
        private GroupBox gbxDateAddedInput;
        private TextBox tbxDateAddedInput;
        private Label label1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
    }
}