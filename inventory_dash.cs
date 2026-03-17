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
    public partial class inventory_dash : Form
    {
        public inventory_dash()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            NewItem ni = new NewItem();
            ni.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            UpdateItem ui = new UpdateItem();
            ui.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShoppingList sl = new ShoppingList();
            sl.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            NewMeal nm = new NewMeal();
            nm.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateMeal um = new UpdateMeal();
            um.Show();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MealCalendar mc = new MealCalendar();
            mc.Show();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            chs_dash cd = new chs_dash();
            cd.Show();
           // CloseOtherForms();
            
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
