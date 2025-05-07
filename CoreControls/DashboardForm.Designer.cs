
namespace SEHRS
{
    partial class DashboardForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnAnalytics = new FontAwesome.Sharp.IconButton();
            pnlInventory = new Panel();
            btnManageInventory = new Button();
            btnNewDrug = new Button();
            btnInventory = new FontAwesome.Sharp.IconButton();
            pnlPatient = new Panel();
            btnNotifyPatients = new Button();
            btnManagePatient = new Button();
            btnNewPatient = new Button();
            btnPatient = new FontAwesome.Sharp.IconButton();
            btnHome = new FontAwesome.Sharp.IconButton();
            btnExit = new FontAwesome.Sharp.IconButton();
            panelUpLeft = new Panel();
            btnMenu = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            panelTitleBar = new Panel();
            btnMinimize = new FontAwesome.Sharp.IconButton();
            btnMaximize = new FontAwesome.Sharp.IconButton();
            btnClose = new FontAwesome.Sharp.IconButton();
            panelDesktop = new ReaLTaiizor.Controls.MetroPanel();
            pnlContent = new Panel();
            panelMenu.SuspendLayout();
            pnlInventory.SuspendLayout();
            pnlPatient.SuspendLayout();
            panelUpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelTitleBar.SuspendLayout();
            panelDesktop.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(btnAnalytics);
            panelMenu.Controls.Add(pnlInventory);
            panelMenu.Controls.Add(btnInventory);
            panelMenu.Controls.Add(pnlPatient);
            panelMenu.Controls.Add(btnPatient);
            panelMenu.Controls.Add(btnHome);
            panelMenu.Controls.Add(btnExit);
            panelMenu.Controls.Add(panelUpLeft);
            panelMenu.Cursor = Cursors.Hand;
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(209, 689);
            panelMenu.TabIndex = 1;
            // 
            // btnAnalytics
            // 
            btnAnalytics.Dock = DockStyle.Top;
            btnAnalytics.FlatAppearance.BorderSize = 0;
            btnAnalytics.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 209, 235);
            btnAnalytics.FlatStyle = FlatStyle.Flat;
            btnAnalytics.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnalytics.ForeColor = Color.Black;
            btnAnalytics.IconChar = FontAwesome.Sharp.IconChar.ChartLine;
            btnAnalytics.IconColor = Color.FromArgb(9, 78, 166);
            btnAnalytics.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAnalytics.IconSize = 30;
            btnAnalytics.ImageAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.Location = new Point(0, 572);
            btnAnalytics.Name = "btnAnalytics";
            btnAnalytics.Padding = new Padding(5, 0, 0, 0);
            btnAnalytics.Size = new Size(209, 59);
            btnAnalytics.TabIndex = 4;
            btnAnalytics.Tag = "Analytics";
            btnAnalytics.Text = "Analytics";
            btnAnalytics.TextAlign = ContentAlignment.MiddleLeft;
            btnAnalytics.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAnalytics.UseVisualStyleBackColor = true;
            btnAnalytics.Click += btnAnalytics_Click;
            // 
            // pnlInventory
            // 
            pnlInventory.BackColor = Color.White;
            pnlInventory.Controls.Add(btnManageInventory);
            pnlInventory.Controls.Add(btnNewDrug);
            pnlInventory.Dock = DockStyle.Top;
            pnlInventory.Location = new Point(0, 472);
            pnlInventory.Name = "pnlInventory";
            pnlInventory.Size = new Size(209, 100);
            pnlInventory.TabIndex = 9;
            pnlInventory.Paint += pnlInventory_Paint;
            // 
            // btnManageInventory
            // 
            btnManageInventory.BackColor = Color.FromArgb(230, 239, 255);
            btnManageInventory.Dock = DockStyle.Fill;
            btnManageInventory.FlatAppearance.BorderSize = 0;
            btnManageInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 226, 225);
            btnManageInventory.FlatStyle = FlatStyle.Flat;
            btnManageInventory.ForeColor = Color.Black;
            btnManageInventory.Location = new Point(0, 50);
            btnManageInventory.Name = "btnManageInventory";
            btnManageInventory.Padding = new Padding(31, 0, 0, 0);
            btnManageInventory.Size = new Size(209, 50);
            btnManageInventory.TabIndex = 1;
            btnManageInventory.Text = "Manage Inventory";
            btnManageInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnManageInventory.UseVisualStyleBackColor = false;
            btnManageInventory.Click += btnManageInventory_Click;
            // 
            // btnNewDrug
            // 
            btnNewDrug.BackColor = Color.FromArgb(230, 239, 255);
            btnNewDrug.Dock = DockStyle.Top;
            btnNewDrug.FlatAppearance.BorderSize = 0;
            btnNewDrug.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 226, 225);
            btnNewDrug.FlatStyle = FlatStyle.Flat;
            btnNewDrug.ForeColor = Color.Black;
            btnNewDrug.Location = new Point(0, 0);
            btnNewDrug.Name = "btnNewDrug";
            btnNewDrug.Padding = new Padding(31, 0, 0, 0);
            btnNewDrug.Size = new Size(209, 50);
            btnNewDrug.TabIndex = 0;
            btnNewDrug.Text = "New Drug";
            btnNewDrug.TextAlign = ContentAlignment.MiddleLeft;
            btnNewDrug.UseVisualStyleBackColor = false;
            btnNewDrug.Click += btmNewDrug_Click;
            // 
            // btnInventory
            // 
            btnInventory.Dock = DockStyle.Top;
            btnInventory.FlatAppearance.BorderSize = 0;
            btnInventory.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 209, 235);
            btnInventory.FlatStyle = FlatStyle.Flat;
            btnInventory.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInventory.ForeColor = Color.Black;
            btnInventory.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            btnInventory.IconColor = Color.FromArgb(9, 78, 166);
            btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnInventory.IconSize = 30;
            btnInventory.ImageAlign = ContentAlignment.MiddleLeft;
            btnInventory.Location = new Point(0, 413);
            btnInventory.Name = "btnInventory";
            btnInventory.Padding = new Padding(5, 0, 0, 0);
            btnInventory.Size = new Size(209, 59);
            btnInventory.TabIndex = 3;
            btnInventory.Tag = "Inventory";
            btnInventory.Text = "Inventory";
            btnInventory.TextAlign = ContentAlignment.MiddleLeft;
            btnInventory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnInventory.UseVisualStyleBackColor = true;
            btnInventory.Click += btnInventory_Click;
            // 
            // pnlPatient
            // 
            pnlPatient.BackColor = Color.White;
            pnlPatient.Controls.Add(btnNotifyPatients);
            pnlPatient.Controls.Add(btnManagePatient);
            pnlPatient.Controls.Add(btnNewPatient);
            pnlPatient.Dock = DockStyle.Top;
            pnlPatient.Location = new Point(0, 263);
            pnlPatient.Name = "pnlPatient";
            pnlPatient.Size = new Size(209, 150);
            pnlPatient.TabIndex = 8;
            pnlPatient.Visible = false;
            pnlPatient.Paint += pnlPatient_Paint;
            // 
            // btnNotifyPatients
            // 
            btnNotifyPatients.BackColor = Color.FromArgb(230, 239, 255);
            btnNotifyPatients.Dock = DockStyle.Fill;
            btnNotifyPatients.FlatAppearance.BorderSize = 0;
            btnNotifyPatients.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 226, 225);
            btnNotifyPatients.FlatStyle = FlatStyle.Flat;
            btnNotifyPatients.Font = new Font("Segoe UI", 9F);
            btnNotifyPatients.ForeColor = Color.Black;
            btnNotifyPatients.Location = new Point(0, 100);
            btnNotifyPatients.Name = "btnNotifyPatients";
            btnNotifyPatients.Padding = new Padding(31, 0, 0, 0);
            btnNotifyPatients.Size = new Size(209, 50);
            btnNotifyPatients.TabIndex = 2;
            btnNotifyPatients.Text = "Notify Patients";
            btnNotifyPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnNotifyPatients.UseVisualStyleBackColor = false;
            btnNotifyPatients.Click += btnNotifyPatients_Click;
            // 
            // btnManagePatient
            // 
            btnManagePatient.BackColor = Color.FromArgb(230, 239, 255);
            btnManagePatient.Dock = DockStyle.Top;
            btnManagePatient.FlatAppearance.BorderSize = 0;
            btnManagePatient.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 226, 225);
            btnManagePatient.FlatStyle = FlatStyle.Flat;
            btnManagePatient.Font = new Font("Segoe UI", 9F);
            btnManagePatient.ForeColor = Color.Black;
            btnManagePatient.Location = new Point(0, 50);
            btnManagePatient.Name = "btnManagePatient";
            btnManagePatient.Padding = new Padding(31, 0, 0, 0);
            btnManagePatient.Size = new Size(209, 50);
            btnManagePatient.TabIndex = 1;
            btnManagePatient.Text = "Manage Patients";
            btnManagePatient.TextAlign = ContentAlignment.MiddleLeft;
            btnManagePatient.UseVisualStyleBackColor = false;
            btnManagePatient.Click += btnManagePatient_Click;
            // 
            // btnNewPatient
            // 
            btnNewPatient.BackColor = Color.FromArgb(230, 239, 255);
            btnNewPatient.Dock = DockStyle.Top;
            btnNewPatient.FlatAppearance.BorderSize = 0;
            btnNewPatient.FlatAppearance.MouseOverBackColor = Color.FromArgb(163, 226, 225);
            btnNewPatient.FlatStyle = FlatStyle.Flat;
            btnNewPatient.Font = new Font("Segoe UI", 9F);
            btnNewPatient.ForeColor = Color.Black;
            btnNewPatient.Location = new Point(0, 0);
            btnNewPatient.Name = "btnNewPatient";
            btnNewPatient.Padding = new Padding(31, 0, 0, 0);
            btnNewPatient.Size = new Size(209, 50);
            btnNewPatient.TabIndex = 0;
            btnNewPatient.Text = "New Patient";
            btnNewPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnNewPatient.UseVisualStyleBackColor = false;
            btnNewPatient.Click += btnNewPatient_CLick;
            // 
            // btnPatient
            // 
            btnPatient.BackColor = Color.White;
            btnPatient.Dock = DockStyle.Top;
            btnPatient.FlatAppearance.BorderSize = 0;
            btnPatient.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 209, 235);
            btnPatient.FlatStyle = FlatStyle.Flat;
            btnPatient.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPatient.ForeColor = Color.Black;
            btnPatient.IconChar = FontAwesome.Sharp.IconChar.UserInjured;
            btnPatient.IconColor = Color.FromArgb(9, 78, 166);
            btnPatient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPatient.IconSize = 30;
            btnPatient.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatient.Location = new Point(0, 204);
            btnPatient.Name = "btnPatient";
            btnPatient.Padding = new Padding(5, 0, 0, 0);
            btnPatient.Size = new Size(209, 59);
            btnPatient.TabIndex = 2;
            btnPatient.Tag = "Patient";
            btnPatient.Text = "Patient";
            btnPatient.TextAlign = ContentAlignment.MiddleLeft;
            btnPatient.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatient.UseVisualStyleBackColor = false;
            btnPatient.Click += btnPatient_Click;
            // 
            // btnHome
            // 
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(196, 209, 235);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.Black;
            btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            btnHome.IconColor = Color.FromArgb(9, 78, 166);
            btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHome.IconSize = 30;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 145);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(5, 0, 0, 0);
            btnHome.Size = new Size(209, 59);
            btnHome.TabIndex = 1;
            btnHome.Tag = "Home";
            btnHome.Text = "Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            btnExit.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            btnExit.IconColor = Color.FromArgb(255, 128, 128);
            btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnExit.IconSize = 30;
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 652);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(15, 0, 0, 0);
            btnExit.Size = new Size(209, 37);
            btnExit.TabIndex = 7;
            btnExit.Tag = "Close System";
            btnExit.Text = "Close System";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // panelUpLeft
            // 
            panelUpLeft.Controls.Add(btnMenu);
            panelUpLeft.Controls.Add(pictureBox1);
            panelUpLeft.Dock = DockStyle.Top;
            panelUpLeft.Location = new Point(0, 0);
            panelUpLeft.Name = "panelUpLeft";
            panelUpLeft.Size = new Size(209, 145);
            panelUpLeft.TabIndex = 0;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.IconChar = FontAwesome.Sharp.IconChar.Bars;
            btnMenu.IconColor = Color.FromArgb(9, 78, 166);
            btnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenu.IconSize = 50;
            btnMenu.Location = new Point(143, 1);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(57, 47);
            btnMenu.TabIndex = 1;
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.SHERS_Logo_No_sub_text_;
            pictureBox1.Location = new Point(-24, -28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 182);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(242, 247, 255);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(209, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(892, 49);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.Paint += panelTitleBar_Paint;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown_1;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.BackColor = Color.Beige;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.Transparent;
            btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            btnMinimize.IconColor = Color.Gray;
            btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnMinimize.IconSize = 30;
            btnMinimize.Location = new Point(760, 12);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(0, 0, 0, 15);
            btnMinimize.Size = new Size(40, 25);
            btnMinimize.TabIndex = 4;
            btnMinimize.UseVisualStyleBackColor = false;
            btnMinimize.Click += btnMinimize_Click;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.BackColor = Color.Beige;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.Transparent;
            btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            btnMaximize.IconColor = Color.Gray;
            btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximize.IconSize = 30;
            btnMaximize.Location = new Point(804, 12);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(40, 25);
            btnMaximize.TabIndex = 3;
            btnMaximize.UseVisualStyleBackColor = false;
            btnMaximize.Click += btnMaximize_Click;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.BackColor = Color.FromArgb(248, 117, 117);
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.Transparent;
            btnClose.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnClose.IconColor = Color.Gray;
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 30;
            btnClose.Location = new Point(848, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 25);
            btnClose.TabIndex = 2;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.BackgroundColor = Color.White;
            panelDesktop.BorderColor = Color.FromArgb(150, 150, 150);
            panelDesktop.BorderThickness = 1;
            panelDesktop.Controls.Add(pnlContent);
            panelDesktop.Controls.Add(panelTitleBar);
            panelDesktop.Controls.Add(panelMenu);
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.IsDerivedStyle = true;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(1101, 689);
            panelDesktop.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            panelDesktop.StyleManager = null;
            panelDesktop.TabIndex = 4;
            panelDesktop.ThemeAuthor = "Taiizor";
            panelDesktop.ThemeName = "MetroLight";
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(242, 247, 255);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(209, 49);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(892, 640);
            pnlContent.TabIndex = 3;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1101, 689);
            Controls.Add(panelDesktop);
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            Load += DashboardForm_Load;
            Resize += DashboardForm_Resize;
            panelMenu.ResumeLayout(false);
            pnlInventory.ResumeLayout(false);
            pnlPatient.ResumeLayout(false);
            panelUpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelDesktop.ResumeLayout(false);
            ResumeLayout(false);
        }


        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAnalytics;
        private Panel pnlInventory;
        private Button btnManageInventory;
        private Button btnNewDrug;
        private FontAwesome.Sharp.IconButton btnInventory;
        private Panel pnlPatient;
        private Button btnManagePatient;
        private Button btnNewPatient;
        private FontAwesome.Sharp.IconButton btnPatient;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnExit;
        private Panel panelUpLeft;
        private FontAwesome.Sharp.IconButton btnMenu;
        private PictureBox pictureBox1;
        private Panel panelTitleBar;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnClose;
        private ReaLTaiizor.Controls.MetroPanel panelDesktop;
        private Panel pnlContent;
        private Button btnNotifyPatients;
    }
}