using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp47
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("   ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~KALKULATOR~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");



            Console.WriteLine("Co chcesz policzyć: \n1. WYZNACZNIK MACIERZY 2x2 \n2. WYZNACZNIK 3x3" +
                "\n3. DZIAŁANIA NA LICZBACH\n4. PIERWIASTKI RÓWNANIA KWADRATOWEGO\n5. WYJŚCIE ");

            int wybor1 = Convert.ToInt32(Console.ReadLine());

            switch (wybor1)
            {
                // WYZNACZNIK MACIERZY 2x2
                case 1:
                    {
                        WYZN();
                        break;
                    }
                // PIERWIASTKI TRÓJMIANU KWADRATOWEGO
                case 2:
                    {
                        WYZN3X3();
                        break;
                    }
                
                // ZYKŁE DZIAŁANIA NA LICZBACH
                case 3:
                    {
                       
                        Console.WriteLine("Podaj pierwsza liczbe:");
                        double a = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Podaj druga liczbe:");
                        double b = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Jakiej opercaji chcesz użyć?:\n1. DODAWANIE\n2. ODEJMOWANIE\n3. MNOŻENIE\n" +
                            "4. DZIELENIE\n5. PIERWIASTKOWANIE");

                        int wybor2 = Convert.ToInt32(Console.ReadLine());


                        //wybór działań na liczbach
                        switch (wybor2)
                        {

                            case 1:
                                {
                                    Console.WriteLine(DOD(a, b));
                                    break;
                                }

                            case 2:
                                {
                                    Console.WriteLine(ODE(a, b));
                                    break;
                                }

                            case 3:
                                {
                                    Console.WriteLine(MNO(a, b));
                                    break;
                                }

                            case 4:
                                {
                                    Console.WriteLine(DZI(a, b));
                                    break;
                                }

                            case 5:
                                {
                                    Console.WriteLine(PIERW(a));
                                    break;
                                }

                            default:
                                {
                                    Console.WriteLine("Nie ma takiej opcji.");
                                    break;
                                }
                        
                        }

                        break;                    
                    }
                case 4:
                    {
                        TRKWPI();
                        break;
                    }
                case 5:
                    {
                        break;
                    }

            }

        
        
        }

       
        
        
        
        //METODY DO UŻYCIA
        static double DOD(double a, double b)
        {
            return a + b;
        }
       
        static double ODE(double a, double b)
        {
            return a - b;
        }
        
        static double MNO(double a, double b)
        {
            return a * b;
        }
        
        static double DZI(double a, double b)
        {
            return a / b;
        }
        
        static double PIERW(double a)
        {
            return Math.Sqrt(a);
        }
        //m. zerowe t kw
        static void TRKWPI() 
        {
            Console.WriteLine("Podaj współczynnik a: ");
            double a = Convert.ToDouble(Console.ReadLine());    
            
            Console.WriteLine("Podaj współczynnik b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Podaj współczynnik c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if(delta > 0)
            {
               double x1 = -b + Math.Sqrt(delta)/2 * a;
               double x2 = -b - Math.Sqrt(delta)/2 * a;
                Console.WriteLine("Funkcja ma dwa miejsca zerowe. x1= " + x1 + " x2= " + x2);
            }
            if (delta < 0)
            {
                Console.WriteLine("FUUNKCJA NIE MA MIEJSC ZEROWYCH");
            }
            if( delta == 0)
            {
                double x0 = -b / 2 * a;
                Console.WriteLine("Funkcja ma jedno miejsce zerowe i wynosi ono: " + x0);
            }
        }
        //wyznacznik macierzy 2x2
        static void WYZN() 
        {
            Console.WriteLine("Podaj wyraz nr 1,1:");
            double x11= Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Podaj wyraz nr 1,2:");
            double x12 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Podaj wyraz nr 2,1:");
            double x21 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wyraz nr 2,2:");
            double x22 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine(" ");
            
            Console.Write(x11 + " "); 
            Console.WriteLine(x12);
            Console.Write(x21 + " "); 
            Console.WriteLine(x22);
            
            Console.WriteLine(" ");
           
            Console.WriteLine("Wyznacznik tej macierzy wynosi: " + (x11 * x22 - x12 * x21));
            Console.ReadKey();
        }
        //wyznacznik 3x3
        static void WYZN3X3()
        {
            double[,] matrix = new double[3, 3];

            // wczytywanie macierzy od użytkownika
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Podaj element [{i + 1},{j + 1}]: ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            // obliczanie wyznacznika
            double det = matrix[0, 0] * (matrix[1, 1] * matrix[2, 2] - matrix[2, 1] * matrix[1, 2])
                       - matrix[0, 1] * (matrix[1, 0] * matrix[2, 2] - matrix[1, 2] * matrix[2, 0])
                       + matrix[0, 2] * (matrix[1, 0] * matrix[2, 1] - matrix[1, 1] * matrix[2, 0]);

            Console.WriteLine($"Wyznacznik macierzy to {det}");

            Console.ReadKey();  


        }

    }
}
