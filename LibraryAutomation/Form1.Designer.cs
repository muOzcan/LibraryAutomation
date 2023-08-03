namespace LibraryAutomation
{
    partial class Form1
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
            this.loginButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.personalUsernameTxt = new System.Windows.Forms.TextBox();
            this.personalPasswordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Green;
            this.loginButton.Location = new System.Drawing.Point(90, 213);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(175, 40);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "LOG IN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usernameLabel.Location = new System.Drawing.Point(29, 137);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(58, 13);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Control;
            this.passwordLabel.Location = new System.Drawing.Point(31, 172);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(56, 13);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password:";
            // 
            // personalUsernameTxt
            // 
            this.personalUsernameTxt.Location = new System.Drawing.Point(90, 134);
            this.personalUsernameTxt.Name = "personalUsernameTxt";
            this.personalUsernameTxt.Size = new System.Drawing.Size(175, 20);
            this.personalUsernameTxt.TabIndex = 3;
            // 
            // personalPasswordTxt
            // 
            this.personalPasswordTxt.Location = new System.Drawing.Point(90, 169);
            this.personalPasswordTxt.Name = "personalPasswordTxt";
            this.personalPasswordTxt.Size = new System.Drawing.Size(175, 20);
            this.personalPasswordTxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(320, 414);
            this.Controls.Add(this.personalPasswordTxt);
            this.Controls.Add(this.personalUsernameTxt);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.loginButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox personalUsernameTxt;
        private System.Windows.Forms.TextBox personalPasswordTxt;
    }
}

