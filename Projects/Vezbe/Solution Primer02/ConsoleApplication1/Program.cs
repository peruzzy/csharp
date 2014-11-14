using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PJ.Primer02.MojaBibliotekaCS;

namespace Primer02
{
    class Program
    {
        static void Main(string[] args)
        {
            string ime = "Milica Vuckovic";
            string ispis = Formatiranje.Formatiraj(ime);
            Console.WriteLine(ispis);
        }
    }
}
