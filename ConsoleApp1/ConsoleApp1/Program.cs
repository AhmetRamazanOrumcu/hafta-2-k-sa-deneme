using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
                Console.WriteLine("Türkçe Notunu Giriniz:");
                int turkceNotu=int.Parse(Console.ReadLine());

                Console.WriteLine("Matematik Notunu Giriniz:");
                int matNotu = int.Parse(Console.ReadLine());
            */
            /*
            Console.WriteLine("Notunu Giriniz:");
            int notu;
            if (int.TryParse(Console.ReadLine(), out notu))
            {
                if (notu >= 0 && notu <= 100)
                {
                    if (notu >= 45)
                        Console.WriteLine("Geçti");
                    else
                        Console.WriteLine("kaldı");
                }
                else
                {
                    Console.WriteLine("Lütfen Geçerli bir not giriniz.");
                }
            }
            else Console.WriteLine("Sayı giriniz.");

            Console.ReadKey();
            */



            Console.WriteLine("Gün giriniz:");
            string gun;
            if(string.TryParse(ReadLine().ToLower(),out gun))

            Console.ReadKey();  
        }
    }
}
