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
    public partial class UpdateDeleteStudent : Form
    {
        function fn = new function();
        string query;

        public UpdateDeleteStudent()
        {
            InitializeComponent();
        }

        private void UpdateDeleteStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel8_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void txtUid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        private void clearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();  
            txtMobile.Clear();
            txtName.Clear();    
            txtRoomNo.Clear();
            txtUid.Clear();
            comboBoxLiving.SelectedIndex = -1;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from newStudent where mobile = "+txtMobile.Text+"";
            DataSet ds = fn.getData(query);

            if(ds.Tables[0].Rows.Count != 0)
            {
                txtName.Text = ds.Tables[0].Rows[0][2].ToString();
                txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
                txtAddress.Text = ds.Tables[0].Rows[0][4].ToString();
                txtUid.Text = ds.Tables[0].Rows[0][5].ToString();
                txtRoomNo.Text = ds.Tables[0].Rows[0][6].ToString();
                comboBoxLiving.Text = ds.Tables[0].Rows[0][7].ToString();
            }
            else
            {
                clearAll();
                MessageBox.Show("No Record has been found","Information",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Int64 mobile = Int64.Parse(txtMobile.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string uid = txtUid.Text;
            Int64 roomNo = Int64.Parse(txtRoomNo.Text);
            string livingStatus = comboBoxLiving.Text;

            query = "update newStudent set name = '"+name+"', email = '"+email+"', address = '"+address+"', uid ='"+uid+"',roomNo = "+roomNo+",living = '"+livingStatus+"' where mobile = "+mobile+" update rooms set Booked = '"+livingStatus+"' where roomNo = "+roomNo+" ";
            fn.setData(query, "Data has been updated successfully !");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Press Yes to confirm deletion.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Int64 roomNo = Int64.Parse(txtRoomNo.Text);
                query = "delete from newStudent where mobile = " + txtMobile.Text + " update rooms set Booked = 'No' where roomNo = "+roomNo+"";
                fn.setData(query, "Student Record has been deleted");
                clearAll();
            }
        }

        private void comboBoxLiving_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
