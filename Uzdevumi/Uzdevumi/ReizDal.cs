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






    }
}
