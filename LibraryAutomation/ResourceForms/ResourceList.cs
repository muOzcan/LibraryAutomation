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
        }

        private void ResourceList_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
