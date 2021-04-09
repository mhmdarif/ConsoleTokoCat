using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClassLibrary
{
    public class Cat
    {
        public string nama { get; set; }
        public string warna { get; set; }
        public double kuantitas { get; set; }
        public double harga { get; set; }

        public Cat(string nama, string warna, double kuantitas, double harga)
        {
            this.nama = nama;
            this.warna = warna;
            this.kuantitas = kuantitas;
            this.harga = harga;

        }
    }
}
