using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program4
    {
        //Zadatak #4: Napisati program kojim se za unetu vrednost promenljive x izracunava i stampa vrednost funkcije
        static void Main(string[] args)
        {
            //Deklarisanje podataka
            double x, y;

            //Unos podatka x
            Console.Write("Unesite vrednost za x: ");
            x = Convert.ToDouble(Console.ReadLine());

            //Izracunavanje vrednosti funkcije
            y = Math.Sqrt(x - 1) + 1 / (x + 1);

            //Stampanje rezultata
            Console.WriteLine("Dobijena vrednost funkcije je {0:F3}.", y);


            Console.WriteLine("Kraj rada...");
            Console.ReadLine();

        }
    }
}
