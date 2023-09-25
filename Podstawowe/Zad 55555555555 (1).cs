using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad55555555555555555
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            char wybor;

            Console.WriteLine("Podaj pierwszą liczbę: ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę: ");
            b = float.Parse(Console.ReadLine());

            Console.WriteLine("Wybierz operację arytmetyczną:");



            Console.WriteLine("1.Dodawanie wciśnij + ");
            Console.WriteLine("2.Odejmowanie wciśnij - ");
            Console.WriteLine("3.Mnożenie wciśnij * ");
            Console.WriteLine("4.Dzielenie wciśnij / ");
            Console.WriteLine("5.Potęgowanie wciśnij ^ ");
            Console.WriteLine("6.Dzielenie modulo wciśnij % ");

            wybor = Convert.ToChar(Console.ReadLine());

            switch (wybor)
            {



                case '+':
                    {
                        Console.WriteLine(a + b);
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine(a-b);
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine(a*b);
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine(a/b);
                        break;
                    }
                case '^':
                    {
                        Console.WriteLine(Math.Pow(a,b));
                        break;
                    }
                case '%':
                    {
                        Console.WriteLine(a % b);
                        break;
                    }


                    
            }
            Console.ReadKey();
        

    }



    }
}
