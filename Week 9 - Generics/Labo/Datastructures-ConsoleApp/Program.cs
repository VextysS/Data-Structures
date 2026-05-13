namespace Datastructures_ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Datastructures labs !");

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Maak een keuze voor een hoofdstuk / labo:");
            Console.WriteLine("'U' voor Unit testing");
            Console.WriteLine("'S' voor Sorteeralgoritmen");
            Console.WriteLine("'R' voor Recursie");
            Console.WriteLine("'Z' voor Zoekalgoritmen");
            Console.WriteLine("'L' voor lineare datastructuren (queue, stack, linked list)");
            Console.WriteLine("'N' voor niet-lineare datastructuren (BST)");
            Console.WriteLine("'G' voor Generics");
            Console.WriteLine("'C' voor Comparers");
            Console.WriteLine("'.' voor .NET structuren");

            string choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                //TODO:Add a new choice for each lab and call its 'Menu' method
                case "U":
                    //UnitTestingExercises.Menu();
                    break;
                case "S":
                    SortingExercises.Menu();
                    break;
                case "R":
                    RecursionExercises.Menu();
                    break;
                case "L":
                    //LineairStructures.Menu();
                    break;
                case "N":
                    NonLineairStructuresExercises.Menu();
                    break;
                case "G":
                    Generics.Menu();
                    break;

                default:
                    Console.WriteLine("Sorry deze keuze wordt pas in een later labo toegevoegd");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

}
