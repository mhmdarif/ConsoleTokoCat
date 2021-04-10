using CatClassLibrary;
using System;

namespace ConsoleTokoCat
{
    class Program
    {
        static void Main(string[] args)
        {
            Toko t = new Toko(); //membuat instance class Toko, //contoh penerapan instancing class, 

            DaftarCat.memBuatDaftarCat(ref t); //menginisialisasi objek-objek yang telah tersimpan di program

            HomePage.HomeP(ref t); //digunakan untuk menampilkan HomePage, //contoh penerapan memanggil fungsi 
            
            /*Console.ReadLine();*/
        }
    }
}
