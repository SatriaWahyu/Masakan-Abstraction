using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.Interface
{
    class ResepGudeg : Imakanan
    {
        public void Resep()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tBumbu / resep gudeg yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Nangka Muda (1/2kg)");
            Console.WriteLine("2> Bawang merah & putih (6 & 3 siung)");
            Console.WriteLine("3> Kemiri (4 butir)");
            Console.WriteLine("4> Ketumbar (1 sdm)");
            Console.WriteLine("5> Sereh (3 batang)");
            Console.WriteLine("6> Daun salam (3 lembar)");
            Console.WriteLine("7> Daun jeruk (4 lembar)");
            Console.WriteLine("8> Lengkuas (3cm)");
            Console.WriteLine("9> Gula jawa (75gr)");
            Console.WriteLine("10> Santan (1 Liter)");
            Console.WriteLine("11> Garam / penyedap rasa (secukupnya)");
        }
        public void CaraMasak()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("\tCara masak gudeg yaitu : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1> Siapkan bahan-bahan & haluskan bumbu");
            Console.WriteLine("2> Ambil panci dan masukan sereh, daun salam, daun jeruk lengkuas(geprek)");
            Console.WriteLine("3> Lalu masukkan bawang merah, bawang putih, kemiri, ketumbar ditambah nangka dan santan");
            Console.WriteLine("4> Tutup rapat panci dan masak selama 2.5 - 4.5 jam");
            Console.WriteLine("5> Saat santan sudah mulai menyurut, masukkan telur dan gula jawa lagi bila suka manis , jika sudah tutup lagi dan masak hingga kuah surut");
        }
    }
}
