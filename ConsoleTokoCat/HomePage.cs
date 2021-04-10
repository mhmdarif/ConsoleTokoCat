using CatClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTokoCat
{
    public class HomePage
    {
        public static void HomeP(ref Toko refToko)
        {
            Console.WriteLine("SELAMAT DATANG");

            Toko t = refToko;

            int kondisi = Kondisi.pilihanKondisi();

            while (kondisi != 0)
            {
                Console.WriteLine("\n***** anda memilih opsi ({0}) *****", kondisi);

                switch (kondisi)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Tampil.printStok(t);
                        break;

                    case 2:
                        Tampil.printStok(t);
                        Console.WriteLine("\nsilakan pilih cat yang ingin diamsukan ke keranjang (isi angka)");
                        Console.Write("# : ");
                        int pilihan = 0;
                        try
                        {
                            pilihan = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("masukan yang anda berikan salah! silakan masukan kembali");
                        }

                        try
                        {
                            t.daftarBelanja.Add(t.daftarCat[pilihan]);
                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("pilihan yang anda berikan tidak tersedia. silakan masukan kembali!");
                        }
                        Console.WriteLine("");
                        Tampil.printDaftarBelanja(t);
                        break;

                    case 3:
                        Tampil.printDaftarBelanja(t);
                        Console.WriteLine("\ntotal biaya sementara : Rp." + t.pembayaran());
                        break;

                    case 4:
                        Tampil.printDaftarBelanja(t);
                        Console.WriteLine("\nTotal biaya yang harus dibayar : Rp." + t.pembayaran());

                        Console.WriteLine("\nMasukan jumlah uang anda Rp. ");
                        double uangPembeli = 0;

                        try
                        {
                            uangPembeli = int.Parse(Console.ReadLine());
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("masukan salah! silakan ulangi kembali");
                        }
                        double totalKembalian = Kembalian.totalKembalian(ref uangPembeli, ref t);
                        if (totalKembalian > 0)
                        {
                            Console.WriteLine("\nTotal kembalian anda : Rp." + totalKembalian);
                            t.daftarBelanja.Clear();
                        }
                        else
                        {
                            Console.WriteLine("uang anda tidak cukup! silakan masukan kembali");
                        }
                        
                        break;

                    default:
                        Console.WriteLine("\nmasukan yang ada berikan salah! masukan opsi sesuai ketentuan (int angka)");
                        break;
                }

                kondisi = Kondisi.pilihanKondisi();
            }
        }

        
        
        /*public void tambahCat()
        {
            string catMerk = "";
            string catWarna = "";
            double catHarga = 0;
            double catKuantitas = 0;

            Console.Write("merk : ");
            catMerk = Console.ReadLine();

            Console.Write("warna : ");
            catWarna = Console.ReadLine();

            Console.Write("harga : ");
            catHarga = double.Parse(Console.ReadLine());

            Console.Write("Jumlah barang : ");
            catKuantitas = double.Parse(Console.ReadLine());

            Cat catBaru = new CatKayu(catMerk, catWarna, catKuantitas, catHarga);
            t.daftarCat.Add(catBaru);

            Console.WriteLine("");
            Toko.printStok(t);
        }*/
    }    

}

