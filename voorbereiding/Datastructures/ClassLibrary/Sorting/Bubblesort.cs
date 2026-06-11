using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_voorbereiding.Sorting
{
    public class Bubblesort
    {
        /// <summary>
        /// Sort the given input (list of integers) in ascending order 
        /// (from smallest to the largest number)
        /// The list is sorted 'in-place' and since an array is passed
        /// 'by-reference' there is no return value
        /// </summary>
        /// <param name="input">list of numbers</param>
        public static void Sort(int[] input)
        {
            Stopwatch sw = Stopwatch.StartNew();

            int iteraties = input.Length - 1;
            sw.Start();
            while (iteraties >= 1) 
            {
                for (global::System.Int32 i = 0; iteraties > i; i++)
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
            }
            sw.Stop();
            long timeInMilliseconds = sw.ElapsedMilliseconds;
        }

        /// <summary>
        /// Sort the given list using the adaptive version of the
        /// bubble sort algorithm
        /// </summary>
        /// <param name="input"></param>
        /// <returns>    
        public static int SortAdaptive(int[] input)
        {
            int totalItegaties = input.Length - 1;
            int itegatiesLeft = totalItegaties;
            while (itegatiesLeft >= 1) {
                Boolean swapDone = false;
                for (global::System.Int32 i = 0; i < itegatiesLeft; i++)
                {
                    int item1 = input[i];
                    int item2 = input[i + 1];
                    if (item1 > item2)
                    {
                        input[i] = item2;
                        input[i + 1] = item1;
                        swapDone = true;
                    }
                }
                itegatiesLeft--;
                if (!swapDone)
                {
                    return totalItegaties - itegatiesLeft;
                }
            }
            return totalItegaties;
        }
    }
}
