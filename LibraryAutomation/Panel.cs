using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryAutomation.LendForms;
using LibraryAutomation.ResourceForms;

namespace LibraryAutomation
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        LibraryAutomationEntities db = new LibraryAutomationEntities();
        private void Panel_Load(object sender, EventArgs e)
        {
            // Users Button
            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;
            // Resources button
            addResourcesButton.Visible = false;
            editResourcesButton.Visible = false;
            delResourcesButton.Visible = false;
        }

        private void userButton_Click(object sender, EventArgs e)
        {
            if (addUserButton.Visible == false)
            {
                addUserButton.Visible = true;
                editUserButton.Visible = true;
                deleteUserButton.Visible = true;
            }
            else
            {
                addUserButton.Visible = false;
                editUserButton.Visible = false;
                deleteUserButton.Visible = false;
            }

            UserList userListForm = new UserList();
            userListForm.MdiParent = this;
            userListForm.Show();

        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            UserAdd add = new UserAdd();
            add.MdiParent = this;
            add.Show();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            UserDelete del = new UserDelete();
            del.MdiParent = this;
            del.Show();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            UserUpdate update = new UserUpdate();
            update.MdiParent = this;
            update.Show();
        }

        private void resourcesButton_Click(object sender, EventArgs e)
        {
            if (addResourcesButton.Visible == false)
            {
                addResourcesButton.Visible = true;
                editResourcesButton.Visible = true;
                delResourcesButton.Visible = true;
            }
            else
            {
                addResourcesButton.Visible = false;
                editResourcesButton.Visible = false;
                delResourcesButton.Visible = false;
            }
            
            ResourceList rlis = new ResourceList();
            rlis.MdiParent = this;
            rlis.Show();
        }

        private void addResourcesButton_Click(object sender, EventArgs e)
        {
            ResourceAdd addresource = new ResourceAdd();
            addresource.MdiParent = this;
            addresource.Show();
        }

        private void delResourcesButton_Click(object sender, EventArgs e)
        {
            ResourceDelete delresource = new ResourceDelete();
            delresource.MdiParent = this;
            delresource.Show();

        }

        private void editResourcesButton_Click(object sender, EventArgs e)
        {
            ResourceUpdate update = new ResourceUpdate();
            update.MdiParent = this;
            update.Show();
        }

        private void lendResButton_Click(object sender, EventArgs e)
        {
            LendResources lend = new LendResources();
            lend.MdiParent = this;
            lend.Show();
        }

        private void takeBackButton_Click(object sender, EventArgs e)
        {
            TakeBackResources take = new TakeBackResources();
            take.MdiParent = this;
            take.Show();
        }
    }
}
