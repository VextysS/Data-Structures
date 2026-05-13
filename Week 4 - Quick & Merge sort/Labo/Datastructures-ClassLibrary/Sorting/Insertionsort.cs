using System;

namespace Datastructures_ClassLibrary.Sorting;

public class Insertionsort
{
    /// <summary>
    /// order a list of numbers in descending order
    /// the sort order is determined only by the 'compare'
    /// </summary>
    /// <param name="input"></param>
    public static void Sort(int[] input)
    {
        for (int i = 1; i < input.Length; i++)                  //iterations
        {
            int current = input[i];                             //this is the value that we want to set correctly
            int newIndex = i;
            while (newIndex > 0)                                //go from left to right
            {
                if (current > input[newIndex - 1])              //compare
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

    /// <summary>
    /// Order a list op words by their length in ascending order
    /// The compare must do a compare based on the length of the words
    /// </summary>
    /// <param name="input"></param>
    public static void Sort(string[] input)
    {
        for (int i = 1; i < input.Length; i++)
        {
            string current = input[i];
            int newIndex = i;
            while (newIndex > 0)
            {
                if (Compare(current, input[newIndex - 1]) < 0) //compare 
                {
                    input[newIndex] = input[newIndex - 1];
                    newIndex--;
                }
                else
                    break;
            }
            input[newIndex] = current;
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
