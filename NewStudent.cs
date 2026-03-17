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
    public partial class NewStudent : Form
    {
        function fn = new function();
        string query;
        public NewStudent()
        {
            InitializeComponent();
        }

        private void NewStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            query = "select roomNo from rooms where roomStatus = 'Yes' and Booked = 'No'";
            DataSet ds = fn.getData(query);
            
            for(int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Int64 room = Int64.Parse(ds.Tables[0].Rows[i][0].ToString());
                comboRoomNo.Items.Add(room);
            }

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtName.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtUid.Clear();
            txtMobile.Clear();
            comboRoomNo.SelectedIndex = -1; 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtAddress.Text != "" && txtEmail.Text != "" && txtMobile.Text != "" && txtName.Text != "" && txtUid.Text != "" && comboRoomNo.SelectedIndex != -1) { 

            Int64 mobile = Int64.Parse(txtMobile.Text);
            string name = txtName.Text;
            string email = txtEmail.Text;
            string address = txtAddress.Text;
            string uid = txtUid.Text;
            Int64 roomNo = Int64.Parse(comboRoomNo.Text);

            query = "insert into newStudent (mobile,name,email,address,uid,roomNo) values (" + mobile + ",'" + name + "','" + email + "','" + address + "','" + uid + "'," + roomNo + ") update rooms set Booked = 'Yes' where roomNo = " + roomNo + "";
            fn.setData(query, "Student has been Registered");
            clearAll();
        }
            else
            {
                MessageBox.Show("Fill all empty fields.","Information!!", MessageBoxButtons.OK);
            }

        }

        private void comboRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
