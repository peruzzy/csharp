using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program10
{
    class Program10
    {
        //Napisati program kojim se utvrdjuje da li je uneti znak malo ili veliko slovo, cifra ili specijalan znak
        static void Main(string[] args)
        {
            var retry = true;
            while (retry)
            {
                retry = false;
                //Unos znaka
                Console.WriteLine("\nUnesite znak: ");
                char ch = Convert.ToChar(Console.ReadLine());

                //Ispitivanje vrste znaka
                if (ch >= 'a' && ch <= 'z')
                    Console.WriteLine("{0} je malo slovo.", ch);
                else if (ch >= 'A' && ch <= 'Z')
                    Console.WriteLine("{0} je veliko slovo.", ch);
                else if (ch >= '0' && ch <= '9')
                    Console.WriteLine("{0} je cifra.", ch);
                else
                    Console.WriteLine("{0} je specijalan znak.", ch);

                retry = true;
            }
      
        }
    }
}
