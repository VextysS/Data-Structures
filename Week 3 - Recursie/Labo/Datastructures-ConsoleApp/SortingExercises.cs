using Datastructures_ClassLibrary.Helpers;
using Datastructures_ClassLibrary.Sorting;
using System;
using System.Diagnostics;

namespace Datastructures_ConsoleApp;

public class SortingExercises
{
    #region menu
    public static void Menu()
    {
        string choice = "";
        do
        {
            Console.WriteLine("Maak een keuze voor oef. sorteeralgoritmen:");
            Console.WriteLine("'B' voor bubblesort");
            Console.WriteLine("'P' voor meet performantie (BS, SS & IS + QS & MS)");

            Console.WriteLine("");
            Console.WriteLine("'Q' om te naar een ander labo te gaan");

            choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "B":
                    TestBubbleSort();
                    break;
                case "P":
                    MeasureAlgoritmesPart1();
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


    private static void TestBubbleSort()
    {
        Console.WriteLine("Geef een aantal getallen in (druk [Enter] om te stoppen).");
        List<int> list = new List<int>();
        string input = "";
        do
        {
            input = Console.ReadLine();
            int inputAsNumber;
            if (int.TryParse(input, out inputAsNumber))
                list.Add(inputAsNumber);
        }
        while (input != "");
        int[] arrayList = list.ToArray();
        //TODO: Call here the sorting algorithm
        Bubblesort.Sort(arrayList);
        
        foreach (int n in arrayList)
        {
            Console.Write($"{n} ");
        }
        Console.WriteLine();
    }

    private static void MeasureAlgoritmesPart1()
    {
        int amount = 0;

        do
        {
            Console.WriteLine("Hoeveel elementen wenst u te sorteren ?");
            string input = Console.ReadLine();
            if (!int.TryParse(input, out amount))
                Console.WriteLine("geef een geldig getal in");
        }
        while (amount == 0);

        Stopwatch s = new Stopwatch();
        int[] list = RandomArrayGenerator.Generate(amount, 0, 100000000);
        int[] list2 = (int[])list.Clone();
        int[] list3 = (int[])list.Clone();
        int[] list4 = (int[])list.Clone();

        Console.WriteLine($"{list.Length} willekeurige getallen worden gesorteerd.....");
        s.Start();
        Bubblesort.Sort(list);
        s.Stop();
        Console.WriteLine($"Bubble sort had {s.ElapsedMilliseconds} ms nodig");

        s.Reset();
        s.Start();
        Selectionsort.Sort(list2);
        s.Stop();
        Console.WriteLine($"Selection sort had {s.ElapsedMilliseconds} ms nodig");

        s.Reset();
        s.Start();
        Insertionsort.Sort(list3);
        s.Stop();
        Console.WriteLine($"Insertion sort had {s.ElapsedMilliseconds} ms nodig");

        MeasureAlgoritmesPart2(list4);
    }

    private static void MeasureAlgoritmesPart2(int[] list)
    {
        Stopwatch s = new Stopwatch();
        int[] list2 = (int[])list.Clone();

        Console.WriteLine($"{list.Length} willekeurige getallen worden gesorteerd.....");
        s.Start();
        Quicksort.Sort(list);
        s.Stop();
        Console.WriteLine($"Quick sort had {s.ElapsedMilliseconds} ms nodig");

        s.Reset();
        s.Start();
        Mergesort.Sort(list2);
        s.Stop();
        Console.WriteLine($"Merge sort had {s.ElapsedMilliseconds} ms nodig");
    }

}
