using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hostel_Management_System__2_
{
    public partial class NewItem : Form
    {
        function fn = new function();
        string query;
        public NewItem()
        {
            InitializeComponent();
        }

        private void NewItem_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            query = "select* from Items";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            query = "select * from Items where ItemName= '" + txtName.Text + "' ";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                string name = txtName.Text;
                double quantity = Convert.ToDouble(txtQuantity.Text);
                double threshold = Convert.ToDouble(txtThreshold.Text);
                string unit = txtUnit.Text;

                query = "insert into Items (ItemName, Quantity, Unit, Threshold) values('" + name + "'," + quantity + ",'" + unit + "'," + threshold + ")";
                fn.setData(query,"The item has been added successfully");
                NewItem_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("This item already exists", "Information!!", MessageBoxButtons.OK);
                clearAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtQuantity.Clear();
            txtThreshold.Clear();
            txtUnit.Clear();
        }
    }
}
