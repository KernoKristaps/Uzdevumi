using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uzdevumi
{
    class ReizDal
    {


        public double Funkcija3()
        {
            Console.WriteLine("Ievadiet pirmo skaitli : ");
            string skaitlis1 = Console.ReadLine();
            double a3 = Convert.ToDouble(skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli : ");
            string skaitlis2 = Console.ReadLine();
            double b3 = Convert.ToDouble(skaitlis2);

            double c3 = a3 * b3;
            return c3;
        }

    
        public double Funkcija4()
        {
            Console.WriteLine("Ievadiet pirmo skaitli : ");
            string skaitlis1 = Console.ReadLine();
            double a4 = Convert.ToDouble(skaitlis1);

            Console.WriteLine("Ievadiet otro skaitli : ");
            string skaitlis2 = Console.ReadLine();
            double b4 = Convert.ToDouble(skaitlis2);

            double c4 = a4 / b4;
            return c4;
        }
        public void Funkcija5()
        {
            int Ver = 0;
            Console.WriteLine("Ievadiet skaitli : ");
            string ievade = Console.ReadLine();
            int skaitlis = Convert.ToInt16(ievade);


            Console.WriteLine("Ievadiet cik reizes vēlaties kāpināt skaitli : ");
            string ievade2 = Console.ReadLine();
            int skaitlis2 = Convert.ToInt16(ievade2);

            for (int i = 0; i < skaitlis2; i++)
            {
                int OldVer = Ver;
                Ver = Ver + i;
                Console.WriteLine(OldVer + "+" + i + "=" + Ver);

            }






        }
    }
}
