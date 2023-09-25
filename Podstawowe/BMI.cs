using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp37
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double a, b, BMI;

            Console.WriteLine("Podaj mase ciała w kg");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wzrost w m");
            b = Convert.ToDouble(Console.ReadLine());


            BMI = a / b * b;

            Console.WriteLine("Twoje BMI wynosi " + BMI);

            Console.ReadKey();



        }
    }
}
