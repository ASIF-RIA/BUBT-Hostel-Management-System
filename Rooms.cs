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
    public partial class Rooms : Form
    {
        function fn = new function();
        String query;



        public Rooms()
        {
            InitializeComponent();
        }

        private void Rooms_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469,120);
            LabelRoom.Visible = false;
            LabelRoomExist.Visible = false;

            query = "select* from rooms";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0]; 
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo1.Text != "")
            {
                query = "select * from rooms where roomNo=" + txtRoomNo1.Text + "";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    String status;
                    if (checkBox1.Checked)
                    {
                        status = "Yes";
                    }
                    else
                    {
                        status = "No";
                    }
                    LabelRoomExist.Visible = false;
                    query = "insert into rooms (roomNo, roomStatus) values(" + txtRoomNo1.Text + ", '" + status + "')";
                    fn.setData(query, "Room has been added successfully");
                    Rooms_Load(this, null);
                }
                else
                {
                    LabelRoomExist.Text = "Room already exists";
                    LabelRoomExist.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Fill all empty fields.", "Information!!", MessageBoxButtons.OK);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            String status;
            if (checkBox2.Checked) status = "Yes";
            else status = "No";
            query = "update rooms set roomStatus ='" + status + "' where roomNo="+txtRoomNo2.Text+"";
            fn.setData(query, "Details has been updated.");
            Rooms_Load(this, null);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtRoomNo1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRoomNo2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from rooms where roomNo=" + txtRoomNo2.Text + "";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows.Count == 0)
            {
                LabelRoom.Text = "No room matches";
                LabelRoom.Visible = true;
                checkBox2.Checked = false;

            }
            else
            {
                LabelRoom.Text = "Room has been found";
                LabelRoom.Visible = true;

                if (ds.Tables[0].Rows[0][1].ToString() == "Yes")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }


            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(LabelRoom.Text == "Room has been found")
            {
                query = "delete from rooms where roomNo = " + txtRoomNo2.Text + "";
                fn.setData(query, "Room has been deleted.");
                Rooms_Load(this, null);
            }
           else
            {
                MessageBox.Show("The room doesn't exist", "Eroor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
