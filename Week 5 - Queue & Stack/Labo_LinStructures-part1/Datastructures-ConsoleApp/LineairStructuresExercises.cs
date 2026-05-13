using Datastructures_ClassLibrary.LineairStructures;


namespace Datastructures_ConsoleApp
{
    public class LineairStructuresExercises
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
                Console.WriteLine("'C' voor Calculator");
                Console.WriteLine("'D' voor 2 Queue oefening");
                Console.WriteLine("'R' om een zin om te keren met Stack");
                Console.WriteLine("");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "U":
                        TestQueue();
                        break;
                    case "S":
                        TestStack();
                        break;
                    case "C":
                        SumCalculator();
                        break;
                    case "D":
                        DoubleQueue();
                        break;
                    case "R":
                        ReverseText();
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

        private static void TestQueue()
        {
            Console.WriteLine("Geef een aantal getallen in. Druk [enter] om te eindigen");

            string input = "";
            Queue q = new Queue();

            do
            {
                input = Console.ReadLine();
                if (input != "")
                    q.Enqueue(int.Parse(input));
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

        private static void SumCalculator()
        {
            Queue q = new Queue();

            Console.WriteLine("Som berekening");
            Console.WriteLine("Geef getallen in en 'Q' om te stoppen.");
            string input = "";
            do
            {
                input = Console.ReadLine();
                if (input.ToUpper() != "Q")
                {
                    int number = int.Parse(input);
                    q.Enqueue(number);
                }
            }
            while (input.ToUpper() != "Q");

            int sum = 0;
            while (!q.IsEmpty)
            {
                sum += q.Dequeue();
            }

            Console.WriteLine("De som is " + sum);
        }

        private static void DoubleQueue()
        {
            QueueString q1= new QueueString();
            QueueString q2 = new QueueString();

            Console.WriteLine("Geef 10 woorden in");

            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                if(input.Length <5)
                {
                    q1.Enqueue(input);
                }
                else
                {
                    q2.Enqueue(input);
                }
            }

            Console.WriteLine("Alle woorden kleiner of gelijk aan 5 karakters");
            PrintQueue(q1);
            Console.WriteLine("Alle langere woorden");
            PrintQueue(q2);

        }

        private static void PrintQueue(QueueString q)
        {
            while(!q.IsEmpty)
            {
                Console.WriteLine(q.Dequeue()); 
            }
        }


        private static void ReverseText()
        {
            Console.WriteLine("Geef een zin in");
            string sentence = Console.ReadLine();

            StackString s = new StackString();
            string[] words = sentence.Split(" ");
            foreach (var word in words)
            {
                s.Push(word);
            }

            while(!s.IsEmpty)
            {
                Console.Write(s.Pop() + " ");
            }
            Console.WriteLine();
        }
    }
}
