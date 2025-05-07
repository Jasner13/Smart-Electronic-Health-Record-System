using System.Drawing;
using System.Windows.Forms;

namespace SEHRS
{
    public class BaseForm : Form
    {
        
       
        protected int BorderSize { get; set; } = 2;

        
        protected void ShowError(string message, string title = "Error")
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Common form initialization
        protected void InitializeBaseForm()
        {
            this.DoubleBuffered = true; 
            this.StartPosition = FormStartPosition.CenterScreen;
           // this.BackColor = Color.Beige; // Standard border color
            this.Padding = new Padding(BorderSize);
        }
    }
}