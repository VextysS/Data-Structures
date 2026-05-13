using System;
using Datastructures_ClassLibrary.Helpers;

namespace Datastructures_ClassLibrary.Sorting;

public class Selectionsort
{
    /// <summary>
    /// Selection sort for integers
    /// </summary>
    /// <param name="input"></param>
    public static void Sort(int[] input)
    {
        int minimumIndex = 0;

        for (int i = 0; i < input.Length - 1; i++)      // iterations
        {
            minimumIndex = i;
            for (int j = i + 1; j < input.Length; j++)  //go left to right
            {
                if (input[j] < input[minimumIndex])     //compare: check if smaller than min. value
                    minimumIndex = j;                   //remember the index of the smallest value
            }
            if (minimumIndex != i)                      //swap required ?
            {
                int temp = input[i];                    //do the swap 
                input[i] = input[minimumIndex];
                input[minimumIndex] = temp;
            }
        }
    }

    /// <summary>
    /// Selection sort for strings
    /// strings cannot be compared with < or >, we must use String.compare 
    /// </summary>
    /// <param name="input"></param>
    public static void Sort(string[] input)
    {
        int minimumIndex = 0;

        for (int i = 0; i < input.Length - 1; i++)
        {
            minimumIndex = i;
            for (int j = i + 1; j < input.Length; j++)
            {
                if (String.Compare(input[j], input[minimumIndex]) < 0)  //compare for strings cannot be done with <
                    minimumIndex = j;
            }
            if (minimumIndex != i)
            {
                string temp = input[i];
                input[i] = input[minimumIndex];
                input[minimumIndex] = temp;
            }
        }
    }
}
