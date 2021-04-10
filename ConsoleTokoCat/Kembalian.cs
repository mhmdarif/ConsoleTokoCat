using CatClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    class Kembalian
    {
        public static double totalKembalian(ref double uang, ref Toko t)
        {
            double total = uang - t.pembayaran();
            return total;
        }
    }
}
