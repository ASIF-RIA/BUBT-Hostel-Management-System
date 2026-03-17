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
    public partial class NewMeal : Form
    {
        function fn = new function();
        string query;
        public NewMeal()
        {
            InitializeComponent();
        }

        private void NewMeal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mealName = txtName.Text;                 
            string mealTime = comboBoxTime.Text;                 
            string mealDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            float price = float.Parse(txtPrice.Text);               
            string notes = txtNotes.Text.Trim();      

                
                string insertQuery;
                if (string.IsNullOrEmpty(notes))
                {
                    insertQuery = "INSERT INTO MealPlans (MealName, MealTime, MealDate, Price) " +
                                  "VALUES ('" + mealName + "', '" + mealTime + "', '" + mealDate + "', " + price + ")";
                }
                else 
                {
                    insertQuery = "INSERT INTO MealPlans (MealName, MealTime, MealDate, Price, Description) " +
                                  "VALUES ('" + mealName + "', '" + mealTime + "', '" + mealDate + "', " + price + ", '" + notes + "')";
                }

                fn.setData(insertQuery, "Meal plan has been added successfully.");
                ClearAll();

               
            
           
        }

        private void txtNotes_TextChanged(object sender, EventArgs e)
        {

        }
        public void ClearAll()
        {
            txtName.Clear();
            txtNotes.Clear();
            txtPrice.Clear();
            comboBoxTime.SelectedIndex = -1;
            dateTimePicker.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
