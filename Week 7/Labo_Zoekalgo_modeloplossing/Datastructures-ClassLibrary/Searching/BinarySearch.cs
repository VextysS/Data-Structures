using Datastructures_ClassLibrary.Sorting;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Searching
{
    public class BinarySearch
    {
        /// <summary>
        /// Find the given value in the list using the binary search algoritm.
        /// Note that the given list must be sorted ascending before using this method !
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns>the index in the array where the value was found, or -1 if not found</returns>
        public static int Find(int[] list, int value)
        {
            return Find(list, value, 0, list.Length - 1);
        }

        private static int Find(int[] list, int value, int minIndex, int maxIndex)
        {
            //base case: value was not found in the list
            if (minIndex > maxIndex)
                return -1;

            //TODO: find middle Index of the list
            int middleIndex = minIndex + (maxIndex - minIndex) / 2;

            //Check if that value == value => return the index (value was found) !
            if (list[middleIndex] == value)
                return middleIndex;

            //If that value is greater, repeat the same in the left side of the list
            else if (list[middleIndex] > value)
                return Find(list, value, minIndex, middleIndex - 1); 

            //If that value is smaller, repeat the same in th right side of the list
            else //if (list[middleIndex] < value)
                return Find(list, value, middleIndex  + 1, maxIndex);
        }


        /// <summary>
        /// Find the given value in de list using the binary search.
        /// The list must be sorted by the insertionsort, using a comparer helper method
        /// that sorts words by their length ascending and secondly alphabetically (for same length words)
        /// This means that we must use the same comparer here to find the values
        /// </summary>
        /// <param name="list"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int Find(string[] list, string value)
        {
            return Find(list, value, 0, list.Length - 1);
        }

        private static int Find(string[] list, string value, int minIndex, int maxIndex)
        {
            //base case: value was not found in the list
            if (minIndex > maxIndex)
                return -1;

            //TODO: find middle Index of the list
            int middleIndex = minIndex + (maxIndex - minIndex) / 2;

            int compareResult = Insertionsort.Compare(list[middleIndex], value);

            //Check if that value == value => return the index (value was found) !
            if (compareResult == 0)
                return middleIndex;

            //If that value is greater, repeat the same in the left side of the list
            else if (compareResult > 0)
                return Find(list, value, minIndex, middleIndex - 1);

            //If that value is smaller, repeat the same in th right side of the list
            else //if (list[middleIndex] < value)
                return Find(list, value, middleIndex + 1, maxIndex);
        }

    }
}
