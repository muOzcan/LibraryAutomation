using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class UserList : Form
    {
        public UserList()
        {
            InitializeComponent();
        }

        public void List()
        {
            LibraryAutomationEntities db = new LibraryAutomationEntities();
            var users = db.Students.ToList();
            dataGridView1.DataSource = users.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[2].HeaderText = "User Surname";
            dataGridView1.Columns[3].HeaderText = "User Id";
            dataGridView1.Columns[4].HeaderText = "User Tel";
            dataGridView1.Columns[5].HeaderText = "User Mail";
        }

        private void UserList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
