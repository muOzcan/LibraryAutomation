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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }

        private LibraryAutomationEntities db = new LibraryAutomationEntities();

      

        public void List()
        {
            var users = db.Students.ToList();
            dataGridView1.DataSource = users;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[2].HeaderText = "User Surname";
            dataGridView1.Columns[3].HeaderText = "User Id";
            dataGridView1.Columns[4].HeaderText = "User Tel";
            dataGridView1.Columns[5].HeaderText = "User Mail";
        }
        private void UserAdd_Load(object sender, EventArgs e)
        {
            List();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            Students student = new Students();
            student.user_name = nameTxt.Text;
            student.user_surname = surnameTxt.Text;
            student.user_tc = idTxt.Text;
            student.user_tel = telTxt.Text;
            student.user_mail = mailTxt.Text;

            db.Students.Add(student);
            db.SaveChanges();
            List();
        }
    }
}
