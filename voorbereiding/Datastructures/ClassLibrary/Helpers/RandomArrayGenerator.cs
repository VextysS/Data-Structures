using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_voorbereiding.Helpers
{
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
            List<int> array = new List<int>();
            Random random = new Random();
            while (amount > array.Count)
            {
                int value = random.Next(min, max);
                if (unique)
                {
                    if (!array.Contains(value))
                    {
                        array.Add(value);
                    }
                }
                else
                {
                    array.Add(value);
                }
            }
            return array.ToArray();
        }
    }
}
