using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CatClassLibrary
{
    public abstract class Cat //dengan menggunakan abstract class atau interface maka sudah menjalankan pilar Abstraction
    {
        public string merk { get; set; } //contoh anonymous property
        public string warna { get; set; } //dengan membuat property maka sudah menjalankan pilar Encapsulation
        public double ukuran { get; set; }
        public double harga { get; set; }

        public abstract string ToStringCat(); //contoh penerapan abstract method pada abstract class
             
    }
}
