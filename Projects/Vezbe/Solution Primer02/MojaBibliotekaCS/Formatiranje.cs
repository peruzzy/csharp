using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ.Primer02.MojaBibliotekaCS
{
    public class Formatiranje
    {
        public static string Formatiraj(string ime)
        {
            string ispis = string.Format("Dobrodosli u '{0}'.", ime);

            return ispis;
        }
    }
}
