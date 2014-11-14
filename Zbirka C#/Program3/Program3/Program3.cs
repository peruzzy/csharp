using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    class Program3
    {
        //3. Napisati program kojim se za unete vrednosti logickih promenljivih x1 i x2 odredjuje i stampa vrednost logickog izraza "y=x1 i (x1 ili x2)"
        static void Main(string[] args)
        {
            //Deklarisanje logickih promenljivih
            bool x1, x2, y;

            //Unos logickih vrednosti x1 i x2
            Console.Write("Unesite vrednosti logickih promenljivih \nx1 = ");
            x1 = bool.Parse(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = bool.Parse(Console.ReadLine());

            //Izracunavanje logickog izraza 
            y = x1 && (x1 || x2);

            //Stampanje rezultata
            Console.WriteLine("Za uneto x1 = {0} i x2 = {1} dobija se y = {2}", x1, x2, y);

            Console.ReadLine();
        }
    }
}
