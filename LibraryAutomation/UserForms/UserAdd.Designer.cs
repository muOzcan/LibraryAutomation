namespace LibraryAutomation
{
    partial class UserAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.addUserButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mailTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(68, 166);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(184, 20);
            this.nameTxt.TabIndex = 1;
            // 
            // addUserButton
            // 
            this.addUserButton.BackColor = System.Drawing.Color.LimeGreen;
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addUserButton.Location = new System.Drawing.Point(68, 296);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(184, 46);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "SAVE";
            this.addUserButton.UseVisualStyleBackColor = false;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(275, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 526);
            this.dataGridView1.TabIndex = 3;
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(68, 192);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(184, 20);
            this.surnameTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname:";
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(68, 218);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(184, 20);
            this.idTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // telTxt
            // 
            this.telTxt.Location = new System.Drawing.Point(68, 244);
            this.telTxt.Name = "telTxt";
            this.telTxt.Size = new System.Drawing.Size(184, 20);
            this.telTxt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Telephone:";
            // 
            // mailTxt
            // 
            this.mailTxt.Location = new System.Drawing.Point(68, 270);
            this.mailTxt.Name = "mailTxt";
            this.mailTxt.Size = new System.Drawing.Size(184, 20);
            this.mailTxt.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "E-mail:";
            // 
            // UserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 550);
            this.Controls.Add(this.mailTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.idTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.label1);
            this.Name = "UserAdd";
            this.Text = "UserAdd";
            this.Load += new System.EventHandler(this.UserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox mailTxt;
        private System.Windows.Forms.Label label5;
    }
}