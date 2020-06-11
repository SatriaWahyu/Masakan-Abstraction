using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction.AbstractClass
{
    class Soto : Pengertian
    {
        public override void penjelasanMakanan()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("Soto adalah makanan khas Indonesia seperti sop yang terbuat dari kaldu daging dan sayuran. Daging yang paling sering digunakan adalah daging sapi dan ayam. Berbagai daerah di Indonesia memiliki soto khas daerahnya masing-masing dengan komposisi yang berbeda-beda.");
            Console.WriteLine("============================================");
        }
    }
}
