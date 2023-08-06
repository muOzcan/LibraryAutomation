using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation.ResourceForms
{
    public partial class ResourceDelete : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public ResourceDelete()
        {
            InitializeComponent();
        }

        public void List()
        {
            var resources = db.Resources.ToList();
            dataGridView1.DataSource = resources;

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Resource Name";
            dataGridView1.Columns[2].HeaderText = "Resource Publisher";
            dataGridView1.Columns[3].HeaderText = "Resource Author";
            dataGridView1.Columns[4].HeaderText = "Resource Date";
            dataGridView1.Columns[5].HeaderText = "Resource Page";
        }

        private void delResButton_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show(text: "Are you sure you want to delete the resource?", "Delete action",
                MessageBoxButtons.YesNo);

            if (delete == DialogResult.Yes)
            {
                int clickId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
                var resource = db.Resources.Where(x => x.resources_id == clickId).FirstOrDefault();
                db.Resources.Remove(resource);
                db.SaveChanges();
                List();
            }
            else
            {

            }
        }

        private void ResourceDelete_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
