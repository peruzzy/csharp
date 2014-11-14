using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program6
{
    class Program6
    {
        //Napisati program kojim se na osnovu unetih stranica trougla a,b i c izracunava:
        // - duzina simetrale ugla iz temena A
        // - duzina simetrale stranice a
        static void Main(string[] args)
        {
            //Deklarisanje podataka
            //a, b, c - stranice trougla
            //la - duzina simetrale ugla iz temena A
            //ma - duzina simetrale stranice a
            double a, b, c, la, ma;

            //Unos podataka
            Console.WriteLine("Unesite duzine stranice trougla: ");
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c = ");
            c = Convert.ToDouble(Console.ReadLine());

            //Izracunavanje duzine simetrale ugla iz temena A

            la = Math.Sqrt(b * c * ((b + c) * (b + c) - a * a)) / (b + c);

            //Izracunavanje duzine simetrale stranice a
            ma = 0.5 * Math.Sqrt(2 * (b * b + c * c) - a * a); 

            //Stampanje rezultata
            Console.WriteLine("Duzina simetrale ugla iz Temena A je {0:F3}.", la);
            Console.WriteLine("Duzine simetrale stranice a je {0:F3}.", ma);
            Console.ReadLine();
            
        }
    }
}
