using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMS_CrashCourse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelpop.Height = btnDashboard.Height;
            panelpop.Top = btnDashboard.Top;
            customer1.Visible = false;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelpop.Height = btnDashboard.Height;
            panelpop.Top = btnDashboard.Top;
            customer1.Visible = false;
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            panelpop.Height = btnCustomer.Height;
            panelpop.Top = btnCustomer.Top;
            customer1.Visible = true;
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            panelpop.Height = btnVideo.Height;
            panelpop.Top = btnVideo.Top;
            customer1.Visible = false;
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            panelpop.Height = btnRental.Height;
            panelpop.Top = btnRental.Top;
            customer1.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
