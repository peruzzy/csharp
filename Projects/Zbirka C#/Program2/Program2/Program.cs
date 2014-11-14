using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        // 2. Napisati program kojim se unosi i stampa IP adresa koriscenjem podatka tipa byte 
        static void Main(string[] args)
        {
            //Deklarisanje okteta IP adrese
            byte prviOktet, drugiOktet, treciOktet, cetvrtiOktet;

            //Unos IP adrese
            Console.WriteLine(" Unesite IP adresu: ");
            Console.WriteLine(" I oktet: ");
            prviOktet = Convert.ToByte(Console.ReadLine());            
            Console.WriteLine(" II oktet: ");
            drugiOktet = Convert.ToByte(Console.ReadLine());            
            Console.WriteLine(" III oktet: ");
            treciOktet = Convert.ToByte(Console.ReadLine());            
            Console.WriteLine(" IV oktet: ");
            cetvrtiOktet = Convert.ToByte(Console.ReadLine());

            //Stampanje rezultata

            Console.WriteLine(" Uneta IP adresa je {0}.{1}.{2}.{3}", prviOktet, drugiOktet, treciOktet, cetvrtiOktet);
            Console.ReadLine();
        }
    }
}
