using CatClassLibrary; //contoh penerapan mengimport library
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    public class CatKayu : Cat, IDetailCat // penerapan pilar Inheritance dan prinsip Interface segregation,  //contoh penerapan multiple inheritance
    {
        private string jenis = "Cat Kayu"; //field
        public string Jenis   // property
        {
            get { return jenis; }   // get method, //penerapan Encapsulation
        }
        public CatKayu() //contoh constructor tanpa parameter
        {
                
        }

        public CatKayu(string catMerk, string catWarna, double Kuantitas, double Harga)//contoh constructor dengan parameter
        {
            merk = catMerk;
            warna = catWarna;
            this.ukuran = Kuantitas; //contoh penerapan this
            this.harga = Harga; //dapat menggunakan this jika variabel dan parameter memiliki nama yang sama
        }

        public override string ToStringCat() //implementasi abstract method
        {
            return "cat : " + merk + "\t\tjenis : " + jenis + "\twarna : " + warna + "\tukuran : " + ukuran + " kg" + " \tharga Rp." + harga + " per satuan";
        }

        public void detailCat()//implementasi Interface segregation
        {
            Console.WriteLine("merek :{0}, jenis cat : {1}, warna : {2}, ukuran : {3} kg, harga {4} per satuan",merk, jenis, warna, ukuran, harga);
        }
    }
}
