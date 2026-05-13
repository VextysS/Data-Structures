using System;

namespace Datastructures_ClassLibrary.Helpers;

public class RandomArrayGenerator
{
    /// <summary>
    /// Generate a list of random numbers 
    /// </summary>
    /// <param name="amount">The size of the list</param>
    /// <param name="min">The minimum value</param>
    /// <param name="max">The maximum value</param>
    /// <param name="unique">No 2 numbers can be the same</param>
    /// <returns>The list with random numbers</returns>
    public static int[] Generate(int amount = 10, int min = 0, int max = 10, bool unique = false)
    {
        var list = new int[amount];
        var rnd = new Random();
        int i = 0;
        int temp = 0;

        if (unique)
        {
            if (amount > max - min)
                throw new Exception($"it is not possible to generate {amount} unique numbers between {min} and {max}");
        }

        while (i < amount)
        {
            do
            {
                temp = rnd.Next(min, max);
            }
            while (unique && list.Contains(temp));

            list[i] = temp;
            i++;
        }
        return list;
    }
}

