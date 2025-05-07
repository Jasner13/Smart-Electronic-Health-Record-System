namespace SEHRS
{
    partial class FilterAnalyticsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilterAnalyticsControl));
            pltview = new OxyPlot.WindowsForms.PlotView();
            cbxFilterPatientAnalytics = new ComboBox();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnSearchCondition = new FontAwesome.Sharp.IconButton();
            SearchCondition = new TextBox();
            dtpStartDate = new ReaLTaiizor.Controls.HopeDatePicker();
            dtpEndDate = new ReaLTaiizor.Controls.HopeDatePicker();
            btnSetStart = new ReaLTaiizor.Controls.ParrotButton();
            btnSetEnd = new ReaLTaiizor.Controls.ParrotButton();
            lblSelectDate = new ReaLTaiizor.Controls.BigLabel();
            pnlDatePicker = new Panel();
            panel1.SuspendLayout();
            pnlDatePicker.SuspendLayout();
            SuspendLayout();
            // 
            // pltview
            // 
            pltview.Location = new Point(3, 58);
            pltview.Name = "pltview";
            pltview.PanCursor = Cursors.Hand;
            pltview.Size = new Size(885, 580);
            pltview.TabIndex = 39;
            pltview.Text = "plotView1";
            pltview.ZoomHorizontalCursor = Cursors.SizeWE;
            pltview.ZoomRectangleCursor = Cursors.SizeNWSE;
            pltview.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // cbxFilterPatientAnalytics
            // 
            cbxFilterPatientAnalytics.FormattingEnabled = true;
            cbxFilterPatientAnalytics.Items.AddRange(new object[] { "Date Range", "Medical Condition", "Overall Distribution" });
            cbxFilterPatientAnalytics.Location = new Point(667, 527);
            cbxFilterPatientAnalytics.Name = "cbxFilterPatientAnalytics";
            cbxFilterPatientAnalytics.Size = new Size(208, 28);
            cbxFilterPatientAnalytics.TabIndex = 42;
            cbxFilterPatientAnalytics.Text = "Filter Analytics by";
            cbxFilterPatientAnalytics.SelectedIndexChanged += cbxFilterPatientAnalytics_SelectedIndexChanged;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Transparent;
            iconButton2.FlatAppearance.BorderSize = 0;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 40;
            iconButton2.Location = new Point(844, 9);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(37, 37);
            iconButton2.TabIndex = 32;
            iconButton2.Tag = "Home";
            iconButton2.TextAlign = ContentAlignment.TopCenter;
            iconButton2.TextImageRelation = TextImageRelation.ImageAboveText;
            iconButton2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(bigLabel1);
            panel1.Controls.Add(iconButton2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(891, 52);
            panel1.TabIndex = 0;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Swis721 BlkEx BT", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(114, 2);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(653, 50);
            bigLabel1.TabIndex = 33;
            bigLabel1.Text = "PATIENTS ANALYTICS";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // btnSearchCondition
            // 
            btnSearchCondition.IconChar = FontAwesome.Sharp.IconChar.Search;
            btnSearchCondition.IconColor = Color.Black;
            btnSearchCondition.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSearchCondition.IconSize = 30;
            btnSearchCondition.Location = new Point(828, 558);
            btnSearchCondition.Name = "btnSearchCondition";
            btnSearchCondition.Size = new Size(47, 34);
            btnSearchCondition.TabIndex = 44;
            btnSearchCondition.UseVisualStyleBackColor = true;
            btnSearchCondition.Click += btnSearchCondition_Click;
            // 
            // SearchCondition
            // 
            SearchCondition.Location = new Point(667, 558);
            SearchCondition.Multiline = true;
            SearchCondition.Name = "SearchCondition";
            SearchCondition.Size = new Size(166, 33);
            SearchCondition.TabIndex = 45;
            SearchCondition.TextChanged += SearchCondition_TextChanged;
            // 
            // dtpStartDate
            // 
            dtpStartDate.BackColor = Color.White;
            dtpStartDate.BorderColor = Color.FromArgb(220, 223, 230);
            dtpStartDate.Date = new DateTime(2025, 4, 13, 0, 0, 0, 0);
            dtpStartDate.DayNames = "MTWTFSS";
            dtpStartDate.DaysTextColor = Color.FromArgb(96, 98, 102);
            dtpStartDate.DayTextColorA = Color.FromArgb(48, 49, 51);
            dtpStartDate.DayTextColorB = Color.FromArgb(144, 147, 153);
            dtpStartDate.HeaderFormat = "{0} Y - {1} M";
            dtpStartDate.HeaderTextColor = Color.FromArgb(48, 49, 51);
            dtpStartDate.HeadLineColor = Color.FromArgb(228, 231, 237);
            dtpStartDate.HoverColor = Color.FromArgb(235, 238, 245);
            dtpStartDate.Location = new Point(5, 33);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.NMColor = Color.FromArgb(192, 196, 204);
            dtpStartDate.NMHoverColor = Color.FromArgb(64, 158, 255);
            dtpStartDate.NYColor = Color.FromArgb(192, 196, 204);
            dtpStartDate.NYHoverColor = Color.FromArgb(64, 158, 255);
            dtpStartDate.PMColor = Color.FromArgb(192, 196, 204);
            dtpStartDate.PMHoverColor = Color.FromArgb(64, 158, 255);
            dtpStartDate.PYColor = Color.FromArgb(192, 196, 204);
            dtpStartDate.PYHoverColor = Color.FromArgb(64, 158, 255);
            dtpStartDate.SelectedBackColor = Color.FromArgb(64, 158, 255);
            dtpStartDate.SelectedTextColor = Color.White;
            dtpStartDate.Size = new Size(250, 270);
            dtpStartDate.TabIndex = 46;
            dtpStartDate.Text = "hopeDatePicker1";
            dtpStartDate.ValueTextColor = Color.FromArgb(43, 133, 228);
            dtpStartDate.Click += dtpStartDate_Click;
            // 
            // dtpEndDate
            // 
            dtpEndDate.BackColor = Color.White;
            dtpEndDate.BorderColor = Color.FromArgb(220, 223, 230);
            dtpEndDate.Date = new DateTime(2025, 4, 13, 0, 0, 0, 0);
            dtpEndDate.DayNames = "MTWTFSS";
            dtpEndDate.DaysTextColor = Color.FromArgb(96, 98, 102);
            dtpEndDate.DayTextColorA = Color.FromArgb(48, 49, 51);
            dtpEndDate.DayTextColorB = Color.FromArgb(144, 147, 153);
            dtpEndDate.HeaderFormat = "{0} Y - {1} M";
            dtpEndDate.HeaderTextColor = Color.FromArgb(48, 49, 51);
            dtpEndDate.HeadLineColor = Color.FromArgb(228, 231, 237);
            dtpEndDate.HoverColor = Color.FromArgb(235, 238, 245);
            dtpEndDate.Location = new Point(5, 33);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.NMColor = Color.FromArgb(192, 196, 204);
            dtpEndDate.NMHoverColor = Color.FromArgb(64, 158, 255);
            dtpEndDate.NYColor = Color.FromArgb(192, 196, 204);
            dtpEndDate.NYHoverColor = Color.FromArgb(64, 158, 255);
            dtpEndDate.PMColor = Color.FromArgb(192, 196, 204);
            dtpEndDate.PMHoverColor = Color.FromArgb(64, 158, 255);
            dtpEndDate.PYColor = Color.FromArgb(192, 196, 204);
            dtpEndDate.PYHoverColor = Color.FromArgb(64, 158, 255);
            dtpEndDate.SelectedBackColor = Color.FromArgb(64, 158, 255);
            dtpEndDate.SelectedTextColor = Color.White;
            dtpEndDate.Size = new Size(250, 270);
            dtpEndDate.TabIndex = 47;
            dtpEndDate.Text = "hopeDatePicker1";
            dtpEndDate.ValueTextColor = Color.FromArgb(43, 133, 228);
            dtpEndDate.Click += dtpEndDate_Click;
            // 
            // btnSetStart
            // 
            btnSetStart.BackgroundColor = Color.White;
            btnSetStart.ButtonImage = (Image)resources.GetObject("btnSetStart.ButtonImage");
            btnSetStart.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSetStart.ButtonText = "Set Start";
            btnSetStart.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSetStart.ClickTextColor = Color.DodgerBlue;
            btnSetStart.CornerRadius = 5;
            btnSetStart.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetStart.Horizontal_Alignment = StringAlignment.Center;
            btnSetStart.HoverBackgroundColor = Color.FromArgb(43, 133, 228);
            btnSetStart.HoverTextColor = Color.Black;
            btnSetStart.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSetStart.Location = new Point(5, 307);
            btnSetStart.Name = "btnSetStart";
            btnSetStart.Size = new Size(250, 28);
            btnSetStart.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSetStart.TabIndex = 49;
            btnSetStart.TextColor = Color.FromArgb(43, 133, 228);
            btnSetStart.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSetStart.Vertical_Alignment = StringAlignment.Center;
            btnSetStart.Click += btnSetStart_Click;
            // 
            // btnSetEnd
            // 
            btnSetEnd.BackgroundColor = Color.White;
            btnSetEnd.ButtonImage = (Image)resources.GetObject("btnSetEnd.ButtonImage");
            btnSetEnd.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSetEnd.ButtonText = "Set End";
            btnSetEnd.ClickBackColor = Color.FromArgb(195, 195, 195);
            btnSetEnd.ClickTextColor = Color.DodgerBlue;
            btnSetEnd.CornerRadius = 5;
            btnSetEnd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetEnd.Horizontal_Alignment = StringAlignment.Center;
            btnSetEnd.HoverBackgroundColor = Color.FromArgb(43, 133, 228);
            btnSetEnd.HoverTextColor = Color.Black;
            btnSetEnd.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSetEnd.Location = new Point(5, 307);
            btnSetEnd.Name = "btnSetEnd";
            btnSetEnd.Size = new Size(250, 28);
            btnSetEnd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSetEnd.TabIndex = 50;
            btnSetEnd.TextColor = Color.FromArgb(43, 133, 228);
            btnSetEnd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSetEnd.Vertical_Alignment = StringAlignment.Center;
            btnSetEnd.Click += btnSetEnd_Click;
            // 
            // lblSelectDate
            // 
            lblSelectDate.AutoSize = true;
            lblSelectDate.BackColor = Color.FromArgb(43, 133, 228);
            lblSelectDate.BorderStyle = BorderStyle.FixedSingle;
            lblSelectDate.Font = new Font("MS UI Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectDate.ForeColor = Color.White;
            lblSelectDate.Location = new Point(4, 0);
            lblSelectDate.Name = "lblSelectDate";
            lblSelectDate.Size = new Size(251, 30);
            lblSelectDate.TabIndex = 51;
            lblSelectDate.Text = "Select Date Range";
            lblSelectDate.Click += lblSelectDate_Click;
            // 
            // pnlDatePicker
            // 
            pnlDatePicker.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlDatePicker.BackColor = Color.LightSkyBlue;
            pnlDatePicker.Controls.Add(dtpStartDate);
            pnlDatePicker.Controls.Add(btnSetStart);
            pnlDatePicker.Controls.Add(dtpEndDate);
            pnlDatePicker.Controls.Add(lblSelectDate);
            pnlDatePicker.Controls.Add(btnSetEnd);
            pnlDatePicker.Location = new Point(620, 58);
            pnlDatePicker.Name = "pnlDatePicker";
            pnlDatePicker.Size = new Size(261, 338);
            pnlDatePicker.TabIndex = 52;
            // 
            // FilterAnalyticsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pnlDatePicker);
            Controls.Add(SearchCondition);
            Controls.Add(btnSearchCondition);
            Controls.Add(cbxFilterPatientAnalytics);
            Controls.Add(pltview);
            Controls.Add(panel1);
            Name = "FilterAnalyticsControl";
            Size = new Size(891, 641);
            Load += FilterAnalyticsControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlDatePicker.ResumeLayout(false);
            pnlDatePicker.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OxyPlot.WindowsForms.PlotView pltview;
        private ComboBox cbxFilterPatientAnalytics;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private FontAwesome.Sharp.IconButton btnSearchCondition;
        private TextBox SearchCondition;
        private ReaLTaiizor.Controls.HopeDatePicker dtpStartDate;
        private ReaLTaiizor.Controls.HopeDatePicker dtpEndDate;
        private ReaLTaiizor.Controls.ParrotButton btnSetStart;
        private ReaLTaiizor.Controls.ParrotButton btnSetEnd;
        private ReaLTaiizor.Controls.BigLabel lblSelectDate;
        private Panel pnlDatePicker;
    }
}
