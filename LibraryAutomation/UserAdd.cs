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

        private void UserAdd_Load(object sender, EventArgs e)
        {
            List();
        }

        public void List()
        {
            var users = db.Students.ToList();
            dataGridView1.DataSource = users;
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
        }
    }
}
