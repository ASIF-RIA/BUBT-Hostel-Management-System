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
    public partial class StudentFees : Form
    {
        function fn = new function();
        string query;

        public StudentFees()
        {
            InitializeComponent();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "")
            {
               query = "select name, roomNo from newStudent where mobile = "+txtMobile.Text+"";
               DataSet ds = fn.getData(query);

               if(ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][1].ToString();

                    query = "select * from fees where mobileNo = " + txtMobile.Text + " ";
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
            if(txtMobile.Text != "" && txtAmount.Text != "")
            {
                Int64 aamount = Int64.Parse(txtAmount.Text);
                if (aamount == 4000)
                {
                    query = "select * from fees where mobileNo = " + Int64.Parse(txtMobile.Text) + " and fmonth = '" + dateTimePicker.Text + "'";
                    DataSet ds = fn.getData(query);
                    if (ds.Tables[0].Rows.Count == 0)
                    {
                        Int64 mobile = Int64.Parse(txtMobile.Text);
                        string month = dateTimePicker.Text;
                        Int64 amount = Int64.Parse(txtAmount.Text);

                        query = "insert into fees values(" + mobile + ",'" + month + "'," + amount + ")";
                        fn.setData(query, "Fees Paid");
                    }
                    else
                    {
                        MessageBox.Show("No dues of " + dateTimePicker.Text + " left", "Information", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Monthly Fee is 4000 bdt per month", "Information!!", MessageBoxButtons.OK);
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtAmount.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtRoomNo.Clear();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
