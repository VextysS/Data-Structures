using ClassLibrary.Sorting;
using Examen_voorbereiding.Helpers;
using Examen_voorbereiding.Sorting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.SortDeel1
{
    public class SortDeel1
    {
       public static void Menu()
       {
            string choice = "";
            do
            {
                Console.WriteLine("type B0 -> voor Allemaal");
                Console.WriteLine("type B1 -> voor Bubblesort");
                Console.WriteLine("type B2 -> voor Adaptief Bubblesort");
                Console.WriteLine("type B3 -> voor SelectionSort");
                choice = Console.ReadLine();

                switch (choice.ToUpper())
                {
                    case "B1":
                        int[] r = { 1, 8, 3, 6, 2 };
                        Bubblesort.Sort(r);
                        foreach (var item in r)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "B2":
                        BubbleMethode(10);
                        break;
                    case "B3":
                        SelectionMethode(10);
                        break;
                    case "B0":
                        Console.WriteLine("Hoeveel nummers?");
                        int number = int.Parse(Console.ReadLine());

                        QuickMethode(number);
                        BubbleMethode(number);
                        SelectionMethode(number);
                        InsertionMethode(number);
                        break;
                }
            } while (choice != "Q");
       }
        public static void QuickMethode(int amount)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] generatedList = RandomArrayGenerator.Generate(amount, 0, 1000, false);
            Quicksort.Sort(generatedList);

            sw.Stop();
            Console.WriteLine("Quicksort took: " + sw.ElapsedMilliseconds + " ms");
        }
        public static void BubbleMethode(int amount)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] generatedList = RandomArrayGenerator.Generate(amount, 0, 1000, false);
            Bubblesort.SortAdaptive(generatedList);

            sw.Stop();
            Console.WriteLine("Bubblesort took: " + sw.ElapsedMilliseconds + " ms");
        }
        public static void SelectionMethode(int amount)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] generatedList = RandomArrayGenerator.Generate(amount, 0, 1000, false);
            Selectionsort.Sort(generatedList);

            sw.Stop();
            Console.WriteLine("Selectionsort took: " + sw.ElapsedMilliseconds + " ms");
        }
        public static void InsertionMethode(int amount)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] generatedList = RandomArrayGenerator.Generate(amount, 0, 1000, false);
            Insertionsort.Sort(generatedList);

            sw.Stop();
            Console.WriteLine("Insertionsort took: " + sw.ElapsedMilliseconds + " ms");
        }

        public static void MergeMethode(int amount)
        {
            Stopwatch sw = Stopwatch.StartNew();
            sw.Start();

            int[] generatedList = RandomArrayGenerator.Generate(amount, 0, 1000, false);
            Mergesort.Sort(generatedList);

            sw.Stop();
            Console.WriteLine("Mergesort took: " + sw.ElapsedMilliseconds + " ms");
        }
    }
}
