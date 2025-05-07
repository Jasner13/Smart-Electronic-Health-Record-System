using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Forms;

namespace SEHRS
{
    public partial class DashboardForm : BaseForm
    {



       
        private Button activeButton;
        private Button lastActiveMainMenuButton = null;
        private int borderSize = 2;
        private Size formSize;
        private System.Windows.Forms.Timer submenuTimer;
        private Panel activeSubMenu;
        private int submenuTargetHeight;
        private bool expanding;
        public DashboardForm()
        {
            InitializeComponent();
            InitializeBaseForm();
            

            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            pnlInventory.Visible = false;

            
            AdjustForm();

            submenuTimer = new System.Windows.Forms.Timer();
            submenuTimer.Interval = 10; 
            submenuTimer.Tick += SubmenuTimer_Tick;
            
            HomeControl homeControl = new HomeControl();
            homeControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(homeControl);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020;
            const int SC_RESTORE = 0xF120; 
            const int WM_NCHITTEST = 0x0084;
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            
            if (m.Msg == WM_SYSCOMMAND)
            {
        /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
               
               
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void DashboardForm_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: 
                    this.Padding = new Padding(8, 8, 8, 8);
                    break;
                case FormWindowState.Normal: 
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void CollapseMenu()
        {
            if (this.panelMenu.Width > 200) 
            {
                panelMenu.Width = 120;
                pictureBox1.Visible = false;
                btnMenu.Dock = DockStyle.Top;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                    menuButton.Padding = new Padding(0);
                }

                
                btnExit.Visible = false;

              
                HideAllSubMenus();
            }
            else
            { 

                panelMenu.Width = 209;
                pictureBox1.Visible = true;
                btnMenu.Dock = DockStyle.None;
                foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "   " + menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                    menuButton.Padding = new Padding(10, 0, 0, 0);
                }

                
                btnExit.Visible = true;
            }
        }

        private void HideAllSubMenus()
        {
            pnlPatient.Height = 0;
            pnlPatient.Visible = false;
            pnlInventory.Height = 0;
            pnlInventory.Visible = false;
        }
        private void SubmenuTimer_Tick(object sender, EventArgs e)
        {
            if (expanding)
            {
                if (activeSubMenu.Height < submenuTargetHeight)
                {
                    activeSubMenu.Height += 10; 
                }
                else
                {
                    submenuTimer.Stop();
                }
            }
            else
            {
                if (activeSubMenu.Height > 0)
                {
                    activeSubMenu.Height -= 10; 
                }
                else
                {
                    submenuTimer.Stop();
                    activeSubMenu.Visible = false; 
                }
            }
        }

        private void ToggleSubMenu(Panel submenu, Button mainButton, 
        Dictionary<Button, string> fullTexts, Dictionary<Button, string> shortTexts)
        {
            if (submenu == activeSubMenu && submenu.Height > 0) 
            {
                expanding = false;
            }
            else
            {
                HideAllSubMenus();
                activeSubMenu = submenu;
                submenu.Visible = true;
                submenu.Height = 0;
                
                if(submenu == pnlPatient)
                    submenuTargetHeight = 150; 
                else if (submenu == pnlInventory)
                    submenuTargetHeight = 100; 
                expanding = true;

                // Check if the menu is collapsed
                bool isMenuCollapsed = panelMenu.Width <= 100;

                // Update submenu button text based on menu state
                foreach (var button in submenu.Controls.OfType<Button>())
                {
                    button.Text = isMenuCollapsed ? shortTexts[button] : fullTexts[button];
                }
            }

            submenuTimer.Start();
        }


        private void ActivateMainMenuButton(Button clickedButton)
        {
            // Reset previous main menu button color
            if (lastActiveMainMenuButton != null && lastActiveMainMenuButton != clickedButton)
            {
                lastActiveMainMenuButton.BackColor = Color.White; 
                lastActiveMainMenuButton.ForeColor = Color.Black;
            }

            // Set the clicked button new active color
            clickedButton.BackColor = Color.FromArgb(196, 209, 235);
            clickedButton.ForeColor = Color.Black;

            // Store the new active main menu button
            lastActiveMainMenuButton = clickedButton;
        }






        private void btnPatient_Click(object sender, EventArgs e)
        {
            // Defining the full and short text for submenu buttons
            Dictionary<Button, string> fullTexts = new Dictionary<Button, string>
    {
        { btnNewPatient, "New Patient" },
        { btnManagePatient, "Manage Patient" },
        { btnNotifyPatients, "Notify Patients" },
    };
            Dictionary<Button, string> shortTexts = new Dictionary<Button, string>
    {
        { btnNewPatient, "New" },
        { btnManagePatient, "Manage" },
        { btnNotifyPatients, "Notify" }

    };


            ToggleSubMenu(pnlPatient, (Button)sender, fullTexts, shortTexts);
            ActivateMainMenuButton((Button)sender);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Clear the content panel and load HomeControl
            pnlContent.Controls.Clear();
            HomeControl homeControl = new HomeControl();
            homeControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(homeControl);
            HideAllSubMenus();
            ActivateMainMenuButton((Button)sender);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {           
            // Define full and short texts 
            Dictionary<Button, string> fullTexts = new Dictionary<Button, string>
            {
                { btnNewDrug, "New Drug" },
                { btnManageInventory, "Manage Inventory" }
            };

            Dictionary<Button, string> shortTexts = new Dictionary<Button, string>
            {
                { btnNewDrug, "New" },
                { btnManageInventory, "Manage" }
            };

            ToggleSubMenu(pnlInventory, (Button)sender, fullTexts, shortTexts);
            ActivateMainMenuButton((Button)sender);
        }

        private void btnAnalytics_Click(object sender, EventArgs e)
        {

            pnlContent.Controls.Clear();
            FilterAnalyticsControl filterAnalyticsControl = new FilterAnalyticsControl();
            filterAnalyticsControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(filterAnalyticsControl);
           
            ActivateMainMenuButton((Button)sender);
            HideAllSubMenus();
        }

        private void btnNewPatient_CLick(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();

            
            NewPatientControl newPatientControl = new NewPatientControl();

            
            newPatientControl.Dock = DockStyle.Fill;

           
            pnlContent.Controls.Add(newPatientControl);
        }

        private void btnManagePatient_Click(object sender, EventArgs e)
        {
            
            foreach (Control control in pnlContent.Controls)
            {
                control.Dispose();
            }

            pnlContent.Controls.Clear(); // Remove all controls

            
            ManagePatientsControl viewPatientControl = new ManagePatientsControl();
            viewPatientControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(viewPatientControl);
        }

        private void btnNotifyPatients_Click(object sender, EventArgs e)
        {
            foreach(Control control in pnlContent.Controls)
            {
                control.Dispose();
            }
            NotifyPatientsControl viewPatientControl = new NotifyPatientsControl();
            viewPatientControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(viewPatientControl);
        }
        private void btmNewDrug_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            NewDrugControl newDrugControl = new NewDrugControl();
            newDrugControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(newDrugControl);
        }


        private void btnManageInventory_Click(object sender, EventArgs e)
        {

            pnlContent.Controls.Clear();
            ManageInventoryControl viewInventoryControl = new ManageInventoryControl();
            viewInventoryControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(viewInventoryControl);

        }
        private void btnGenerateData_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            FilterAnalyticsControl filterAnalyticsControl = new FilterAnalyticsControl();
            filterAnalyticsControl.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(filterAnalyticsControl);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
            Application.Exit();
        }
        private void DashboardForm_Load(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
        private void panelTitleBar_Paint(object sender, PaintEventArgs e) { }
        private void pnlPatient_Paint(object sender, PaintEventArgs e) { }
        private void pnlInventory_Paint(object sender, PaintEventArgs e) { }

        private void pnlContent_Paint(object sender, PaintEventArgs e) { }
    }
}