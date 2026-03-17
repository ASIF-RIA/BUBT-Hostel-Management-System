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
    public partial class EmployeePayment : Form
    {
        function fn = new function();
        string query;
        public EmployeePayment()
        {
            InitializeComponent();
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void EmployeePayment_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
                query = "select ename, eid from newEmployee where emobile = " + txtMobile.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtUniqueId.Text = ds.Tables[0].Rows[0][1].ToString();

                    query = "select * from employeeSalary where emobile = " + txtMobile.Text + " ";
                    DataSet ds2 = fn.getData(query);
                    dataGridView1.DataSource = ds2.Tables[0];

                }
                else
                {
                    MessageBox.Show("No Record Exists", "Error", MessageBoxButtons.OK);
                }
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "select * from employeeSalary where emobile = " + Int64.Parse(txtMobile.Text) + " and fmonth = '" + dateTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    Int64 mobile = Int64.Parse(txtMobile.Text);
                    string month = dateTimePicker.Text;
                    Int64 amount = Int64.Parse(txtAmount.Text);

                    query = "insert into employeeSalary values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Fees Paid");

                    query = "select * from employeeSalary where emobile = " + txtMobile.Text + " ";
                    DataSet ds2 = fn.getData(query);
                    dataGridView1.DataSource = ds2.Tables[0];


                }
                else
                {
                    MessageBox.Show("No dues of " + dateTimePicker.Text + " left", "Information", MessageBoxButtons.OK);
                }
            }
        }
        public void ClearAll()
        {
            txtAmount.Clear();
            txtMobile.Clear();  
            txtName.Clear();
            txtUniqueId.Clear();
            dataGridView1.DataSource = 0;
            dateTimePicker.ResetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }
    }
    
}
