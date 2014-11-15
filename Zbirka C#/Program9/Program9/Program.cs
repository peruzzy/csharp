using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program9
{
    class Program
    {
        //Napisati program kojim se za unetu vrednost x izracunava y po formuli
        static void Main(string[] args)
        {
            //deklarisanje podataka
            double x, y;
            //Unos podatka x
            Console.WriteLine("Unesite vrednost za x: ");
            x = Convert.ToDouble(Console.ReadLine());

            //Realizacija ugnjezdene if-else sekcije
            if (x > 1)
                y = Math.Exp(x);
            else if (x < 0)
                y = Math.Abs(x);
            else
                y = Math.Sqrt(Math.Pow(x, 3));

            Console.WriteLine("Za unetu vrednost x = {0} dobija se y = {1:F3}.", x, y);

            Console.WriteLine("Kraj rada...");
            Console.ReadLine();
        }
    }
}
