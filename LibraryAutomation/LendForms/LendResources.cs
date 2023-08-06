using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.LendForms
{
    public partial class LendResources : Form
    {
        public LendResources()
        {
            InitializeComponent();
        }
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        private void LendResources_Load(object sender, EventArgs e)
        {
            var registlist = db.Regist.ToList();
            dataGridView1.DataSource = registlist.ToList();

            var sourcelist = db.Resources.ToList();
            dataGridView2.DataSource = sourcelist.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Regist ID";
            dataGridView1.Columns[1].HeaderText = "User Name";
            dataGridView1.Columns[2].HeaderText = "Resource Name";
            dataGridView1.Columns[3].HeaderText = "Given Date";
            dataGridView1.Columns[4].HeaderText = "Return Date";
            dataGridView1.Columns[5].HeaderText = "State";

            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[6].Visible = false;

            dataGridView2.Columns[1].HeaderText = "Resource Name";
            dataGridView2.Columns[2].HeaderText = "Resource Publisher";
            dataGridView2.Columns[3].HeaderText = "Resource Author";
            dataGridView2.Columns[4].HeaderText = "Resource Date";
            dataGridView2.Columns[5].HeaderText = "Resource Page";

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            string find = findIdTxt.Text;
            var isFinded = db.Students.Where(x => x.user_tc == find).FirstOrDefault();
            if (isFinded != null)
            {
                findLabelTxt.Text = isFinded.user_name + " " + isFinded.user_surname;
            }
            else
            {
                findLabelTxt.Text = "User not found.";
            }
        }

        private void filterResButton_TextChanged(object sender, EventArgs e)
        {
            string incomeval = filterResButton.Text;
            var findRes = db.Resources.Where(x => x.resources_name.Contains(incomeval)).ToList();
            dataGridView2.DataSource = findRes;
        }

        private void lendButton_Click(object sender, EventArgs e)
        {
            string chosenUserId = findIdTxt.Text;
            var chosenUser = db.Students.Where(x => x.user_tc.Equals(chosenUserId)).FirstOrDefault();

            int chosenResId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var chosenRes = db.Resources.Where(x => x.resources_id == chosenResId).FirstOrDefault();

            Regist newRegist = new Regist();
            newRegist.regist_book = chosenRes.resources_id;
            newRegist.regist_name = chosenUser.user_id;
            newRegist.regist_givendate=DateTime.Now;
            newRegist.regist_returndate = DateTime.Today.AddDays(15);
            newRegist.regist_state = false;
            db.Regist.Add(newRegist);
            db.SaveChanges();

            var registlist = db.Regist.ToList();
            dataGridView1.DataSource = registlist.ToList();

        }

     
    }
}
