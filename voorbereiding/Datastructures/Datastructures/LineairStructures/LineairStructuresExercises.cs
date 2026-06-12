using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures.LineairStructures
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
                Console.WriteLine("'1' voor Queue");
                Console.WriteLine("'2' voor Stack");
                Console.WriteLine("'3' voor LinkedList");

                Console.WriteLine("");
                Console.WriteLine("'Q' om te naar een ander labo te gaan");
                choice = Console.ReadLine();
                switch (choice.ToUpper())
                {
                    case "1":
                        TestQueue();
                        break;
                    case "2":
                        TestStack();
                        break;
                    case "3":
                        LinkedListDemo();
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
                    s.Push(int.Parse(input));
            }
            while (input != "");

            Console.WriteLine("Hier zijn de getallen terug in omgekeerde volgorde");
            while (s.Count != 0)
            {
                Console.WriteLine(s.Pop());
            }
        }

        private static void LinkedListDemo()
        {
            LinkedList<string> list = new LinkedList<string>();
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Geef een woord:");
                string word = Console.ReadLine();

                Console.WriteLine("Wil je het woord toevoegen: ");
                Console.WriteLine("1.op het einde? ");
                Console.WriteLine("2.na een ander woord ?");
                Console.WriteLine("3.voor een ander woord ?");
                Console.WriteLine("4.vooraan ?");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        //TODO: add the word at the correct location in the list
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("Geef het woord waar het achter moet komen:");
                            string word2 = Console.ReadLine();
                            //TODO: find the word in the list
                        }
                        while (true); //TODO: adjust so that the loop stops when the word was found
                                      //TODO: add the word at the correct location in the list
                        break;
                    case "3":
                        do
                        {
                            Console.WriteLine("Geef het woord waar het voor moet komen:");
                            string word2 = Console.ReadLine();
                            //TODO: zoek het woord op in de lijst
                        }
                        while (true); //TODO: adjust so that the loop stops when the word was found
                                      //TODO: add the word at the correct location in the list
                        break;

                        break;
                    case "4":
                        //TODO: add the word at the correct location in the list
                        break;


                }
                Console.WriteLine("De lijst: ");
                ShowLinkedList(list);

            }
        }

        private static void ShowLinkedList(LinkedList<string> list)
        {
            //TODO: show each element in the list in the console in the correct order.
        }
    }
}
