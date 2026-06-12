using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting
{
    public class Mergesort
    {
        public static void Sort(int[] list)
        {
            if (list.Length <= 1)
            {
                return;
            }

            int[] first = new int[list.Length / 2];
            int[] second = new int[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            Sort(first);
            Sort(second);

            int firstIndex = 0, secondIndex = 0;
            int index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && first[firstIndex] <= second[secondIndex]))
                {
                    list[index++] = first[firstIndex++];
                }
                else
                {
                    list[index++] = second[secondIndex++];
                }
            }
        }
    }
}
