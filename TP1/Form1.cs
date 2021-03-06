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
            
            //instansiasi kelas user
            this.user = new User();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //mengambil value dari text box
            this.user.username = Convert.ToString(tbUsername.Text);
            this.user.password = Convert.ToString(tbPassword.Text);

            if (user.Auth() == 1)
            {
                //ketika berhasil login maka membuka form 2, dan men hide form 1
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                //ketika gagal login menampilkan message box
                string message = "Username '" + user.username + "' dan Password '" + user.password + "' tidak sesuai";
                MessageBox.Show(message);
            }
        }

        private void dinda_Click(object sender, EventArgs e)
        {
            //untuk mereset text
            tbUsername.ResetText();
            tbPassword.ResetText();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //agar text box password nya memunculkan karakter *
            tbPassword.PasswordChar = '*';
        }
    }
}
