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
    public partial class ResourceAdd : Form
    {
        private LibraryAutomationEntities db = new LibraryAutomationEntities();
        public ResourceAdd()
        {
            InitializeComponent();
        }

        public void List()
        {
            var resources = db.Resources.ToList();
            dataGridView1.DataSource = resources;
        }

        private void addResourceButton_Click(object sender, EventArgs e)
        {
            Resources resource = new Resources();
            resource.resources_name = nameResTxt.Text;
            resource.resources_publisher = pubResTxt.Text;
            resource.resources_author = autResTxt.Text;
            resource.resources_date = dateTimePicker1.Value;
            resource.resources_page = Convert.ToInt16(numericUpDown1.Value);
            db.Resources.Add(resource);
            db.SaveChanges();

            var kresourse = db.Resources.ToList();
            dataGridView1.DataSource = kresourse.ToList();

        }

        private void ResourceAdd_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
