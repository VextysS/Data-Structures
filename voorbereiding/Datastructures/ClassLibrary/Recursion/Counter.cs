using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Recursion
{
    public class Counter
    {
        public static void DoCountdown(int seconds)
        {
            if (seconds == 0)
            {
                Console.WriteLine("TakeOff");
                return;
            }

            Console.WriteLine(seconds + "...");
            /* is the same as below
            seconds--;
            DoCountdown(seconds);
            */
            DoCountdown(seconds - 1);
        }

        public static void UpCounter(int seconds)
        {
            if (seconds == 1)
            {
                return;
            }
            seconds--;
            UpCounter(seconds);
            Console.WriteLine(seconds + "...");
        }
    }
}
