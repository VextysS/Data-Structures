using ConsoleApp.SortDeel1;
using Datastructures_ConsoleApp;

namespace Datastructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DataStructures");
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Type 1 -> UnitTesting");
                Console.WriteLine("Type 2 -> Deel 1 sorting");
                Console.WriteLine("Type 3 -> Recursie");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        UnitTestingExercises.Menu();
                        break;
                    case "2":
                        SortDeel1.Menu();
                        break;
                    case "3":
                        Recursie.RecursionExercises.Menu();
                        break;
                    default:
                        Console.WriteLine("Sorry, probeer nog een keer");
                        break;
                }

            }
        }
    }
}
    