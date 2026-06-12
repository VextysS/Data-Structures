using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Helpers
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Year { get; set; }
        public int Kilometers { get; set; }
        public FuelType Fuel { get; set; }
    }

    public enum FuelType
    {
        Petrol,
        Diesel,
        Electric,
        Hydrogen
    }
}
