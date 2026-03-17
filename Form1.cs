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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void log_in_click(object sender, EventArgs e)
        {
            if(txtUsername.Text=="" && txtPassword.Text== "")
            {   
                this.Hide();
                chs_dash ds = new chs_dash();
                ds.Show();
            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Wrong Credentials.", "Error!!", MessageBoxButtons.OK);
                

            }
        }


        private void password(object sender, EventArgs e)
        {

        }

        private void username(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
