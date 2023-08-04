namespace LibraryAutomation
{
    partial class Panel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.editUserButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.userButton = new System.Windows.Forms.Button();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.resourcesButton = new System.Windows.Forms.Button();
            this.addResourcesButton = new System.Windows.Forms.Button();
            this.editResourcesButton = new System.Windows.Forms.Button();
            this.delResourcesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.delResourcesButton);
            this.panel1.Controls.Add(this.editResourcesButton);
            this.panel1.Controls.Add(this.addResourcesButton);
            this.panel1.Controls.Add(this.resourcesButton);
            this.panel1.Controls.Add(this.deleteUserButton);
            this.panel1.Controls.Add(this.editUserButton);
            this.panel1.Controls.Add(this.addUserButton);
            this.panel1.Controls.Add(this.userButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 489);
            this.panel1.TabIndex = 0;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.deleteUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.deleteUserButton.FlatAppearance.BorderSize = 0;
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Location = new System.Drawing.Point(0, 183);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(228, 62);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // editUserButton
            // 
            this.editUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.editUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editUserButton.FlatAppearance.BorderSize = 0;
            this.editUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editUserButton.Location = new System.Drawing.Point(0, 121);
            this.editUserButton.Name = "editUserButton";
            this.editUserButton.Size = new System.Drawing.Size(228, 62);
            this.editUserButton.TabIndex = 2;
            this.editUserButton.Text = "Edit User";
            this.editUserButton.UseVisualStyleBackColor = false;
            this.editUserButton.Click += new System.EventHandler(this.editUserButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addUserButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addUserButton.FlatAppearance.BorderSize = 0;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(0, 61);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(228, 60);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // userButton
            // 
            this.userButton.BackColor = System.Drawing.Color.LightCoral;
            this.userButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.userButton.FlatAppearance.BorderSize = 0;
            this.userButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userButton.Location = new System.Drawing.Point(0, 0);
            this.userButton.Name = "userButton";
            this.userButton.Size = new System.Drawing.Size(228, 61);
            this.userButton.TabIndex = 0;
            this.userButton.Text = "Users";
            this.userButton.UseVisualStyleBackColor = false;
            this.userButton.Click += new System.EventHandler(this.userButton_Click);
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infoPanel.Location = new System.Drawing.Point(228, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(695, 41);
            this.infoPanel.TabIndex = 1;
            // 
            // resourcesButton
            // 
            this.resourcesButton.BackColor = System.Drawing.Color.LightCoral;
            this.resourcesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.resourcesButton.FlatAppearance.BorderSize = 0;
            this.resourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resourcesButton.Location = new System.Drawing.Point(0, 245);
            this.resourcesButton.Name = "resourcesButton";
            this.resourcesButton.Size = new System.Drawing.Size(228, 61);
            this.resourcesButton.TabIndex = 4;
            this.resourcesButton.Text = "Resources";
            this.resourcesButton.UseVisualStyleBackColor = false;
            this.resourcesButton.Click += new System.EventHandler(this.resourcesButton_Click);
            // 
            // addResourcesButton
            // 
            this.addResourcesButton.BackColor = System.Drawing.Color.Yellow;
            this.addResourcesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addResourcesButton.FlatAppearance.BorderSize = 0;
            this.addResourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addResourcesButton.Location = new System.Drawing.Point(0, 306);
            this.addResourcesButton.Name = "addResourcesButton";
            this.addResourcesButton.Size = new System.Drawing.Size(228, 61);
            this.addResourcesButton.TabIndex = 5;
            this.addResourcesButton.Text = "Add Resources";
            this.addResourcesButton.UseVisualStyleBackColor = false;
            this.addResourcesButton.Click += new System.EventHandler(this.addResourcesButton_Click);
            // 
            // editResourcesButton
            // 
            this.editResourcesButton.BackColor = System.Drawing.Color.Purple;
            this.editResourcesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editResourcesButton.FlatAppearance.BorderSize = 0;
            this.editResourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editResourcesButton.Location = new System.Drawing.Point(0, 367);
            this.editResourcesButton.Name = "editResourcesButton";
            this.editResourcesButton.Size = new System.Drawing.Size(228, 61);
            this.editResourcesButton.TabIndex = 6;
            this.editResourcesButton.Text = "Edit Resources";
            this.editResourcesButton.UseVisualStyleBackColor = false;
            // 
            // delResourcesButton
            // 
            this.delResourcesButton.BackColor = System.Drawing.Color.Cyan;
            this.delResourcesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.delResourcesButton.FlatAppearance.BorderSize = 0;
            this.delResourcesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delResourcesButton.Location = new System.Drawing.Point(0, 428);
            this.delResourcesButton.Name = "delResourcesButton";
            this.delResourcesButton.Size = new System.Drawing.Size(228, 61);
            this.delResourcesButton.TabIndex = 7;
            this.delResourcesButton.Text = "Delete Resources";
            this.delResourcesButton.UseVisualStyleBackColor = false;
            this.delResourcesButton.Click += new System.EventHandler(this.delResourcesButton_Click);
            // 
            // Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 489);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "Panel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.Panel_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button userButton;
        private System.Windows.Forms.Button delResourcesButton;
        private System.Windows.Forms.Button editResourcesButton;
        private System.Windows.Forms.Button addResourcesButton;
        private System.Windows.Forms.Button resourcesButton;
    }
}