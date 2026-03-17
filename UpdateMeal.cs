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
    public partial class UpdateMeal : Form
    {
        function fn = new function();
        string query;
        public UpdateMeal()
        {
            InitializeComponent();
        }

        private void UpdateMeal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            dateTimePicker.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string mealTime = comboBoxTime.Text;
            string mealDate = dateTimePicker.Value.ToString("yyyy-MM-dd");


            query = "SELECT * FROM MealPlans WHERE MealDate = '" + mealDate + "' AND MealTime = '" + mealTime + "'";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                query = "SELECT* FROM MealPlans WHERE MealDate = '" + mealDate + "' AND MealTime = '" + mealTime + "' ";
                DataSet ds1 = fn.getData(query);
                dataGridView1.DataSource = ds1.Tables[0];

            }
            else
            {
                ClearAll();
                MessageBox.Show("No Record Shas been found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mealName = txtName.Text;
            string mealTime = comboBoxTime.Text;
            string mealDate = dateTimePicker.Value.ToString("yyyy-MM-dd");
            float price = float.Parse(txtPrice.Text);
            string notes = txtNotes.Text.Trim();
            Int64 id = Int64.Parse(txtID.Text);

            string updateQuery;
                if (string.IsNullOrEmpty(notes))
                {
                        updateQuery = "UPDATE MealPlans SET MealName = '" + mealName + "', Price = " + price + " WHERE MealDate = '" + mealDate + "' AND MealTime = '" + mealTime + "' AND MealID = "+id+"";
                }
                else
                {
                       updateQuery = "UPDATE MealPlans " +
                       "SET MealName = '" + mealName + "', Price = " + price + ", Description = '" + notes + "' AND MealID = "+id+" " +
                       "WHERE MealDate = '" + mealDate + "' AND MealTime = '" + mealTime + "'";
                }

                fn.setData(updateQuery, "Meal plan has been updated successfully.");
                UpdateMeal_Load(this, null);
                ClearAll();
        }

        private void comboBoxTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press Yes to confirm deletion.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Int64 id = Int64.Parse(txtID.Text);
                query = "delete from MealPlans where MealID = " + id + "";
                fn.setData(query, "Meal Record has been deleted");
                ClearAll();
            }
        }
        public void ClearAll()
        {
            txtName.Clear();
            txtNotes.Clear();
            txtPrice.Clear();
            txtID.Clear();
            comboBoxTime.SelectedIndex = -1;
            dateTimePicker.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
}
