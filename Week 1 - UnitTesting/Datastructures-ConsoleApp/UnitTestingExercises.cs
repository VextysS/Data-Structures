using Datastructures_ClassLibrary.UnitTesting;
using System;
using System.Net;
using System.Xml.Serialization;

namespace Datastructures_ConsoleApp;

public class UnitTestingExercises
{

    #region menu
    public static void Menu()
    {
        string choice = "";
        do
        {
            Console.WriteLine("Maak een keuze voor oef. Unittesting:");
            Console.WriteLine("'B' voor boeteberekening");
            Console.WriteLine("'W' voor weerstandsberekening");
            Console.WriteLine("");
            Console.WriteLine("'Q' om te naar een ander labo te gaan");
            choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "B":
                    TestFineCalculator();
                    break;
                case "W":
                    TestResistorCalculator();
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

    public static void TestFineCalculator()
    {
        Console.WriteLine("Boete berekening");
        int speedLimit = AskSpeed("Geef de maximale toegelaten snelheid");
        int actualSpeed = AskSpeed("Geef de snelheid die u reed");

        int actualFine1 = FineCalculation.CalculateFine(actualSpeed, speedLimit, false);
        int actualFine2 = FineCalculation.CalculateFine(actualSpeed, speedLimit, true);
        Console.WriteLine($"De boete bedraagt {actualFine1} euro buiten een schoolzone en {actualFine2} euro binnen een schoolzone");
    }

    private static int AskSpeed(string message)
    {
        Console.WriteLine(message);
        int speed = -1;
        do
        {
            string input = Console.ReadLine();
            if (!int.TryParse(input, out speed))
            {
                Console.WriteLine("Gelieve een getal in te geven.");
                speed = -1;
            }
            else if(speed < 0)
            {
                Console.WriteLine("Gelieve een positieve waarde in te geven.");
            }

        }
        while (speed < 0);

        return speed;
    }

    public static void TestResistorCalculator()
    {
        Color ring1, ring2, ring3;
        ring1 = AskRingColor(1);
        ring2 = AskRingColor(2);
        ring3 = AskRingColor(3);

        double value = ResistorCalculation.CalculateResistor(ring1, ring2, ring3);

        Console.WriteLine($"De waarde van deze weerstand bedraagt {value} ohm");
    }
    /// <summary>
    /// Vraag de gebruiker om een kleurnaam in te geven voor een bepaalde ring
    /// </summary>
    /// <param name="nummer">het nummer van de ring</param>
    /// <returns></returns>
    public static Color AskRingColor(int number)
    {
        while (true)
        {
            try
            {
                Console.WriteLine($"Geef kleur (in engels) voor ring {number}");
                string ring = Console.ReadLine();
                object color;
                if (Enum.TryParse(typeof(Color), ring, true, out color))
                    return (Color)color;
            }
            catch (Exception)
            {
                Console.WriteLine("Sorry, deze kleur ken ik niet.");
            }
        }
    }
}

