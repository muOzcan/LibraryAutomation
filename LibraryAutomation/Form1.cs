using System;
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
    public partial class Form1 : Form
    {
        readonly LibraryAutomationEntities db = new LibraryAutomationEntities();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void loginButton_Click(object sender, EventArgs e)
        {
            string personalUsername = personalUsernameTxt.Text;
            string personalPassword = personalPasswordTxt.Text;

            var user = db.Users.Where(x=> x.personal_username.Equals(personalUsername) && x.personal_password.Equals(personalPassword)).FirstOrDefault();

            if (user == null)
            {
                MessageBox.Show(text: "id sifre yanlis"); 
            }
            else
            {
                MessageBox.Show(text: "Giris basarili");
                Panel panel = new Panel();
                panel.Show();
                this.Hide();
            }
            
        }
    }
}
