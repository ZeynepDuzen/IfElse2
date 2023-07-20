using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElse2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir;
            sehir = "bursa";

            Console.WriteLine("Lütfen sehir adı giriniz : ");
            Console.WriteLine();
            sehir = Console.ReadLine();

            if (sehir == "bursa")
            {
                
                Console.WriteLine("Dogru sehir");
            }
            else
            {
                Console.WriteLine("Yanlıs sehir");
            }

            Console.Read();
        }
    }
}
