using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4444444
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a=8, b=6, c=10;
            int tmp;
            
            if (a > b)
            {
                tmp = a; a = b; b = tmp; 
            }
            if(b>c)
            {
                tmp = b; b = c; c = tmp;
            }
            if (a > b)
            {
                tmp = a; a = b; b = tmp;
            }

            Console.WriteLine(a + " " + b + " " + c);


            Console.ReadKey();
        
        }

    }
}
