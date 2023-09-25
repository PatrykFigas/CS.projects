using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int [,,,] tabliczka = new int [3,3,3,3];

            for (int i = 0; i <= 2; i++)
            {                                
                for(int j = 0; j <= 2; j++) 
                {
                    for (int k = 0; k <= 2; k++)
                    {
                        for (int l = 0; l <= 2; l++)
                        {

                            Console.WriteLine($"Podaj element  [{i + 1},{j + 1},{k + 1},{l + 1}]:");

                            tabliczka[i, j, k, l] = i;
                        }
                    }
                }



            }
        Console.ReadLine();
        }
    }
}
