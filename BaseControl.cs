using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEHRS
{

    public class BaseControl : UserControl
    {
        // Shared Properties
        protected int CornerRadius { get; set; } = 20;

        // Standardized Error Handling
        protected void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Rounded Corners (Reusable)
        protected void ApplyRoundedCorners()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90); // Top-left
            path.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90); // Top-right
            path.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90); // Bottom-right
            path.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90); // Bottom-left
            path.CloseFigure();
            this.Region = new Region(path);
        }

        // Template Method for Loading Data
        public virtual void LoadData()
        {
            // To be overridden by child controls
        }
    }
}