using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Recursion
{
    public class CalculateFactorial
    {
        public static int CalculateFactorialoef(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Ongelig getal");
            }
            else if (number == 0 || number == 1)
            {
                return 1;
            }
            int totaal = number;
            totaal = totaal * CalculateFactorialoef(number - 1);
            return totaal;

        }
    }
}
