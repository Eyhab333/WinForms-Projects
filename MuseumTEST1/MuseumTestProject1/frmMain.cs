using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseumTestProject1.People;
using System.Runtime.InteropServices;
using MuseumTestProject1.Dashboard;
using MuseumTestProject1.HistoricalPieces;
using MuseumTestProject1.VisitHistory;
using MuseumTestProject1.Settings;
using MuseumTestProject1.Employees;


namespace MuseumTestProject1
{
    public partial class frmMain : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]// code to make the form corners rounded
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public frmMain()
        {
            InitializeComponent();

            // code to make the form corners rounded
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(27, 43, 50);


            lblTitle.Text = "لوحة التحكم";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard_Vrb = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard_Vrb);
            FrmDashboard_Vrb.Show();
        }

        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmListPeople();
            frm.ShowDialog();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMainScreen_Click(object sender, EventArgs e)
        {
            //this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(27, 43, 50);


            lblTitle.Text = "لوحة التحكم";
            this.pnlFormLoader.Controls.Clear();
            frmDashboard FrmDashboard = new frmDashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmDashboard.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmDashboard);
            FrmDashboard.Show();
        }

        private void btnHistoricalPeices_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnHistoricalPeices.Height;
            pnlNav.Top = btnHistoricalPeices.Top;
            pnlNav.Left = btnHistoricalPeices.Left;
            btnHistoricalPeices.BackColor = Color.FromArgb(27, 43, 50);

            lblTitle.Text = "القطع التراثـية";
            this.pnlFormLoader.Controls.Clear();
            frmHistoricalPieces FrmHistoricalPieces = new frmHistoricalPieces() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmHistoricalPieces.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmHistoricalPieces);
            FrmHistoricalPieces.Show();
        }

        private void btnVisitsHistory_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnVisitsHistory.Height;
            pnlNav.Top = btnVisitsHistory.Top;
            pnlNav.Left = btnVisitsHistory.Left;
            btnVisitsHistory.BackColor = Color.FromArgb(27, 43, 50);

            lblTitle.Text = "سجل الزيارات";
            this.pnlFormLoader.Controls.Clear();
            frmVisitHistory FrmVisitHistory = new frmVisitHistory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmVisitHistory.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmVisitHistory);
            FrmVisitHistory.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnSettings.Height;
            pnlNav.Top = btnSettings.Top;
            pnlNav.Left = btnSettings.Left;
            btnSettings.BackColor = Color.FromArgb(27, 43, 50);

            lblTitle.Text = "الاعدادات";
            this.pnlFormLoader.Controls.Clear();
            frmSettings FrmSettings  = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSettings.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmSettings);
            FrmSettings.Show();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnEmployees.Height;
            pnlNav.Top = btnEmployees.Top;
            pnlNav.Left = btnEmployees.Left;
            btnEmployees.BackColor = Color.FromArgb(27, 43, 50);

            lblTitle.Text = "إدارة المتحف";
            this.pnlFormLoader.Controls.Clear();
            frmEmployees FrmEmployees = new frmEmployees() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmEmployees.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(FrmEmployees);
            FrmEmployees.Show();
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(7, 43, 71);
        }

        private void btnHistoricalPeices_Leave(object sender, EventArgs e)
        {
            btnHistoricalPeices.BackColor = Color.FromArgb(7, 43, 71);

        }

        private void btnVisitsHistory_Leave(object sender, EventArgs e)
        {
            btnVisitsHistory.BackColor = Color.FromArgb(7, 43, 71);

        }

        private void btnSettings_Leave(object sender, EventArgs e)
        {
            btnSettings.BackColor = Color.FromArgb(7, 43, 71);//7; 43; 71

        }

        private void btnEmployees_Leave(object sender, EventArgs e)
        {
            btnEmployees.BackColor = Color.FromArgb(7, 43, 71);//7; 43; 71

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
