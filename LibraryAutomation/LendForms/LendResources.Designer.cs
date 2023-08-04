namespace LibraryAutomation.LendForms
{
    partial class LendResources
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.findIdTxt = new System.Windows.Forms.TextBox();
            this.findLabelTxt = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.filterResButton = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lendButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(867, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Location = new System.Drawing.Point(282, 12);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(101, 38);
            this.findButton.TabIndex = 2;
            this.findButton.Text = "FIND";
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // findIdTxt
            // 
            this.findIdTxt.Location = new System.Drawing.Point(60, 12);
            this.findIdTxt.Name = "findIdTxt";
            this.findIdTxt.Size = new System.Drawing.Size(216, 20);
            this.findIdTxt.TabIndex = 3;
            // 
            // findLabelTxt
            // 
            this.findLabelTxt.AutoSize = true;
            this.findLabelTxt.Location = new System.Drawing.Point(67, 37);
            this.findLabelTxt.Name = "findLabelTxt";
            this.findLabelTxt.Size = new System.Drawing.Size(0, 13);
            this.findLabelTxt.TabIndex = 4;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(389, 37);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(490, 208);
            this.dataGridView2.TabIndex = 5;
            // 
            // filterResButton
            // 
            this.filterResButton.Location = new System.Drawing.Point(553, 12);
            this.filterResButton.Name = "filterResButton";
            this.filterResButton.Size = new System.Drawing.Size(213, 20);
            this.filterResButton.TabIndex = 6;
            this.filterResButton.TextChanged += new System.EventHandler(this.filterResButton_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter by resource name:";
            // 
            // lendButton
            // 
            this.lendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lendButton.Location = new System.Drawing.Point(138, 133);
            this.lendButton.Name = "lendButton";
            this.lendButton.Size = new System.Drawing.Size(138, 78);
            this.lendButton.TabIndex = 8;
            this.lendButton.Text = "LEND";
            this.lendButton.UseVisualStyleBackColor = false;
            this.lendButton.Click += new System.EventHandler(this.lendButton_Click);
            // 
            // LendResources
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 559);
            this.Controls.Add(this.lendButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterResButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.findLabelTxt);
            this.Controls.Add(this.findIdTxt);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LendResources";
            this.Text = "LendResources";
            this.Load += new System.EventHandler(this.LendResources_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.TextBox findIdTxt;
        private System.Windows.Forms.Label findLabelTxt;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox filterResButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lendButton;
    }
}