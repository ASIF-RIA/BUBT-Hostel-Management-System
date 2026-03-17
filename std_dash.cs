using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System__2_
{
    public partial class std_dash : Form
    {
        public std_dash()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnRooms_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp_dash ds = new emp_dash();
            ds.Show();
        }

        private void btnRooms_Click_1(object sender, EventArgs e)
        {
            Rooms anr = new Rooms();
            anr.Show();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();  
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            StudentList sl = new StudentList();
            sl.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            vacatedStudent vs = new vacatedStudent();   
            vs.Show();
        }

        private void guna2GradientCircleButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            chs_dash cd = new chs_dash();
            cd.Show();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.WindowState = FormWindowState.Minimized;
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
