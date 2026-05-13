using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.NonLineairStructures;

namespace Datastructures_ConsoleApp
{
    public class NonLineairStructuresExercises
    {
        #region menu
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Niet-Lineaire datastructuren:");
                Console.WriteLine("'B' voor BST");

                Console.WriteLine("");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "B":
                        TestBST();
                        break;
                    default:
                        Console.WriteLine("Sorry deze oefening ken ik niet...");
                        break;
                }
            }
            while (choice != "Q");
        }
        #endregion

        static void TestBST()
        {
            Console.WriteLine("Hello World, here comes a nice Binary sorted tree !");
            Console.WriteLine();
            Console.WriteLine("Hoeveel getallen wil je aan de boom toevoegen ?");
            int amount = 0;
            int.TryParse(Console.ReadLine(), out amount);
            bool loop = true;
            //Create new Tree
            var t = new BST();
            //Fill it with some random numbers
            var rnd = RandomArrayGenerator.Generate(amount, 0, amount * 5, true);
            for (int i = 0; i < rnd.Length; i++)
            {
                t.Insert(rnd[i]);
            }

            do
            {
                Console.CursorVisible = false;
                Console.Clear();
                //Pretty print the tree with the BinaryTreePrinter
                t.Root.Print<int>();

                Console.WriteLine();
                Console.CursorVisible = true;
                //What next ?
                Console.WriteLine("Commando: Add, Remove, Find, New Tree of Quit ? (bv. A[getal]  R[getal] F[getal] N[Aantal] Q1");
                int value;
                var cmd = Console.ReadLine();
                if (int.TryParse(cmd.Substring(1), out value))
                {
                    switch (cmd[0])
                    {
                        case 'A':
                            t.Insert(value);
                            break;
                        case 'R':
                            t.Remove(value);
                            break;
                        case 'F':
                            if (t.FindNode(value) != null)
                                Console.WriteLine($"de waarde {value} is aanwezig");
                            else
                                Console.WriteLine($"de waarde {value} is NIET aanwezig");

                            System.Threading.Thread.Sleep(1000);
                            break;
                        case 'N':
                            t.Clear();
                            var rnd2 = RandomArrayGenerator.Generate(value, 0, value * 5, true);
                            for (int i = 0; i < rnd2.Length; i++)
                            {
                                t.Insert(rnd2[i]);
                            }
                            break;
                        default:
                            loop = false;
                            break;
                    }
                }
                else
                    Console.WriteLine("Gelieve een geldig getal in te geven");
            }
            while (loop);
        }
    }
}
