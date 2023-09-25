using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2222222222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rok = 1909;

            if ((rok % 4 == 0) & (rok % 100 != 0))
            {
                Console.WriteLine("Ten rok jest rokiem przestepnym.");
                Console.ReadKey();

            }
            else if (rok % 400 == 0)
            {
                Console.WriteLine("Rok  jest przestępny.");
            }
            else
            {
                Console.WriteLine("Rok nie jest przestepny");
            }

            Console.ReadKey();
        }
    }
}
