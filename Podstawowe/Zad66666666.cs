
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad666666666666
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int liczba = 993;
            int s, d, j;

            s = liczba / 100;
            

            liczba = liczba - s * 100;
            d = liczba / 10;

            liczba = liczba - d * 10;
            j = liczba;
            Console.WriteLine(s + " " + d + " " + j);

            

            //Console.WriteLine(liczba);

            if((s+d+j) % 3 == 0)
            {
                Console.WriteLine("Podzielna przez 3.");
            }
            else
            {
                Console.WriteLine("Niepodzielna przez 3.");
            }
            Console.ReadKey();



        }
    }
}
