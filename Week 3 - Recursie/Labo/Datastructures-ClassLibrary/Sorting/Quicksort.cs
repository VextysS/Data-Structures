using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
{
    public class Quicksort
    {
        public static void Sort(int[] list)
        {
            if (list == null || list.Length == 0)
            {
                return;
            }

            Sort(list, 0, list.Length - 1);
        }

        private static void Sort(int[] list, int lowerIndex, int higherIndex)
        {
            var i = lowerIndex;
            var j = higherIndex;

            int pivot = list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (list[i] < pivot)
                    i++;
                while (list[j] > pivot)
                    j--;

                if (i <= j)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            if (lowerIndex < j)
                Sort(list, lowerIndex, j);
            if (i < higherIndex)
                Sort(list, i, higherIndex);
        }

        public static void Sort(double[] list)
        {
            if (list == null || list.Length == 0)
            {
                return;
            }

            Sort(list, 0, list.Length - 1);
        }

        private static void Sort(double[] list, int lowerIndex, int higherIndex)
        {
            var i = lowerIndex;
            var j = higherIndex;

            double pivot = list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (Compare(list[i], pivot) < 0)
                    i++;
                while (Compare(list[j], pivot) > 0)
                    j--;

                if (i <= j)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }
            if (lowerIndex < j)
                Sort(list, lowerIndex, j);
            if (i < higherIndex)
                Sort(list, i, higherIndex);
        }


        /// <summary>
        /// Compare the 2 numbers and return a value that indicates their sort order.
        /// </summary>
        /// <param name="n1">number 1</param>
        /// <param name="n2">number 2</param>
        /// <returns>
        /// Return -1 if n1 preceeds n2
        /// Return +1 of n1 follows n2 
        /// Return 0 if both numbers occur in the same position.
        /// </returns>
        private static int Compare(double n1, double n2)
        {
            if (n1 > n2)
                return 1;
            else if (n1 < n2)
                return -1;
            else
                return 0;
        }
    }
}
