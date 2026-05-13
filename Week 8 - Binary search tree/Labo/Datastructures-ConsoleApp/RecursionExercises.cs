using Datastructures_ClassLibrary.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ConsoleApp
{
    public class RecursionExercises
    {
        #region menu
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Recursie:");
                Console.WriteLine("'C' voor countdown");
                Console.WriteLine("'D' voor countup");
                Console.WriteLine("'E' voor CalculateWordLength");
                Console.WriteLine("'F' voor CalculateNumberOfDigits");
                Console.WriteLine("'G' voor SplitString");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "C":
                        TestCountdown();
                        break;
                    case "D":
                        TestCountup();
                        break;
                    case "E":
                        CalculateWordLength();
                        break;
                    case "F":
                        CalculateNumberOfDigits();
                        break;
                    case "G":
                        SplitString();
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening ken ik niet...");
                        break;
                }
            }
            while (choice != "Q");
        }
        public static void TestCountdown()
        {
            Console.WriteLine("Vanaf welk getal wenst u af te tellen ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Counter.DoCountdown(int.Parse(input));
        }
        public static void TestCountup()
        {
            Console.WriteLine("Tot welk getal wenst u op te tellen ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Counter.UpCounter(int.Parse(input));
            Console.WriteLine();
        }
        public static void CalculateWordLength()
        {
            Console.WriteLine("Welk woord wenst u de lengte te meten ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Console.WriteLine(TextHelpers.CalculateWordLength(input));
            Console.WriteLine();
        }
        public static void CalculateNumberOfDigits()
        {
            Console.WriteLine("Welk getal wenst u de lengte te meten ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            Console.WriteLine(MathHelpers.CalculateNumberOfDigits(int.Parse(input)));
            Console.WriteLine();
        }
        public static void SplitString()
        {
            Console.WriteLine("Welk woord wenst u op splitesen ?");
            string input = Console.ReadLine();
            Console.WriteLine("Hier gaan we: ");

            foreach (var item in TextHelpers.SplitString(input))
            {
                Console.Write("|" + item + "|");
            }
            Console.WriteLine();
        }
        #endregion
    }
}
