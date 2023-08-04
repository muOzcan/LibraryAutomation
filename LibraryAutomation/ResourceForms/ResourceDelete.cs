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
        }

        private void delResButton_Click(object sender, EventArgs e)
        {
            int clickId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var resource = db.Resources.Where(x => x.resources_id == clickId).FirstOrDefault();
            db.Resources.Remove(resource);
            db.SaveChanges();
            List();
        }

        private void ResourceDelete_Load(object sender, EventArgs e)
        {
            List();
        }
    }
}
