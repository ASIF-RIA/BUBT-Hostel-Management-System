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
    public partial class UpdateDeleteEmployee : Form
    {
        function fn = new function();
        string query;
        public UpdateDeleteEmployee()
        {
            InitializeComponent();
        }

        private void UpdateDeleteEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newEmployee where emobile = " + txtMobile.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtUniqueId.Text = ds.Tables[0].Rows[0][5].ToString();
                comboBoxDesignation.Text = ds.Tables[0].Rows[0][6].ToString();
                comboBoxWorking.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record has been found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string uid = txtUniqueId.Text;
            string workingStatus = comboBoxWorking.Text;
            string designation = comboBoxDesignation.Text;

            query = "update newEmployee set ename = '" + name + "', eemail = '" + email + "', eaddress = '" + address + "', eid ='" + uid + "' ,working = '" + workingStatus + "', edesignation = '" + designation + "' where emobile = " + mobile + " ";
            fn.setData(query, "Data has been updated successfully !");
        }
        private void clearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtName.Clear();
            txtUniqueId.Clear();
            comboBoxDesignation.SelectedIndex = -1;
            comboBoxWorking.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press Yes to confirm deletion.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from newEmployee where emobile = " + txtMobile.Text + "";
                fn.setData(query, "Employee Record has been deleted");
                clearAll();
            }
        }
    }
}
