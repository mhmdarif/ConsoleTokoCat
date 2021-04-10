using CatClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    class CatTembok : Cat, IDetailCat
    {
        private string jenis = "Cat Tembok"; //field
        public string Jenis   // property
        {
            get { return jenis; }   // get method
        }
        public CatTembok()
        {

        }
        public CatTembok(string catMerk, string catWarna, double catKuantitas, double catHarga)
        {
            merk = catMerk;
            warna = catWarna;
            ukuran = catKuantitas;
            harga = catHarga;
        }

        public override string ToStringCat()
        {
            return "cat : " + merk + "\t\tjenis : " + jenis + "\twarna : " + warna + "\tukuran : " + ukuran +" kg"+" \tharga Rp." + harga + " per satuan";
        }

        public void detailCat()
        {
            Console.WriteLine("merek :{0}, jenis cat : {1}, warna : {2}, ukuran : {3} kg, harga {4} per satuan", merk, jenis, warna, ukuran, harga);
        }
        
    }

}
