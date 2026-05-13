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
            Console.WriteLine("'Q' voor Stack & Queue");
            Console.WriteLine("'L' voor OO datastructuren");
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
                    //SortingExercises.Menu();
                    break;
                case "R":
                    //RecursionExercises.Menu();
                    break;
                case "Z":
                    //SearchingExercises.Menu();
                    break;
                default:
                    Console.WriteLine("Sorry deze keuze wordt pas in een later labo toegevoegd");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
