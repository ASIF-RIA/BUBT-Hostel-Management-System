using System;
using System.Collections;
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
    public partial class MealCalendar : Form
    {
        function fn = new function();
        string query1, query2, query3;
        public MealCalendar()
        {
            InitializeComponent();
        }

        private void MealCalendar_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            dateTimePicker.Value = DateTime.Now;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mealDate = dateTimePicker.Value.ToString("yyyy-MM-dd");

            query1 = "select MealName, Price from MealPlans where MealTime = 'Breakfast' AND MealDate = '"+mealDate+"'";
            DataSet ds1 = fn.getData(query1);
            dataGridView1.DataSource = ds1.Tables[0];

            query2 = "select MealName, Price from MealPlans where MealTime = 'Lunch' AND MealDate = '"+mealDate+"' ";
            DataSet ds2 = fn.getData(query2);
            dataGridView2.DataSource = ds2.Tables[0];

            query3 = "select MealName, Price from MealPlans where MealTime = 'Dinner' AND MealDate = '"+mealDate+"' ";
            DataSet ds3 = fn.getData(query3);
            dataGridView3.DataSource = ds3.Tables[0];

        }
    }
}
