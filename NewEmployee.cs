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
    public partial class NewEmployee : Form
    {
        function fn = new function();
        string query;
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void NewEmployee_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( txtName.Text!= "" && txtAddress.Text!= "" && txtDesignation.Text!="" && txtEmail.Text!="" && txtMobile.Text!="" && txtUniqueId.Text!="")
            {
                Int64 mobile = Int64.Parse(txtMobile.Text);
                string name = txtName.Text;
                string address = txtAddress.Text;
                string email = txtEmail.Text;
                string id = txtUniqueId.Text;
                string designation = txtDesignation.Text;

                query = "insert into newEmployee(emobile, ename, eaddress, eemail, eid, edesignation) values (" + mobile + ",'" + name + "', '" + address + "', '" + email + "', '" + id + "', '" + designation + "')";
                fn.setData(query, "Employee has been registered");
                clearAll();

            }
            else
            {
                MessageBox.Show("Fill all required data.", "Information", MessageBoxButtons.OK);
            }
        } 
        private void clearAll()
        {
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtUniqueId.Clear();
            txtName.Clear();
            txtDesignation.SelectedIndex = -1;
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
