using System;

namespace Datastructures_ClassLibrary.Helpers;
public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public int Year { get; set; }
    public int Kilometers { get; set; }
    public FuelType Fuel  { get; set; }

    public static bool operator >(Car c1, Car c2)
    {
        if (c1.Year > c2.Year)
            return true;
        else if (c1.Year < c2.Year)
            return false;
        else if (c1.Year == c2.Year)
        {
            if (c1.Kilometers < c2.Kilometers)
                return true;
        }
        return false;
    }

    public static bool operator <(Car c1, Car c2)
    {
        //We should also implement this method the same way as the > operator
        //but because we do not use it in this exercise it is not important now.
        return false;
    }
}

public enum FuelType
{ 
    Petrol,
    Diesel,
    Electric,
    Hydrogen
}
