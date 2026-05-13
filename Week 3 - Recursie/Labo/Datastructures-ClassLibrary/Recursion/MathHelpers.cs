using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class MathHelpers
    {
        public static int CalculateNumberOfDigits(int number)
        {
            if (number < 10) {  return 1; }
            int length = CalculateNumberOfDigits(number / 10) + 1;
            return length;
        }
    }
}
