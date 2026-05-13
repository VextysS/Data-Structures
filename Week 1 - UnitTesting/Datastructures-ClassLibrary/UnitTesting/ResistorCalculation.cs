using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.UnitTesting
{
    public class ResistorCalculation
    {
        /// <summary>
        /// Calculate the total resistorvalue (in ohm).
        /// </summary>
        /// <param name="ring1">color for ring 1</param>
        /// <param name="ring2">color for ring 2</param>
        /// <param name="ring3">color for ring 3</param>
        /// <returns></returns>
        public static double CalculateResistor(Color ring1, Color ring2, Color ring3)
        {
            int r1 = 0, r2 = 0, r3 = 0;

            switch (ring1)
            {
                case Color.Black:
                    r1 = 0;
                    break;
                case Color.Brown:
                    r1 = 1;
                    break;
                case Color.Red:
                    r1 = 2;
                    break;
                case Color.Orange:
                    r1 = 3;
                    break;
                case Color.Yellow:
                    r1 = 4;
                    break;
                case Color.Green:
                    r1 = 5;
                    break;
                case Color.Blue:
                    r1 = 6;
                    break;
                case Color.Purple:
                    r1 = 7;
                    break;
                case Color.Grey:
                    r1 = 8;
                    break;
                case Color.White:
                    r1 = 9;
                    break;
                default:
                    break;
            }

            switch (ring2)
            {
                case Color.Black:
                    r2 = 0;
                    break;
                case Color.Brown:
                    r2 = 1;
                    break;
                case Color.Red:
                    r2 = 2;
                    break;
                case Color.Orange:
                    r2 = 3;
                    break;
                case Color.Yellow:
                    r2 = 4;
                    break;
                case Color.Green:
                    r2 = 5;
                    break;
                case Color.Blue:
                    r2 = 6;
                    break;
                case Color.Purple:
                    r2 = 7;
                    break;
                case Color.Grey:
                    r2 = 8;
                    break;
                case Color.White:
                    r2 = 9;
                    break;
                default:
                    break;
            }

            switch (ring3)
            {
                case Color.Black:
                    r3 = 0;
                    break;
                case Color.Brown:
                    r3 = 1;
                    break;
                case Color.Red:
                    r3 = 2;
                    break;
                case Color.Orange:
                    r3 = 3;
                    break;
                case Color.Yellow:
                    r3 = 4;
                    break;
                case Color.Green:
                    r3 = 5;
                    break;
                case Color.Blue:
                    r3 = 6;
                    break;
                case Color.Purple:
                    r3 = 7;
                    break;
                case Color.Grey:
                    r3 = 8;
                    break;
                case Color.Silver:
                    r3 = -2;
                    break;
                default:
                    break;
            }

            double waarde = (r1 * 10 + r2) * Math.Pow(10, r3);
            return waarde;
        }
    }

    public enum Color
    {
        Black,
        Brown,
        Red,
        Orange,
        Yellow,
        Green,
        Blue,
        Purple,
        Grey,
        White,
        Silver
    }
}
