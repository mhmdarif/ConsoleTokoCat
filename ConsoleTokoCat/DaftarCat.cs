using CatClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    class DaftarCat
    {
        public static void memBuatDaftarCat(ref Toko refToko)
        {
            Toko t = refToko;
            
            //CAT KAYU
            //meng-instance object dari class catKayu
            CatKayu catKayu1 = new CatKayu("Dulux", "Coklat", 5, 50000);
            CatKayu catKayu2 = new CatKayu("Avian", "Coklat", 5, 49000);
            CatKayu catKayu3 = new CatKayu("Avian", "Merah", 5, 48500);

            //menambahkan object catkayu kedalam daftarCat
            t.daftarCat.Add(catKayu1);
            t.daftarCat.Add(catKayu2);
            t.daftarCat.Add(catKayu3);

            //CAT KAYU
            //meng-instance object dari class catTembok
            CatTembok catTembok1 = new CatTembok("Nippon", "Biru", 5, 45000);
            CatTembok catTembok2 = new CatTembok("Nippon", "Hijau", 5, 47000);
            CatTembok catTembok3 = new CatTembok("Avian", "Biru", 5, 46000);

            //menambahkan object catTembok kedalam daftarCat
            t.daftarCat.Add(catTembok1);
            t.daftarCat.Add(catTembok2);
            t.daftarCat.Add(catTembok3);
        }
    }
}
