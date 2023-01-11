using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Long_veri_tipi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long veri tipi -9.223.372.036.854.775.808 ve 9.223.373.036.854.775.807 arasında değerleri alır.
            long birincidegisken = 575000;
            long ikincidegisken = -500;
            long MaxDeger = long.MaxValue;
            long MinDeger = long.MinValue;
            Console.WriteLine(birincidegisken);
            Console.WriteLine(ikincidegisken);
            Console.WriteLine(MaxDeger);
            Console.WriteLine(MinDeger);
            Console.ReadLine();
        }
    }
}
