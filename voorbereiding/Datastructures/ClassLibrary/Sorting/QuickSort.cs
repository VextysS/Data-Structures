using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting
{
    public class Quicksort
    {
        public static void Sort(int[] list)
        {
            Sort(list, 0, list.Length - 1);
        }

        private static void Sort(int[] list, int lowerIndex, int higherIndex)
        {
            var i = lowerIndex;
            var j = higherIndex;

            //Get value of middle index 
            int pivot = list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                //while left side values smaller then pivot value -> go to next left side value to check
                while (list[i] < pivot)
                    i++;
                //while right side value bigger then pivot -> go to next right side value
                while (list[j] > pivot)
                    j--;

                //If it reaches this, we already know i or j is in the wrong place
                //Checks if they already been swapped
                if (i <= j)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                    i++;
                    j--;
                }
            }

            //It chooses new pivot and sorts again if contains more than one element!

            //left side contains values before pivot
            if (lowerIndex < j)
                Sort(list, lowerIndex, j);
            //right side contains values after the pivot
            if (i < higherIndex)
                Sort(list, i, higherIndex);
        }

        public static void Sort(double[] list)
        {
            Sort(list, 0, list.Length - 1);
        }

        private static void Sort(double[] list, int lowerIndex, int higherIndex)
        {
            var i = lowerIndex;
            var j = higherIndex;


            int pivot = (int)list[lowerIndex + (higherIndex - lowerIndex) / 2];

            while (i <= j)
            {
                while (list[i] < pivot)
                    i++;
                while (list[j] > pivot)
                    j--;


                if (Comparer(i, j) == 1)
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

        public static int Comparer(double indexOfLowerSide, double indexOfHigherSide)
        {
            if (indexOfLowerSide <= indexOfHigherSide)
            {
                return +1;
            }
            else
            {
                return -1;
            }
        }
    }
}
