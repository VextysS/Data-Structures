using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Sorting
{
    public class Insertionsort
    {
        public static void Sort(int[] input)
        {
            for (int i = 1; i < input.Length; i++)   //iterations
            {
                int current = input[i];                             //this is the value that we want to set correctly
                int newIndex = i;
                while (newIndex > 0)                                //go from left to right
                {
                    if (current < input[newIndex - 1])              //compare
                    {
                        input[newIndex] = input[newIndex - 1];      //swap 2 values if needed
                        newIndex--;
                    }
                    else
                        break;
                }
                input[newIndex] = current;                          //put the current value in the correct place
            }
        }

        public static void Sort(string[] input)
        {
            for (int i = 1; i < input.Length; i++)
            {
                //Iteratie 1 -> neem value van 2de attribuut en vergelijk met vorige
                //Pak current value en de index van het volgende
                string currentValue = input[i];
                int indexToCompareToPrevious = i;
                while (indexToCompareToPrevious > 0) 
                {
                    if (currentValue.Length < input[indexToCompareToPrevious - 1].Length)
                    {
                        input[indexToCompareToPrevious] = input[indexToCompareToPrevious - 1];
                        indexToCompareToPrevious--;
                    }
                    else
                        break;
                }
                input[indexToCompareToPrevious] = currentValue;
            }
        }
    }
}
