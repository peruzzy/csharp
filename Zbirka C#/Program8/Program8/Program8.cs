using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domaci3
{
    class Program8
    {
        //Domaci #3 Napisati program kojim se utvrdjuje da li je godina prestupna.
        static void Main(string[] args)
        {

            var retry = true;
            while (retry)
            {
                retry = false;

                //Unos podatka godina
                Console.WriteLine("Unesite godinu: ");
                int godina = Convert.ToInt32(Console.ReadLine());

                //Ispitivanje da li je godina prestupna ili ne.                
                if (godina % 4 == 0 && godina % 100 != 0 || godina % 400 == 0)
                    Console.WriteLine("Godina {0} je prestupna.", godina);

                else
                    Console.WriteLine("Godina {0} nije prestupna.", godina);

                retry = true;
            }
        }
    }
}
