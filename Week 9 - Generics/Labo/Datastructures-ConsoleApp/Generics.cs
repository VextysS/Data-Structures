using Gen = Datastructures_ClassLibrary.Generics;


namespace Datastructures_ConsoleApp
{
    public class Generics
    {
        #region menu
        public static void Menu()
        {
            string choice = "";
            do
            {
                Console.WriteLine("Maak een keuze voor oef. Lineaire datastructuren:");
                Console.WriteLine("'U' voor Queue");
                Console.WriteLine("'S' voor Stack");
                Console.WriteLine("");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "U":
                        Console.WriteLine("Kies type: 1=int, 2=double, 3=string");
                        var typeChoice = Console.ReadLine();

                        switch (typeChoice)
                        {
                            case "1":
                                TestQueue<int>(int.Parse);
                                break;
                            case "2":
                                TestQueue<double>(double.Parse);
                                break;
                            case "3":
                                TestQueue<string>(s => s);
                                break;
                        }
                    break;
                    case "S":
                        TestStack();
                        break;
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

        private static void TestQueue<T>(Func<string, T> parser)
        {
            Console.WriteLine("Geef een aantal waardes in. Druk [enter] om te eindigen");

            string input = "";
            Gen.Queue<T> q = new Gen.Queue<T>();

            do
            {
                input = Console.ReadLine();
                if (input != "")
                    q.Enqueue(parser(input));
            }
            while (input != "");

            Console.WriteLine("Hier zijn de getallen terug in dezelfde volgorde");
            while (q.Count != 0)
            {
                Console.WriteLine(q.Dequeue());
            }
        }

        private static void TestStack()
        {
            Console.WriteLine("Geef een aantal getallen in. Druk [enter] om te eindigen");

            string input = "";
            System.Collections.Stack s = new System.Collections.Stack();

            do
            {
                input = Console.ReadLine();
                if (input != "")
                    s.Push(input);
            }
            while (input != "");

            Console.WriteLine("Hier zijn de getallen terug in omgekeerde volgorde");
            while (s.Count != 0)
            {
                Console.WriteLine(s.Pop());
            }
        }
    }
}
