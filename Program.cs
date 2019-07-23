using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectProduk
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek produk
        static List<Produk> daftarProduk = new List<Produk>();

        static void Main(string[] args)
        {
			Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahProduk();
                        break;

                    case 2:
                        HapusProduk();
                        break;

                    case 3:
                        TampilProduk();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("\n1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahProduk()
        {
			Console.Clear();

			Produk produk = new Produk();
			Console.WriteLine("Tambah Data Produk");
            Console.Write("\nKode Produk : ");
			produk.Kode = Console.ReadLine();
			Console.Write("Nama Produk : ");
			produk.Nama = Console.ReadLine();
            Console.Write("Harga Beli : ");
			produk.Beli = Convert.ToInt32(Console.ReadLine());
			Console.Write("Harga Jual : ");
			produk.Jual = Convert.ToInt32(Console.ReadLine());

			daftarProduk.Add(produk);

			Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusProduk()
        {
			Produk produk = new Produk();
			Console.Clear();

			Console.WriteLine("Hapus Data Produk");
			Console.WriteLine("\nKode Produk : ");
			string kd = Console.ReadLine();
			Produk delPro = daftarProduk.SingleOrDefault(f => f.Kode == kd);

			if (daftarProduk.Contains(delPro) == true)
			{
				daftarProduk.Remove(delPro);
				Console.WriteLine("Data produk berhasil di hapus");
			}

			else
			{
				Console.WriteLine("Kode produk tidak ditemukan");
			}

			Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilProduk()
        {
            Console.Clear();
			int noUrut = 1;

			Console.WriteLine("Data Produk\n");
			foreach (Produk produk in daftarProduk)
			{
				Console.WriteLine("{0}. {1}, {2}, {3}, {4}", noUrut, produk.Kode, produk.Nama, produk.Beli, produk.Jual + "\n");
				noUrut++;
			}

			Console.WriteLine("Tekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
