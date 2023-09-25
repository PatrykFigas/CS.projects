using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double delta;

            Console.WriteLine("Podaj współczynnik a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik b: ");
            b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj współczynnik c: ");
            c = Convert.ToDouble(Console.ReadLine());

            delta = b * b - 4 * a * c;

            Console.WriteLine("Delta wynosi " + delta);

            Console.ReadKey();
        }
    }
}
