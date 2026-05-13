using Datastructures_ClassLibrary.Helpers;
using System;

namespace Datastructures_ClassLibrary.Sorting;

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
        if (input == null)
            return;

        int iterations = input.Length - 1;
        while (iterations >= 1)                     // iterations
        {
            for (int g = 0; g < iterations; g++)    // go from left to right in the array
            {
                if (input[g] > input[g + 1])        // compare each value with the next one
                {
                    int temp = input[g];            // swap the 2 values
                    input[g] = input[g + 1];
                    input[g + 1] = temp;
                }
            }
            iterations--;
        }
    }

    /// <summary>
    /// Sort the given list using the adaptive version of the
    /// bubble sort algorithm
    /// </summary>
    /// <param name="input"></param>
    /// <returns>the number of iterations that were done</returns>
    public static int SortAdaptive(int[] input)
    {
        int totalIterations = input.Length - 1;
        int iterationsLeft = totalIterations;
        while (iterationsLeft >= 1)                     // iterations
        {
            bool swapDone = false;                  //swap done helper
            for (int g = 0; g < iterationsLeft; g++)    // go from left to right in the array
            {
                if (input[g] > input[g + 1])        // compare
                {
                    int temp = input[g];            // swap
                    input[g] = input[g + 1];
                    input[g + 1] = temp;
                    swapDone = true;                //at least one swap was done in this iteration
                }
            }
            iterationsLeft--;
            //if no swap was done in this iteration, 
            //the list is already sorted and the algorithm can stop here.
            if (!swapDone)
            {
                //return the number of iterations done 
                return totalIterations - iterationsLeft;
            }
        }
        //all iterations were done !
        return totalIterations;
    }

    /// <summary>
    /// Sort the given input (list of doubles) in ascending order 
    /// (from smallest to the largest number)
    /// The list is sorted 'in-place' and since an array is passed
    /// 'by-reference' there is no return value
    /// </summary>
    /// <param name="input">list of numbers</param>
    public static void Sort(double[] input)
    {
        if (input == null)
            return;

        int iterations = input.Length - 1;
        while (iterations >= 1)                     // iterations
        {
            for (int g = 0; g < iterations; g++)    // go from left to right in the array
            {
                if (Compare(input[g], input[g + 1]) > 0)      // compare each value with the next one
                {
                    double temp = input[g];            // swap the 2 values
                    input[g] = input[g + 1];
                    input[g + 1] = temp;
                }
            }
            iterations--;
        }
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
            return +1;
        else if (n1 < n2)
            return -1;
        else 
            return 0;
    }

    /// <summary>
    /// Sort the given input (list of doubles) in ascending order 
    /// (from smallest to the largest number)
    /// The list is sorted 'in-place' and since an array is passed
    /// 'by-reference' there is no return value
    /// </summary>
    /// <param name="input">list of numbers</param>
    public static void Sort(Car[] input)
    {
        if (input == null)
            return;

        int iterations = input.Length - 1;
        while (iterations >= 1)                     // iterations
        {
            for (int g = 0; g < iterations; g++)    // go from left to right in the array
            {
                if (Compare(input[g], input[g + 1]) > 0)      // compare each value with the next one
                {
                    Car temp = input[g];            // swap the 2 values
                    input[g] = input[g + 1];
                    input[g + 1] = temp;
                }
            }
            iterations--;
        }
    }

    /// <summary>
    /// Compare the 2 cars and return a value that indicates their sort order.
    /// </summary>
    /// <param name="c1">car 1</param>
    /// <param name="c2">car 2</param>
    /// <returns>
    /// Return -1 if c1 preceeds c2
    /// Return +1 of c1 follows c2 
    /// Return 0 if both cars occur in the same position.
    /// </returns>
    private static int Compare(Car c1, Car c2)
    {
        //if (c1.Year < c2.Year)
        //    return +1;
        //else if (c1.Year > c2.Year)
        //    return -1;
        //else
        //{
        //    if (c1.Kilometers < c2.Kilometers)
        //        return -1;
        //    else if (c1.Kilometers > c2.Kilometers)
        //        return 1;
        //    else
        //        return 0;
        //}

        //We can replace the code above with the code below
        //If we implement < and > operator overloading in the Car class !
        if (c1 < c2)
            return -1;
        else if (c2 > c1)
            return 1;
        else 
            return 0;
    }
}
