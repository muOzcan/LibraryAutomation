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

        private UserList userListForm;
        private void userButton_Click(object sender, EventArgs e)
        {
            if (addUserButton.Visible == false)
            {
                addUserButton.Visible = true;
                editUserButton.Visible = true;
                deleteUserButton.Visible = true;
                userListForm = new UserList();
                userListForm.MdiParent = this;
                userListForm.Show();
            }

            else
            {
                addUserButton.Visible = false;
                editUserButton.Visible = false;
                deleteUserButton.Visible = false;
                userListForm.Close();
            }
        }

        private UserAdd add;
        bool addState = false;
        private void addUserButton_Click(object sender, EventArgs e)
        {
            if (addState == false)
            {
                add = new UserAdd();
                add.MdiParent = this;
                add.Show();
                addState = true;

            }
            else
            {
                add.Close();
                addState = false;
            }

        }

        private UserDelete del;
        bool delState = false;
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            if (delState == false)
            {
                del = new UserDelete();
                del.MdiParent = this;
                del.Show();
                delState = true;
            }
            else
            {
                del.Close();
                delState = false;
            }

        }

        private UserUpdate update;
        bool updateState = false;
        private void editUserButton_Click(object sender, EventArgs e)
        {
            if (updateState == false)
            {
                update = new UserUpdate();
                update.MdiParent = this;
                update.Show();
                updateState = true;
            }
            else
            {
                update.Close();
                updateState = false;
            }

        }

        private ResourceList rlis;
        private void resourcesButton_Click(object sender, EventArgs e)
        {
            if (addResourcesButton.Visible == false)
            {
                addResourcesButton.Visible = true;
                editResourcesButton.Visible = true;
                delResourcesButton.Visible = true;
                rlis = new ResourceList();
                rlis.MdiParent = this;
                rlis.Show();
            }
            else
            {
                addResourcesButton.Visible = false;
                editResourcesButton.Visible = false;
                delResourcesButton.Visible = false;
                rlis.Close();
            }

        }

        private ResourceAdd addresource;
        bool addresourcestate = false;
        private void addResourcesButton_Click(object sender, EventArgs e)
        {
            if (addresourcestate == false)
            {
                addresource = new ResourceAdd();
                addresource.MdiParent = this;
                addresource.Show();
                addresourcestate = true;

            }
            else
            {
                addresource.Close();
                addresourcestate = false;
            }

        }

        private ResourceDelete delresource;
        bool delresourcestate = false;
        private void delResourcesButton_Click(object sender, EventArgs e)
        {
            if (delresourcestate == false)
            {
                delresource= new ResourceDelete();
                delresource.MdiParent = this;
                delresource.Show();
                delresourcestate = true;

            }
            else
            {
                delresource.Close();
                delresourcestate = false;
            }
             

        }

        private ResourceUpdate resourceupdate;
        bool updateresourcestate = false;
        private void editResourcesButton_Click(object sender, EventArgs e)
        {
            if (updateresourcestate == false)
            {
                resourceupdate = new ResourceUpdate();
                resourceupdate.MdiParent = this;
                resourceupdate.Show();
                updateresourcestate = true;
            }
            else
            {
                resourceupdate.Close();
                updateresourcestate = false;
            }
             
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
