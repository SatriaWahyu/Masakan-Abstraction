using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class ResepSoto : Imakanan
    {
        public void Resep()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tBumbu / resep soto ayam yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Ayam (1/2 ekor)");
            Console.WriteLine("2> Soun");
            Console.WriteLine("3> Toge");
            Console.WriteLine("4> Kol");
            Console.WriteLine("5> Tomat");
            Console.WriteLine("6> Daun bawang");
            Console.WriteLine("7> Jeruk nipis");
            Console.WriteLine("8> Bawang merah (8 biji)");
            Console.WriteLine("9> Bawang putih (6 biji)");
            Console.WriteLine("10> kemiri (2biji)");
            Console.WriteLine("12> Ketumbar (2 sdt)");
            Console.WriteLine("13> Kunyit");
            Console.WriteLine("14> Daun salam, daun jeruk");
            Console.WriteLine("15> Sereh, Gula, Garam");
            Console.WriteLine("16> Kaldu bubuk");
        }

        public void CaraMasak()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tCara masak soto ayam yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Cuci bersih ayam, rebus ayam (air rebusan pertama dibuang untuk menghilangkan kotorannya)");
            Console.WriteLine("2> Tumis bawang merah, bawan putih, kemiri, ketumbar, kunyit, daun salam, daun jeruk, sereh, gula, garam, kaldu bubuk selanjutnya dimasukan kedalam rebusan ayam dan rebus hingga matang");
            Console.WriteLine("3> Siapkan soun, toge, kol untuk direbus sebentar secara terpisah dan bergantian. Potong tomat dan daun bawang sesuai selera");
            Console.WriteLine("4> Goreng ayam yg td sudah direbus. Siapkan bahan pelengkap");
        }
    }
}
