using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class ResepSeblak : Imakanan
    {
        public void Resep()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tBumbu / resep seblak yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Air (600 ml)");
            Console.WriteLine("2> Kerupuk bawang warna-warni (50 gr)");
            Console.WriteLine("3> Mie keriting (50 gr)");
            Console.WriteLine("4> Bumbu nasi goreng instant pedas (1 sendok makan)");
            Console.WriteLine("5> Telur (1 butir, kocok lepas)");
            Console.WriteLine("6> Bakso (3 butir)");
            Console.WriteLine("7> Makan susu full cream (3 sendok)");
        }
        public void CaraMasak()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tCara masak seblak yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Rebus air hingga mendidih. Masukkan kerupuk dan mi keriting. Masak hingga kerupuk lembut");
            Console.WriteLine("2> Tuang bumbu nasi goreng instant nasi goreng pedas dan telur. Aduk rata");
            Console.WriteLine("3> Masukkan bakso yang telah digoreng terlebih dahulu, lalu masukkan susu. Aduk rata dan masak hingga mendidih. Tambahkan 3 sendok susu full cream");
            Console.WriteLine("4> Test rasa. Angkat dan seblak creamy mi bakso siap disajikan selagi hangat");
        }
    }
}
