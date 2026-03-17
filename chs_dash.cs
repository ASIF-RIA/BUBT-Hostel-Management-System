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
    public partial class chs_dash : Form
    {
        public chs_dash()
        {
            InitializeComponent();
        }

     


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.Hide();
            std_dash ds = new std_dash();
            ds.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            emp_dash ds = new emp_dash();
            ds.Show();
        }

        private void chs_dash_Load(object sender, EventArgs e)
        {

        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            inventory_dash id = new inventory_dash();
            id.Show();
        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
