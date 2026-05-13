using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.Recursion
{
    public class Counter
    {
        public static void DoCountdown(int seconds)
        {
            if (seconds == 0)
            {
                Console.WriteLine("Takeoff");
                return;
            }
            Console.Write(seconds + "...");
            DoCountdown(seconds - 1);
        }
        public static void UpCounter(int seconds)
        {
            if (seconds == 0)
            {
                return;
            }
            // Call recursion first so it reaches 0.
            // Numbers print while the recursion returns, giving 1..2..3.. instead of 3..2..1..
            UpCounter(seconds - 1);
            Console.Write(seconds + "...");
        }
    }
}
