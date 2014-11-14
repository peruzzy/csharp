using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "";
            
            int x = 3;
            if (x == 1)
            {
                result = result + "d";
                x = x - 1;
            }

            if (x == 2)
            {
                result = result + "b c";
            }

            if (x > 2)
            {
                result = result + "a";
            }
            

            while (x > 0)
            {
             x = x - 1;
             result = result + "-";
            }

            Text = result;
            
        }
    }
}
