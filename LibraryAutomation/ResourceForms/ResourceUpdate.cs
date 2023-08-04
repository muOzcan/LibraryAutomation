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
    public partial class ResourceUpdate : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public ResourceUpdate()
        {
            InitializeComponent();
        }

        private void ResourceUpdate_Load(object sender, EventArgs e)
        {
            var resources = db.Resources.ToList();
            dataGridView1.DataSource = resources.ToList();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            nameResTxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            pubResTxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            autResTxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value);
            numericUpDown1.Value = Convert.ToDecimal(dataGridView1.CurrentRow.Cells[5].Value);

        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            int clickresource = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var updateresource = db.Resources.Where(x => x.resources_id == clickresource).FirstOrDefault();
            updateresource.resources_name = nameResTxt.Text;
            updateresource.resources_publisher = pubResTxt.Text;
            updateresource.resources_author = autResTxt.Text;
            updateresource.resources_date = dateTimePicker1.Value;
            updateresource.resources_page = Convert.ToInt16(numericUpDown1.Value);
            db.SaveChanges();

            var resources = db.Resources.ToList();
            dataGridView1.DataSource = resources.ToList();

        }
    }
}
