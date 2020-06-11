using System;


using Abstraction.AbstractClass;
using Abstraction.Interface;

namespace Abstraction

{
    class Program
    {
        static void Template()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("1> Pengertian");
            Console.WriteLine("2> Resep");
            Console.WriteLine("3> Cara masak");
            Console.WriteLine("4> Back");
            Console.Write("Pilih : ");
        }
        static void Jarak()
        {
            Console.WriteLine("\n\n\n");
        }
        static void Main(string[] args)
        {
            Pengertian pengertian;
            Imakanan makanan;
            int pilihanMenu;
            int pilihanSubMenu;

            do
            {
                Console.WriteLine("============================================");
                Console.WriteLine("SELAMAT DATANG DI PROGRAM MASAKAN");
                Console.WriteLine("============================================");
                Console.WriteLine("1> Soto");
                Console.WriteLine("2> Gudeg");
                Console.WriteLine("3> Seblak");
                Console.WriteLine("4> Exit");
                Console.Write("Pilih Menu : ");
                pilihanMenu = Convert.ToInt32(Console.ReadLine());

                switch (pilihanMenu)
                {

                    case 1:
                        Template();
                        pilihanSubMenu = Convert.ToInt32(Console.ReadLine());
                        if (pilihanSubMenu == 1)
                        {
                            pengertian = new Soto();
                            pengertian.penjelasanMakanan();
                        }
                        else if (pilihanSubMenu == 2)
                        {
                            makanan = new ResepSoto();
                            makanan.Resep();
                        }
                        else if (pilihanSubMenu == 3)
                        {
                            makanan = new ResepSoto();
                            makanan.CaraMasak();
                        }
                        Jarak();
                        break;
                    case 2:
                        Template();
                        pilihanSubMenu = Convert.ToInt32(Console.ReadLine());
                        if (pilihanSubMenu == 1)
                        {
                            pengertian = new Gudeg();
                            pengertian.penjelasanMakanan();
                        }
                        else if (pilihanSubMenu == 2)
                        {
                            makanan = new ResepGudeg();
                            makanan.Resep();
                        }
                        else if (pilihanSubMenu == 3)
                        {
                            makanan = new ResepGudeg();
                            makanan.CaraMasak();
                        }
                        Jarak();
                        break;
                    case 3:
                        Template();
                        pilihanSubMenu = Convert.ToInt32(Console.ReadLine());
                        if (pilihanSubMenu == 1)
                        {
                            pengertian = new Seblak();
                            pengertian.penjelasanMakanan();
                        }
                        else if (pilihanSubMenu == 2)
                        {
                            makanan = new ResepSeblak();
                            makanan.Resep();
                        }
                        else if (pilihanSubMenu == 3)
                        {
                            makanan = new ResepSeblak();
                            makanan.CaraMasak();
                        }
                        Jarak();
                        break;
                }
            } while (pilihanMenu != 4);

        }
    }
}
