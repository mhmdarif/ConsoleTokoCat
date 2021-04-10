using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClassLibrary
{
    public class Tampil //penerapan prinsip Single-responsibility
    {
        public static void printDaftarBelanja(Toko t)
        {
            Console.WriteLine("daftar barang yang ada di keranjang : ");
            for (int i = 0; i < t.daftarBelanja.Count; i++)
            {
                Console.WriteLine("#" + i + " " + t.daftarBelanja[i].ToStringCat());
            }
        }

        public static void printStok(Toko t)
        {
            for (int i = 0; i < t.daftarCat.Count; i++)
            {
                Console.WriteLine("#" + i + " " + t.daftarCat[i].ToStringCat());
            }
        }
    }
}
