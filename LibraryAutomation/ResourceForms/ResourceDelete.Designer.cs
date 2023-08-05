namespace LibraryAutomation.ResourceForms
{
    partial class ResourceDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceDelete));
            this.delResButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // delResButton
            // 
            this.delResButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.delResButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delResButton.Image = ((System.Drawing.Image)(resources.GetObject("delResButton.Image")));
            this.delResButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delResButton.Location = new System.Drawing.Point(38, 12);
            this.delResButton.Name = "delResButton";
            this.delResButton.Size = new System.Drawing.Size(135, 62);
            this.delResButton.TabIndex = 0;
            this.delResButton.Text = "       DELETE";
            this.delResButton.UseVisualStyleBackColor = false;
            this.delResButton.Click += new System.EventHandler(this.delResButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 409);
            this.dataGridView1.TabIndex = 1;
            // 
            // ResourceDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(85)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(825, 501);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delResButton);
            this.Name = "ResourceDelete";
            this.Text = "ResourceDelete";
            this.Load += new System.EventHandler(this.ResourceDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button delResButton;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}