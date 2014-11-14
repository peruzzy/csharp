using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program7
{
    class Program7
    {
        //Napisati program koji izracunava vrednost funkcije
        static void Main(string[] args)
        {
            //Deklarisanje podataka
            double x, y, z, f;
            //Unos podataka
            Console.Write("Unesite vrednost za x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite vrednost za y: ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Unesite vrednost za z: ");
            z = Convert.ToDouble(Console.ReadLine());

            if (x != y)
            {
                //Izracunavanje vrednosti funkcije
                f = (x + y) * (x + 2 * z) / (x - y);
                
                //Stampanje rezultata
                Console.WriteLine("Dobijena vrednost funkcije je {0:F3}", f);
                Console.ReadLine();

            }
        }
    }
}
