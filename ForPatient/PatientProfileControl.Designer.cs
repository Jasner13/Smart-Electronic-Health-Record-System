namespace SEHRS
{
    partial class PatientProfileControl
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
            pnlPatientProfile = new Panel();
            lblID = new Label();
            lblBirthDate = new Label();
            lblName = new Label();
            picPatientDynamicProfile = new PictureBox();
            pnlPatientProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPatientDynamicProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlPatientProfile
            // 
            pnlPatientProfile.BackColor = Color.White;
            pnlPatientProfile.Controls.Add(lblID);
            pnlPatientProfile.Controls.Add(lblBirthDate);
            pnlPatientProfile.Controls.Add(lblName);
            pnlPatientProfile.Controls.Add(picPatientDynamicProfile);
            pnlPatientProfile.Dock = DockStyle.Fill;
            pnlPatientProfile.Location = new Point(0, 0);
            pnlPatientProfile.Name = "pnlPatientProfile";
            pnlPatientProfile.Size = new Size(218, 108);
            pnlPatientProfile.TabIndex = 0;
            pnlPatientProfile.Paint += panelContainer_Paint;
            pnlPatientProfile.DoubleClick += pnlPatientProfile_DoubleClick;
            pnlPatientProfile.MouseDoubleClick += pnlPatientProfile_MouseDoubleClick;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblID.ForeColor = Color.Gray;
            lblID.Location = new Point(10, 78);
            lblID.Name = "lblID";
            lblID.Size = new Size(27, 20);
            lblID.TabIndex = 3;
            lblID.Text = "ID:";
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblBirthDate.ForeColor = Color.Gray;
            lblBirthDate.Location = new Point(80, 46);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(43, 20);
            lblBirthDate.TabIndex = 2;
            lblBirthDate.Text = "DOB:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = Color.FromArgb(64, 64, 64);
            lblName.Location = new Point(80, 10);
            lblName.Name = "lblName";
            lblName.Size = new Size(57, 23);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            lblName.Click += lblName_Click;
            // 
            // picPatientDynamicProfile
            // 
            picPatientDynamicProfile.BackColor = Color.DarkOrange;
            picPatientDynamicProfile.ErrorImage = null;
            picPatientDynamicProfile.InitialImage = null;
            picPatientDynamicProfile.Location = new Point(10, 10);
            picPatientDynamicProfile.Name = "picPatientDynamicProfile";
            picPatientDynamicProfile.Size = new Size(60, 60);
            picPatientDynamicProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picPatientDynamicProfile.TabIndex = 0;
            picPatientDynamicProfile.TabStop = false;
            picPatientDynamicProfile.Click += picPatientDynamicProfile_Click;
            // 
            // PatientProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlPatientProfile);
            Name = "PatientProfileControl";
            Size = new Size(218, 108);
            pnlPatientProfile.ResumeLayout(false);
            pnlPatientProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picPatientDynamicProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlPatientProfile;
        private Label lblID;
        private Label lblBirthDate;
        private Label lblName;
        private PictureBox picPatientDynamicProfile;
    }
}