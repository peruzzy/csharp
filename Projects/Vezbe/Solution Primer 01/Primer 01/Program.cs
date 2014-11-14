using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesite ime: ");
            string ime = Console.ReadLine();

            string ispis = string.Format("Dobrodosli '{0}'.", ime);

            Console.WriteLine(ispis);

            Console.WriteLine("\nPritisnite bilo koji taster za kraj rada...");
            Console.ReadLine();
        }
    }
}
