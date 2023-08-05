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
    public partial class TakeBackResources : Form
    {
        public TakeBackResources()
        {
            InitializeComponent();
        }
        LibraryAutomationEntities db = new LibraryAutomationEntities();

        private void TakeBackResources_Load(object sender, EventArgs e)
        {
            var regists = db.Regist.Where(x => x.regist_state == false).ToList();
            dataGridView1.DataSource = regists.ToList();

            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void takeBackButton_Click(object sender, EventArgs e)
        {
            int clickedId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var regist = db.Regist.Where(x => x.regist_id == clickedId).FirstOrDefault();
            regist.regist_state = true;
            db.SaveChanges();
            var regists = db.Regist.Where(x => x.regist_state == false).ToList();
            dataGridView1.DataSource = regists.ToList();
            

        }
    }
}
