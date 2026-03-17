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
    public partial class emp_dash : Form
    {
        public emp_dash()
        {
            InitializeComponent();
        }

        private void emp_dash_Load(object sender, EventArgs e)
        {

        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {  
            this.Hide();
            chs_dash cd = new chs_dash();
            cd.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewEmployee newEmployee = new NewEmployee();    
            newEmployee.Show();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            UpdateDeleteEmployee ude = new UpdateDeleteEmployee();
            ude.Show(); 
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            EmployeePayment ep = new EmployeePayment();
            ep.Show();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            employeeWorking ew = new employeeWorking();
            ew.Show();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            vacatedEmployee ve = new vacatedEmployee();
            ve.Show();
        }

        private void minus_Click(object sender, EventArgs e)
        {
            foreach (Form f in Application.OpenForms)
            {
                f.WindowState = FormWindowState.Minimized;
            }

        }
    }
}
