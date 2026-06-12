using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Recursion
{
    public class BubbleSort
    {
        public static void SortRecursive(int[] input, int iteraties)
        {
            if (iteraties >= 1)
            {
                for (global::System.Int32 i = 0; iteraties -1 > i; i++)
                {
                    int item1 = input[i];
                    int item2 = input[i + 1];
                    if (item1 > item2)
                    {
                        input[i] = item2;
                        input[i + 1] = item1;
                    }
                }
                iteraties--;
                SortRecursive(input, iteraties);
            }
        }
    }
}
