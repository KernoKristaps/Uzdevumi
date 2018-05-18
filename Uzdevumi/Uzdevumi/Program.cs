using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    class Program
    {
        static void Main(string[] args)
        {
            int izvele = 1;
            ReizDal RZ = new ReizDal();
            
            while (izvele != 0)
            {
                Console.WriteLine("\n" + "\t" + "1- Saskaitīšana");
                Console.WriteLine("\t" + "2- Atņemšana");
                Console.WriteLine("\t" + "3- Reizināšana");
                Console.WriteLine("\t" + "4- Dalīšana");
                Console.WriteLine("\t" + "5- Kāpināšana");


                Console.WriteLine("\t" + "0- Iziet\n");

                string input = Console.ReadLine();
                izvele = Convert.ToInt16(input);
               

                switch (izvele)
                {
                    case 1:

                        int c = Funkcija1();
                        Console.WriteLine("\t Iznākums = " + c);
                        break;
                    case 2:
                        int c2 = Funkcija2();
                        Console.WriteLine("\t Iznākums = " + c2);
                        break;
                    case 3:
                        double c3 = RZ.Funkcija3();
                        Console.WriteLine("\t Iznākums = " + c3);
                        break;
                    case 4:
                        double c4 = RZ.Funkcija4();
                        Console.WriteLine("\t Iznākums = " + c4);
                        break;
                    case 5:
                        RZ.Funkcija5();
                        Console.WriteLine("\t Iznākums = ");
                        break;

                    default:
                        Console.WriteLine("Ievade nav pareiza \n");
                        break;
                }

            }

        }
        static int Funkcija1()
        {
            Console.WriteLine("Ievadiet pirmo skaitli : ");
            string skaitlis1 = Console.ReadLine();
            int a = Convert.ToInt16(skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli : ");
            string skaitlis2 = Console.ReadLine();
            int b = Convert.ToInt16(skaitlis2);


            int c = a + b;
            return c;
        }
        static int Funkcija2()
        {
            Console.WriteLine("Ievadiet pirmo skaitli : ");
            string skaitlis1 = Console.ReadLine();
            int a = Convert.ToInt16(skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli : ");
            string skaitlis2 = Console.ReadLine();
            int b = Convert.ToInt16(skaitlis2);


            int c2 = a - b;
            return c2;


        }
        
    }   
        
    
}
