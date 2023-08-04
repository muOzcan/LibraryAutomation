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
    public partial class UserUpdate : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public UserUpdate()
        {
            InitializeComponent();
        }

        public void List()
        {
            var users = db.Students.ToList();
            dataGridView1.DataSource = users;
        }

        private void UserUpdate_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nameTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            surnameTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            idTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            telTxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            mailTxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            int clickId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var user = db.Students.Where(x=>x.user_id == clickId).FirstOrDefault();
            user.user_name = nameTxt.Text;
            user.user_surname = surnameTxt.Text;
            user.user_tc = idTxt.Text;
            user.user_tel = telTxt.Text;
            user.user_mail = mailTxt.Text;
            db.SaveChanges();
            List();
        }
    }
}
