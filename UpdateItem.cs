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
using System.Xml.Linq;

namespace Hostel_Management_System__2_
{
    public partial class UpdateItem : Form
    {
        function fn = new function();
        string query;
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            query = "select ItemName from Items ";
            string query1 = "select* from Items";
            DataSet ds = fn.getData(query);
            DataSet ds1 = fn.getData(query1);
            dataGridView1.DataSource = ds1.Tables[0];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string name = ds.Tables[0].Rows[i][0].ToString();
                comboName.Items.Add(name);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = comboName.Text; 
            double changeValue = Convert.ToDouble(txtQuantity.Text); 

            query = "UPDATE Items SET Quantity = Quantity + " + changeValue + " WHERE ItemName = '" + name + "'";
            fn.setData(query, "The item's quantity has been updated successfully.");
            UpdateItem_Load(this, null); 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            string name = comboName.Text;
            double changeValue = Convert.ToDouble(txtQuantity.Text); 


            query = "SELECT Quantity FROM Items WHERE ItemName = '" + name + "'";
            DataSet ds = fn.getData(query);

                double currentQuantity = Convert.ToDouble(ds.Tables[0].Rows[0]["Quantity"]);

                if (currentQuantity - changeValue < 0)
                {
                    MessageBox.Show("Insufficient stock. The operation cannot be completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearAll();
                }
                else
                {
                    query = "UPDATE Items SET Quantity = Quantity - " + changeValue + " WHERE ItemName = '" + name + "'";
                    fn.setData(query, "The item's quantity has been updated successfully.");
                    UpdateItem_Load(this, null); 
                    clearAll() ;
                }
            }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string name = comboName.Text;
            double threshold = Convert.ToDouble(txtThreshold.Text);

            query = "UPDATE Items SET Threshold = " + threshold + " WHERE ItemName = '" + name + "'";
            fn.setData(query, "The item's threshold has been updated successfully.");
            UpdateItem_Load(this, null);
            clearAll();
        }
        public void clearAll()
        {
            txtThreshold.Clear();
            txtQuantity.Clear();
            comboName.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = comboName.Text;


            query = "select Quantity from Items WHERE ItemName = '" + name + "'";


            DataSet ds = fn.getData(query);



            if (ds.Tables[0].Rows.Count != 0)
            {
                txtQuantity.Text = ds.Tables[0].Rows[0][0].ToString();
            }


        }
    }
 }

