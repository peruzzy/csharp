using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class Program5
    {
        //Napisati program kojim se odredjuje i stampa intenzitet sile kojom deluju dva tackasta naelektrisanja Q1 = 1C i Q2 = 10C na rastojanju r = 1m.
        static void Main(string[] args)
        {
            /*Deklarisanje podataka
             * q1 - kolicina elektriciteta prvog tackastog naelektrisanja
             * q2 - kolicina elektriciteta drugog tackastog naelektrisanja
             * r - rastojanje
             * e0 - elektricna konstanta vakuuma
             * f - sila
             */
            double q1 = 1, q2 = 10, r = 1, e0 = 8.85 * Math.Pow(10, -12), f;

            //Izracunavanje vrednosti sile

            f = q1 * q2/(4*Math.PI * e0 * r * r);

            //Stampanje rezultata
            Console.WriteLine("Dobijena vrednost sile je {0:E5}.", f);
            Console.ReadLine();
        }
    }
}
