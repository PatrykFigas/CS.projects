using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ćw1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            decimal x, y;
            
            Console.WriteLine("Podaj temperaturę w stopniach Celcjusza:");
            x = Convert.ToDecimal(Console.ReadLine());

            y = 9 / 5 * x + 32;

            Console.WriteLine(x + " stopni Celcjusza to " + y + " stopni Fahrenheita.");

                Console.ReadKey();

        }
    }
}
