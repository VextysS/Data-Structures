using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Sorting
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

        public static void Sort(string[] list)
        {
            if (list.Length <= 1)
            {
                return;
            }

            string[] first = new string[list.Length / 2];
            string[] second = new string[list.Length - first.Length];
            Array.Copy(list, 0, first, 0, first.Length);
            Array.Copy(list, first.Length, second, 0, second.Length);

            Sort(first);
            Sort(second);

            int firstIndex = 0, secondIndex = 0;
            int index = 0;
            while (firstIndex < first.Length || secondIndex < second.Length)
            {
                if (secondIndex == second.Length || (firstIndex < first.Length && Compare(first[firstIndex],second[secondIndex]) <= 0))
                {
                    list[index++] = first[firstIndex++];
                }
                else
                {
                    list[index++] = second[secondIndex++];
                }
            }
        }


        /// <summary>
        /// Compare the 2 words and return a value that indicates their sort order.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns>
        /// Return -1 if s1 preceeds s2
        /// Return +1 of s1 follows s2 
        /// Return 0 if both words occur in the same position
        /// </returns>
        private static int Compare(string s1, string s2)
        {
            //This compares by their length in ascending order
            if (s1.Length < s2.Length)
                return -1;
            else if (s1.Length > s2.Length)
                return 1;
            else
                //if length is indentical then sort alphabetically
                return string.Compare(s1, s2);
        }


    }
}
