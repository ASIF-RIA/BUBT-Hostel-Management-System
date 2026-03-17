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
    public partial class vacatedStudent : Form
    {
        function fn = new function();
        string query;
        public vacatedStudent()
        {
            InitializeComponent();
        }

        private void vacatedStudent_Load(object sender, EventArgs e)
        {
            this.Location = new Point(469, 120);
            query = "select* from newStudent where living = 'No'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
