using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            człowiek Patryk = new człowiek("Patrykoo");

            Patryk.przedstawsie();

            Console.ReadLine();

        }
    }



    namespace ConsoleApp54
    {
        internal class człowiek
        {
            public człowiek(string imiekon)
            {
                imie = imiekon;

            }

            public void przedstawsie()
            {
                Console.WriteLine("Mam na imie " + imie);
            }


            public string imie;


        }
    }
}
