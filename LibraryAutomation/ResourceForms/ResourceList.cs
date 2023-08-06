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
    public partial class ResourceList : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public ResourceList()
        {
            InitializeComponent();
        }

        public void List()
        {

            var resources = db.Resources.ToList();
            dataGridView1.DataSource = resources.ToList();

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.Columns[1].HeaderText = "Resource Name";
            dataGridView1.Columns[2].HeaderText = "Resource Publisher";
            dataGridView1.Columns[3].HeaderText = "Resource Author";
            dataGridView1.Columns[4].HeaderText = "Resource Date";
            dataGridView1.Columns[5].HeaderText = "Resource Page";
        }

        private void ResourceList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
