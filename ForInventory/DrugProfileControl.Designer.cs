namespace SEHRS
{
    partial class DrugProfileControl
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
            pnlDrugProfile = new Panel();
            lblQuantity = new Label();
            lblexpDate = new Label();
            lbldrgID = new Label();
            lbldrgName = new Label();
            picDrugDynamicProfile = new PictureBox();
            pnlDrugProfile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDrugDynamicProfile).BeginInit();
            SuspendLayout();
            // 
            // pnlDrugProfile
            // 
            pnlDrugProfile.BackColor = Color.White;
            pnlDrugProfile.Controls.Add(lblQuantity);
            pnlDrugProfile.Controls.Add(lblexpDate);
            pnlDrugProfile.Controls.Add(lbldrgID);
            pnlDrugProfile.Controls.Add(lbldrgName);
            pnlDrugProfile.Controls.Add(picDrugDynamicProfile);
            pnlDrugProfile.Dock = DockStyle.Fill;
            pnlDrugProfile.Location = new Point(0, 0);
            pnlDrugProfile.Name = "pnlDrugProfile";
            pnlDrugProfile.Size = new Size(218, 108);
            pnlDrugProfile.TabIndex = 0;
            pnlDrugProfile.DoubleClick += pnlDrugProfile_DoubleClick;
            pnlDrugProfile.MouseDoubleClick += pnlDrugProfile_MouseDoubleClick;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblQuantity.ForeColor = Color.Gray;
            lblQuantity.Location = new Point(80, 58);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(63, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quanity:";
            // 
            // lblexpDate
            // 
            lblexpDate.AutoSize = true;
            lblexpDate.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblexpDate.ForeColor = Color.Gray;
            lblexpDate.Location = new Point(80, 38);
            lblexpDate.Name = "lblexpDate";
            lblexpDate.Size = new Size(66, 20);
            lblexpDate.TabIndex = 3;
            lblexpDate.Text = "Exp date:";
            lblexpDate.Click += lblexpDate_Click;
            // 
            // lbldrgID
            // 
            lbldrgID.AutoSize = true;
            lbldrgID.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lbldrgID.ForeColor = Color.Gray;
            lbldrgID.Location = new Point(10, 73);
            lbldrgID.Name = "lbldrgID";
            lbldrgID.Size = new Size(27, 20);
            lbldrgID.TabIndex = 2;
            lbldrgID.Text = "ID:";
            // 
            // lbldrgName
            // 
            lbldrgName.AutoSize = true;
            lbldrgName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldrgName.ForeColor = Color.FromArgb(64, 64, 64);
            lbldrgName.Location = new Point(76, 10);
            lbldrgName.Name = "lbldrgName";
            lbldrgName.Size = new Size(121, 28);
            lbldrgName.TabIndex = 1;
            lbldrgName.Text = "Drug Name";
            // 
            // picDrugDynamicProfile
            // 
            picDrugDynamicProfile.BackColor = Color.ForestGreen;
            picDrugDynamicProfile.ErrorImage = null;
            picDrugDynamicProfile.InitialImage = null;
            picDrugDynamicProfile.Location = new Point(10, 10);
            picDrugDynamicProfile.Name = "picDrugDynamicProfile";
            picDrugDynamicProfile.Size = new Size(60, 60);
            picDrugDynamicProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            picDrugDynamicProfile.TabIndex = 0;
            picDrugDynamicProfile.TabStop = false;
            picDrugDynamicProfile.Click += picDrugDynamicProfile_Click;
            // 
            // DrugProfileControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlDrugProfile);
            Name = "DrugProfileControl";
            Size = new Size(218, 108);
            pnlDrugProfile.ResumeLayout(false);
            pnlDrugProfile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picDrugDynamicProfile).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDrugProfile;
        private Label lblexpDate;
        private Label lbldrgID;
        private Label lbldrgName;
        private PictureBox picDrugDynamicProfile;
        private Label lblQuantity;
    }
}