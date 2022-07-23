using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Penjualan data = new Penjualan();

            Console.Clear();

            Console.WriteLine("Tambah Data Penjualan\n");
            Console.Write("Nota: ");
            data.Nota = Console.ReadLine();
            Console.Write("Tanggal: ");
            data.Tanggal = Console.ReadLine();
            Console.Write("Custormer: ");
            data.Customer = Console.ReadLine();
            Console.Write("Jenis [T/K]: ");
            data.Jenis = Console.ReadLine() == "T" ? "Tunai" : "Kredit";
            Console.Write("Total Nota: ");
            data.Total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();

            daftarPenjualan.Add(data);
        }

        static void TampilPenjualan()
        {
            int number = 1;

            Console.Clear();

            Console.WriteLine("Data Penjualan\n");

            foreach (Penjualan data in daftarPenjualan)
            {
                Console.WriteLine($"{number}. {data.Nota}, {data.Tanggal}, {data.Customer}, {data.Jenis}, {data.Total}");
                number++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
