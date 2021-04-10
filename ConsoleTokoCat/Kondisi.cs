using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    class Kondisi
    {
        public static int pilihanKondisi()
        {
            int kondisi = 0;
            bool flag = true;
            while (flag != false)
            {
                Console.WriteLine("\n\n===============================================================================================================");
                Console.WriteLine("\n(0) = quit, (1) = melihat daftar cat, (2) = memasukan barang ke dalam keranjang, (3) = melihat daftar belanja, (4) =  melakukan pembayaran");
                Console.WriteLine("sialakan pilih opsi yang tersedia");
                try
                {
                    kondisi = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (Exception e)
                {

                    Console.WriteLine("maaf, masukan opsi sesuai dengan ketentuan (angka integer)");
                    flag = true;
                }
            }
            return kondisi;

        }
    }
}
