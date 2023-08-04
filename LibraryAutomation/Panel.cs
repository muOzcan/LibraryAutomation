﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryAutomation
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {
            addUserButton.Visible = false;
            editUserButton.Visible = false;
            deleteUserButton.Visible = false;
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
    }
}
