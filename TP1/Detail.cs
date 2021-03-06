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
    public partial class Detail : Form
    {
        public Detail()
        {
            InitializeComponent();
            
            

            /*  addListItem dt = new addListItem();
              lbHarga.Text= dt.harga.ToString();
              lbNama.Text = dt.nama;*/
        }

 

        private void btnHome_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void btnWebCatalog_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://dindawr.cehiji.com/pratikum/TP5_1901012_DindaWahyuR/");
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login f1 = new Login();
            f1.Show();
            this.Hide();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            lbNama.Text = Form2.id_kirim;
        }
    }
}
