using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class Login : Form
    {
        User user;

        public Login()
        {
            InitializeComponent();
          /*  string kUsername = "bebas";
            string kPassword = "pbo123";*/
            this.user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.user.username = Convert.ToString(tbUsername.Text);
            this.user.password = Convert.ToString(tbPassword.Text);

            if (user.Auth() == 1)
            {
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                string message = "Username '" + user.username + "' dan Password '" + user.password + "' tidak sesuai";
                MessageBox.Show(message);
            }
            /*Form2 f2 = new Form2();
            f2.Show();
            this.Hide();*/
        }

        private void dinda_Click(object sender, EventArgs e)
        {
            tbUsername.ResetText();
            tbPassword.ResetText();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
