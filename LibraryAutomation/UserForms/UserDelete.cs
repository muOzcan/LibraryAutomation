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
    public partial class UserDelete : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public UserDelete()
        {
            InitializeComponent();
        }

        public void List()
        {
            var users = db.Students.ToList();
            dataGridView1.DataSource = users;
        }

        private void UserDelete_Load(object sender, EventArgs e)
        {
            List();
        }

        private void userDeleteButton_Click(object sender, EventArgs e)
        {
            int clickId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var user = db.Students.Where(x => x.user_id == clickId).FirstOrDefault();
            db.Students.Remove(user);
            db.SaveChanges();
            List();
        }
    }
}
