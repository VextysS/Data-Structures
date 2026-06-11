using ClassLibrary.Sorting;
using Examen_voorbereiding.Sorting;
using System;
using System.Collections.Generic;
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
                        int[] c = { 1, 8, 3, 6, 2 };
                        Bubblesort.SortAdaptive(c);
                        foreach (var item in c)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case "B3":
                        int[] d = { 1, 7, 3, 6, 2 };
                        Selectionsort.Sort(d);
                        foreach (var item in d)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                }
            }
            while (choice != "Q");
       }
    }
}
