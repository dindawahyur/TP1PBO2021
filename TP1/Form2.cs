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
    public partial class Form2 : Form
    {
        List<Barang> dataBarang = new List<Barang>();
        private int minHarga = 0;           //menyimpan harga minimal saat menfilter barang
        private int maxHarga = 0;           //menyimpan harga maksimal saat menfilter barang
        private string jenisBarang = null;  //menyimpan jenis barang saat menfilter barang
        
        public Form2()
        {
            InitializeComponent();
            setDataBarang();    //menginisialisasi barang 
            tampilBarang();     //memanggil prosedur tampil barang
   
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //saat form2 load maka menampilkan filter (combo bos jenis, harga, dan btn cari)
            tampilFilter(); //memanggil prosedur tampil filter
        }

        void setDataBarang()
        {
            //mengisi data barang ke list
            this.dataBarang.Add(new Barang(0, "TV", "Elektronik", 1000000, "television"));
            this.dataBarang.Add(new Barang(1, "Kulkas", "Elektronik", 950000, "refrigerator"));
            this.dataBarang.Add(new Barang(2, "Mie", "Makanan", 150000, "ramen"));
            this.dataBarang.Add(new Barang(3, "Pakaian Wanita", "Pakaian", 400000, "dress"));
            this.dataBarang.Add(new Barang(4, "Pakaian Pria", "Pakaian", 200000, "suit")); 
        }

        void tampilBarang()
        {
            flpDasar.Controls.Clear();//ada di desain, fungsi nya untuk membersihkan panel nya
            
            //foreach sebanyak banyak nya data
            foreach (var dt in this.dataBarang)
            {
                //kalo jenis yang di class barang itu sama dengan variabel jenisBarang yang aktif disini
                if (dt.jenis == this.jenisBarang)
                {
                    if (this.minHarga == 0)
                    {
                        flpDasar.Controls.Add(buatPanel(dt.id, dt.nama, dt.harga, dt.foto));
                    }
                    else if (this.minHarga <= dt.harga && this.maxHarga >= dt.harga)
                    {
                        flpDasar.Controls.Add(buatPanel(dt.id, dt.nama, dt.harga, dt.foto));
                    }
                }
                else if (this.jenisBarang == null)
                {
                    if (this.minHarga == 0)
                    {
                        flpDasar.Controls.Add(buatPanel(dt.id, dt.nama, dt.harga, dt.foto));
                    }
                    else if (this.minHarga <= dt.harga && this.maxHarga >= dt.harga)
                    {
                        flpDasar.Controls.Add(buatPanel(dt.id, dt.nama, dt.harga, dt.foto));
                    }
                    
                }
            }
        }     

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            f2.Show();
            this.Hide();
        }

        private void btnWebCatalog_Click(object sender, EventArgs e)
        {
            //membuka sebuah website di browser
            System.Diagnostics.Process.Start("http://dindawr.cehiji.com/pratikum/TP5_1901012_DindaWahyuR/");
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            tampilBarang();
        }

        private void cbHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mengambil text dari combo box yang dipilih
            string filterHarga = (sender as ComboBox).Text;

            //memberikan nilai pada variabel min dan max harga
            if (filterHarga == "100rb - 200rb")
            {
                this.minHarga = 100000;
                this.maxHarga = 200000;
            }
            else if (filterHarga == "200rb - 500rb")
            {
                this.minHarga = 200000;
                this.maxHarga = 500000;
            }
            else if (filterHarga == "500rb - 1jt")
            {
                this.minHarga = 500000;
                this.maxHarga = 1000000;
            }
            else if (filterHarga == "Semua")
            {
                this.minHarga = 0;
                this.maxHarga = 0;
            }
        }

        private void cbJenisBarang_SelectedIndexChanged(object sender, EventArgs e)
        {
            //mengambil text dari combo box jenis barang
            this.jenisBarang = (sender as ComboBox).Text;

            //kalo user memilih pilihan semua, maka jenis barang di set null
            if (this.jenisBarang == "Semua")
            {
                this.jenisBarang = null;
            }

        }

        public Panel buatPanel(int id, string nama, int harga, string foto)
        {
            //panel yang paling besar
            return createPanelBarang(id, nama, harga, foto);
        }

        Panel createPanelBarang(int id, string nama, int harga, string foto)
        {
            //panel kotak setiap barang
            Panel wadah = new Panel();
            wadah.Name = nama;
            wadah.Size = new System.Drawing.Size(172, 194);
            wadah.BackColor = System.Drawing.Color.AliceBlue;
            
            wadah.Padding = new Padding(5);

            PictureBox pb = createPBBarang(foto);
            wadah.Controls.Add(pb);

            Label a = createLabelNama(nama);
            wadah.Controls.Add(a);

            Label b = createLabelHarga(harga);
            wadah.Controls.Add(b);

            Button btn = createBtnBeli(id);
            wadah.Controls.Add(btn);

            return wadah;
        }

        //membuat picture box
        PictureBox createPBBarang(string foto)
        {
            PictureBox pbBarang = new PictureBox();
            pbBarang.Image = (Image)Properties.Resources.ResourceManager.GetObject(foto);
            pbBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pbBarang.Location = new System.Drawing.Point(3, 3);
            pbBarang.Name = "pd_";
            pbBarang.Size = new System.Drawing.Size(166, 102);
            pbBarang.TabIndex = 4;
            pbBarang.TabStop = false;

            return pbBarang;
        }

        //membuat label nama
        Label createLabelNama(string nama)
        {
            Label lbNama = new Label();
            lbNama.AutoSize = true;
            lbNama.Location = new System.Drawing.Point(28, 115);
            lbNama.Name = "lbNama";
            lbNama.Size = new System.Drawing.Size(35, 13);
            lbNama.TabIndex = 5;
            lbNama.Text = nama;

            return lbNama;
        }

        //membuat label harga
        Label createLabelHarga(int harga)
        {
            Label lbHarga = new Label();
            lbHarga.AutoSize = true;
            lbHarga.Location = new System.Drawing.Point(28, 136);
            lbHarga.Name = "lbHarga";
            lbHarga.Size = new System.Drawing.Size(35, 13);
            lbHarga.TabIndex = 6;
            lbHarga.Text = harga.ToString();
            return lbHarga;
        }

        //membuat button beli
        Button createBtnBeli(int id)
        {
            Button btnBeli = new Button();
            btnBeli.BackColor = System.Drawing.Color.DarkSlateGray;
            btnBeli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnBeli.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnBeli.Location = new System.Drawing.Point(31, 157);
            btnBeli.Name = id.ToString();
            btnBeli.Size = new System.Drawing.Size(107, 26);
            
            btnBeli.Text = "B E L I";
            btnBeli.UseVisualStyleBackColor = false;
            btnBeli.Click += new System.EventHandler(btnBeli_Click);

            return btnBeli;
        }

        //membuat button kembali
        Button createBtnKembali()
        {
            Button btnKembali = new Button();
            btnKembali.BackColor = System.Drawing.Color.DarkSlateGray;
            btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnKembali.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnKembali.Location = new System.Drawing.Point(16, 37);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new System.Drawing.Size(121, 32);
            btnKembali.TabIndex = 12;
            btnKembali.Text = "K E M B A L I";
            btnKembali.UseVisualStyleBackColor = false;
            btnKembali.Click += new System.EventHandler(btnKembali_Click);
            return btnKembali;
        }

        void tampilFilter()
        {
            pFilter.Controls.Clear();

            ComboBox a = createCBJenis();
            pFilter.Controls.Add(a);

            ComboBox b = createCBHarga();
            pFilter.Controls.Add(b);

            Button btn = createBtnCari();
            pFilter.Controls.Add(btn);
        }

        //membuat combo box jenis
        ComboBox createCBJenis()
        {
            ComboBox cbJenisBarang = new ComboBox();
            cbJenisBarang.FormattingEnabled = true;
            cbJenisBarang.Items.AddRange(new object[] {
            "Elektronik",
            "Pakaian",
            "Makanan",
            "Semua"});
            cbJenisBarang.Location = new System.Drawing.Point(12, 21);
            cbJenisBarang.Name = "cbJenisBarang";
            cbJenisBarang.Size = new System.Drawing.Size(121, 21);
            cbJenisBarang.TabIndex = 9;
            cbJenisBarang.Text = "Jenis Barang";
            cbJenisBarang.SelectedIndexChanged += new System.EventHandler(this.cbJenisBarang_SelectedIndexChanged);
            return cbJenisBarang;
        }

        //membuat combo box harga
        ComboBox createCBHarga()
        {
            ComboBox cbHarga = new ComboBox();
            cbHarga.FormattingEnabled = true;
            cbHarga.Items.AddRange(new object[] {
            "100rb - 200rb",
            "200rb - 500rb",
            "500rb - 1jt",
            "Semua"});
            cbHarga.Location = new System.Drawing.Point(12, 52);
            cbHarga.Name = "cbHarga";
            cbHarga.Size = new System.Drawing.Size(121, 21);
            cbHarga.TabIndex = 10;
            cbHarga.Text = "Harga";
            cbHarga.SelectedIndexChanged += new System.EventHandler(this.cbHarga_SelectedIndexChanged);
            
            return cbHarga;
        }

        //membuat button cari
        Button createBtnCari()
        {
            Button btnCari = new Button();
            btnCari.BackColor = System.Drawing.Color.DarkSlateGray;
            btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            btnCari.Location = new System.Drawing.Point(12, 83);
            btnCari.Name = "btnCari";
            btnCari.Size = new System.Drawing.Size(121, 32);
            btnCari.TabIndex = 11;
            btnCari.Text = "C A R I";
            btnCari.UseVisualStyleBackColor = false;
            btnCari.Click += new System.EventHandler(this.btnCari_Click);

            return btnCari;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            pFilter.Controls.Clear();//clear panel pFilter

            //inisialisasi nilai awal
            minHarga = 0;
            maxHarga = 0;
            jenisBarang = null;

            //memanggil tampilBarang dan tampil filter
            tampilBarang();
            tampilFilter();
            
        }

        //jika button beli di click
        private void btnBeli_Click(object sender, EventArgs e)
        {
          
            string id_btn; //deklarasi variabel 
            id_btn = (sender as Button).Name; //mengambil name button

            //melalukan foreach sebanyak data barang
            foreach (var dt in this.dataBarang)
            {
                //jika id pada data barang sama dengan id btn
                if (dt.id.ToString() == id_btn)
                {
                    //memberikan batas harga dan jenis untuk menfilter
                    minHarga = dt.harga;
                    maxHarga = dt.harga;
                    jenisBarang = dt.jenis;
                }
            }

            pFilter.Controls.Clear();//clear panel pFilter

            //membuat button dynamic
            Button btn = createBtnKembali();
            pFilter.Controls.Add(btn);

            //memanggil tampil barang
            tampilBarang();
         
        }
    }
}
