using Microsoft.Win32;
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

            var registers = from Regist in db.Regist
                            select new
                            {
                                Regist.regist_id,
                                Regist.Students.user_name,
                                Regist.Resources.resources_name,
                                Regist.regist_givendate,
                                Regist.regist_returndate,
                                Regist.regist_state,
                            };

            //var regists = db.Regist.Where(x => x.regist_state == false);
            dataGridView1.DataSource = registers.ToList();


            //dataGridView1.Columns[6].Visible = false;
            //dataGridView1.Columns[7].Visible = false;

            dataGridView1.Columns[0].HeaderText = "Register Id";
            dataGridView1.Columns[1].HeaderText = "Register Name";
            dataGridView1.Columns[2].HeaderText = "Registed Source";
            dataGridView1.Columns[3].HeaderText = "Given Date";
            dataGridView1.Columns[4].HeaderText = "Return Date";
            dataGridView1.Columns[5].HeaderText = "State";
        }

        private void takeBackButton_Click(object sender, EventArgs e)
        {
            int clickedId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var registry = db.Regist.Where(x => x.regist_id == clickedId).FirstOrDefault();
            registry.regist_state = true;
            db.SaveChanges();

            //var regists = db.Regist.Where(x => x.regist_state == false).ToList();
            //dataGridView1.DataSource = regists.ToList();

            var registers = from Regist in db.Regist
                select new
                {
                    Regist.regist_id,
                    Regist.Students.user_name,
                    Regist.Resources.resources_name,
                    Regist.regist_givendate,
                    Regist.regist_returndate,
                    Regist.regist_state,
                };
            dataGridView1.DataSource = registers.ToList();
        }
    }
}
