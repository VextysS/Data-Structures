using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ConsoleApp
{
    public class SearchingExercises
    {
        #region menu
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Zoekalgoritmen:");
                Console.WriteLine("'L' voor LineairSearch");
                Console.WriteLine("");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "L":
                        //TestLineairSearch();
                        break;
                    case "Q":
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening ken ik niet...");
                        break;
                }
            }
            while (choice != "Q");
        }
        #endregion
    }
}
