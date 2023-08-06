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

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[2].HeaderText = "User Surname";
            dataGridView1.Columns[3].HeaderText = "User Id";
            dataGridView1.Columns[4].HeaderText = "User Tel";
            dataGridView1.Columns[5].HeaderText = "User Mail";
        }

        private void UserDelete_Load(object sender, EventArgs e)
        {
            List();
        }

        private void userDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(text: "Are you sure you want to delete the user?", "Delete action",
                MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                int clickId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                var user = db.Students.Where(x => x.user_id == clickId).FirstOrDefault();
                db.Students.Remove(user);
                db.SaveChanges();
                List();
            }
            else
            {
                
            }
   
        }
    }
}
