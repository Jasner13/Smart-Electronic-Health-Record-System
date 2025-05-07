namespace SEHRS
{
    partial class HomeControl
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
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            ClockLabel = new Label();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pltHomeViewSpecific = new OxyPlot.WindowsForms.PlotView();
            pltHomeViewOverall = new OxyPlot.WindowsForms.PlotView();
            flowHomePanel = new FlowLayoutPanel();
            btnJumpPatRecords = new ReaLTaiizor.Controls.CyberButton();
            btnJumpInventory = new ReaLTaiizor.Controls.CyberButton();
            flowHomeMedPanel = new FlowLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            timerDateTime = new System.Windows.Forms.Timer(components);
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(242, 247, 255);
            panel2.Controls.Add(ClockLabel);
            panel2.Controls.Add(bigLabel1);
            panel2.Controls.Add(pltHomeViewSpecific);
            panel2.Controls.Add(pltHomeViewOverall);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(891, 435);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // ClockLabel
            // 
            ClockLabel.Anchor = AnchorStyles.None;
            ClockLabel.Font = new Font("Sitka Banner", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClockLabel.ForeColor = Color.Black;
            ClockLabel.Location = new Point(0, 0);
            ClockLabel.Name = "ClockLabel";
            ClockLabel.Padding = new Padding(5);
            ClockLabel.Size = new Size(151, 50);
            ClockLabel.TabIndex = 35;
            ClockLabel.Text = "label1";
            ClockLabel.TextAlign = ContentAlignment.TopCenter;
            ClockLabel.Click += ClockLabel_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.Top;
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Swis721 BlkEx BT", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(254, 0);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(387, 50);
            bigLabel1.TabIndex = 34;
            bigLabel1.Text = "HIGHLIGHTS";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // pltHomeViewSpecific
            // 
            pltHomeViewSpecific.Anchor = AnchorStyles.None;
            pltHomeViewSpecific.Location = new Point(458, 66);
            pltHomeViewSpecific.Name = "pltHomeViewSpecific";
            pltHomeViewSpecific.PanCursor = Cursors.Hand;
            pltHomeViewSpecific.Size = new Size(430, 363);
            pltHomeViewSpecific.TabIndex = 9;
            pltHomeViewSpecific.Text = "pltHomeViewSpecific";
            pltHomeViewSpecific.ZoomHorizontalCursor = Cursors.SizeWE;
            pltHomeViewSpecific.ZoomRectangleCursor = Cursors.SizeNWSE;
            pltHomeViewSpecific.ZoomVerticalCursor = Cursors.SizeNS;
            pltHomeViewSpecific.Click += pltHomeViewSpecific_Click;
            // 
            // pltHomeViewOverall
            // 
            pltHomeViewOverall.Anchor = AnchorStyles.None;
            pltHomeViewOverall.Location = new Point(3, 66);
            pltHomeViewOverall.Name = "pltHomeViewOverall";
            pltHomeViewOverall.PanCursor = Cursors.Hand;
            pltHomeViewOverall.Size = new Size(419, 363);
            pltHomeViewOverall.TabIndex = 8;
            pltHomeViewOverall.ZoomHorizontalCursor = Cursors.SizeWE;
            pltHomeViewOverall.ZoomRectangleCursor = Cursors.SizeNWSE;
            pltHomeViewOverall.ZoomVerticalCursor = Cursors.SizeNS;
            pltHomeViewOverall.Click += pltHomeViewOverall_Click;
            // 
            // flowHomePanel
            // 
            flowHomePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            flowHomePanel.AutoScroll = true;
            flowHomePanel.BackColor = Color.FromArgb(242, 247, 255);
            flowHomePanel.FlowDirection = FlowDirection.BottomUp;
            flowHomePanel.Location = new Point(3, 8);
            flowHomePanel.Name = "flowHomePanel";
            flowHomePanel.Size = new Size(425, 140);
            flowHomePanel.TabIndex = 2;
            // 
            // btnJumpPatRecords
            // 
            btnJumpPatRecords.Alpha = 20;
            btnJumpPatRecords.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnJumpPatRecords.BackColor = Color.Transparent;
            btnJumpPatRecords.Background = true;
            btnJumpPatRecords.Background_WidthPen = 4F;
            btnJumpPatRecords.BackgroundPen = true;
            btnJumpPatRecords.ColorBackground = Color.FromArgb(37, 52, 68);
            btnJumpPatRecords.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnJumpPatRecords.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnJumpPatRecords.ColorBackground_Pen = Color.LightCoral;
            btnJumpPatRecords.ColorLighting = Color.FromArgb(29, 200, 238);
            btnJumpPatRecords.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnJumpPatRecords.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnJumpPatRecords.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnJumpPatRecords.Effect_1 = true;
            btnJumpPatRecords.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnJumpPatRecords.Effect_1_Transparency = 25;
            btnJumpPatRecords.Effect_2 = true;
            btnJumpPatRecords.Effect_2_ColorBackground = Color.White;
            btnJumpPatRecords.Effect_2_Transparency = 20;
            btnJumpPatRecords.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJumpPatRecords.ForeColor = Color.FromArgb(245, 245, 245);
            btnJumpPatRecords.Lighting = false;
            btnJumpPatRecords.LinearGradient_Background = false;
            btnJumpPatRecords.LinearGradientPen = false;
            btnJumpPatRecords.Location = new Point(61, 154);
            btnJumpPatRecords.Name = "btnJumpPatRecords";
            btnJumpPatRecords.PenWidth = 15;
            btnJumpPatRecords.Rounding = true;
            btnJumpPatRecords.RoundingInt = 70;
            btnJumpPatRecords.Size = new Size(301, 36);
            btnJumpPatRecords.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnJumpPatRecords.TabIndex = 16;
            btnJumpPatRecords.Tag = "Cyber";
            btnJumpPatRecords.TextButton = "Manage Patients";
            btnJumpPatRecords.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnJumpPatRecords.Timer_Effect_1 = 5;
            btnJumpPatRecords.Timer_RGB = 300;
            btnJumpPatRecords.Click += btnJumpPatRecords_Click;
            // 
            // btnJumpInventory
            // 
            btnJumpInventory.Alpha = 20;
            btnJumpInventory.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnJumpInventory.BackColor = Color.Transparent;
            btnJumpInventory.Background = true;
            btnJumpInventory.Background_WidthPen = 4F;
            btnJumpInventory.BackgroundPen = true;
            btnJumpInventory.ColorBackground = Color.FromArgb(37, 52, 68);
            btnJumpInventory.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnJumpInventory.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnJumpInventory.ColorBackground_Pen = Color.LightCoral;
            btnJumpInventory.ColorLighting = Color.FromArgb(29, 200, 238);
            btnJumpInventory.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnJumpInventory.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnJumpInventory.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnJumpInventory.Effect_1 = true;
            btnJumpInventory.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnJumpInventory.Effect_1_Transparency = 25;
            btnJumpInventory.Effect_2 = true;
            btnJumpInventory.Effect_2_ColorBackground = Color.White;
            btnJumpInventory.Effect_2_Transparency = 20;
            btnJumpInventory.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnJumpInventory.ForeColor = Color.FromArgb(245, 245, 245);
            btnJumpInventory.Lighting = false;
            btnJumpInventory.LinearGradient_Background = false;
            btnJumpInventory.LinearGradientPen = false;
            btnJumpInventory.Location = new Point(68, 157);
            btnJumpInventory.Name = "btnJumpInventory";
            btnJumpInventory.PenWidth = 15;
            btnJumpInventory.Rounding = true;
            btnJumpInventory.RoundingInt = 70;
            btnJumpInventory.Size = new Size(301, 36);
            btnJumpInventory.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnJumpInventory.TabIndex = 15;
            btnJumpInventory.Tag = "Cyber";
            btnJumpInventory.TextButton = "Manage Drugs";
            btnJumpInventory.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnJumpInventory.Timer_Effect_1 = 5;
            btnJumpInventory.Timer_RGB = 300;
            btnJumpInventory.Click += btnJumpInventory_Click;
            // 
            // flowHomeMedPanel
            // 
            flowHomeMedPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            flowHomeMedPanel.AutoScroll = true;
            flowHomeMedPanel.BackColor = Color.FromArgb(242, 247, 255);
            flowHomeMedPanel.FlowDirection = FlowDirection.BottomUp;
            flowHomeMedPanel.Location = new Point(3, 11);
            flowHomeMedPanel.Name = "flowHomeMedPanel";
            flowHomeMedPanel.Size = new Size(442, 140);
            flowHomeMedPanel.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(230, 239, 255);
            panel1.Controls.Add(flowHomeMedPanel);
            panel1.Controls.Add(btnJumpInventory);
            panel1.Location = new Point(443, 435);
            panel1.Name = "panel1";
            panel1.Size = new Size(448, 202);
            panel1.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(230, 239, 255);
            panel3.Controls.Add(flowHomePanel);
            panel3.Controls.Add(btnJumpPatRecords);
            panel3.Location = new Point(0, 435);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 202);
            panel3.TabIndex = 18;
            // 
            // timerDateTime
            // 
            timerDateTime.Tick += timerDateTime_Tick_1;
            // 
            // HomeControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 247, 255);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "HomeControl";
            Size = new Size(891, 640);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private FlowLayoutPanel flowHomeMedPanel;
        private FlowLayoutPanel flowHomePanel;
        private ReaLTaiizor.Controls.CyberButton btnJumpPatRecords;
        private ReaLTaiizor.Controls.CyberButton btnJumpInventory;
        private OxyPlot.WindowsForms.PlotView pltHomeViewSpecific;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel panel1;
        private Panel panel3;
        private System.Windows.Forms.Timer timerDateTime;
        private Label ClockLabel;
        private OxyPlot.WindowsForms.PlotView pltHomeViewOverall;
    }
}
