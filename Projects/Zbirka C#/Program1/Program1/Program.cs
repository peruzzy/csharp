using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Napisati program kojim se za uneti trocifreni broj odredjuje i stampa cifra jedinice, desetine i stotine.

namespace Program1 
{
    class Program1
    {
        static void Main(string[] args)
        {
            /*
             * Deklarisanje podataka
             * n - uneti trocifreni broj
             * j - cifra jedinice trocifrenog broja
             * d - cifra desetice trocifrenog broja
             * s - cifra stotine trocifrenog broja
             */
            int n, j, d, s;

            //Unos trocifrenog broja
            Console.Write("Unesite trocifreni broj: ");
            n = Convert.ToInt32(Console.ReadLine());

            //Odredjivanje cifara trocifrenog broja
            s = n / 100;
            d = (n - s * 100) / 10;
            j = n - s * 100 - d * 10;

            //Stampanje rezultata
            Console.WriteLine("Jedinica \t Desetica \t Stotina \t Broj");
            Console.WriteLine("{0} \t\t {1} \t\t {2} \t\t {3}", j, d, s, n);
            Console.ReadLine();
        }
    }
}
