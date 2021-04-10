using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClassLibrary
{
    public class Toko
    {
        public List<Cat> daftarCat { get; set; }
        public List<Cat> daftarBelanja { get; set; }

        public Toko()
        {
            daftarCat = new List<Cat>();
            daftarBelanja = new List<Cat>();
        }

        public double pembayaran()
        {
            double totalBiaya = 0;

            foreach (var cat in daftarBelanja)
            {
                totalBiaya += cat.harga;
            }
            return totalBiaya;
        }
        
        
    }
}
