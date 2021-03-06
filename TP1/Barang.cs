using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    class Barang
    {
        public int id { get; set; }
        public string nama { get; set; }
        public string jenis { get; set; }
        public int harga { get; set; }
        public string foto { get; set; }

        //kontruktor kosong wajib dibuat
        public Barang() { }

        public Barang(int id, string nama, string jenis, int harga, string foto)
        {
            this.id = id;
            this.nama = nama;
            this.jenis = jenis;
            this.harga = harga;
            this.foto = foto;
        }
    }
}
