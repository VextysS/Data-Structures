using Datastructures_ClassLibrary.Helpers;
using System.Collections.Generic;
using Gen =Datastructures_ClassLibrary.Generics;

namespace Datastructures_ClassLibrary.Generics.Tests
{
    [TestClass()]
    public class QueueTests
    {
        [TestMethod()]
        public void QueueWithIntegerTest()
        {
            int[] list = new int[] { 15, 22, 63, 1, 8 };
            Gen.Queue<int> q = new Gen.Queue<int>();

            Assert.AreEqual(0, q.Count);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

            Assert.AreEqual(list.Length, q.Count);

            foreach (var item in list)
            {
                Assert.AreEqual(item, q.Dequeue());
            }

            Assert.AreEqual(0, q.Count);
        }

        [TestMethod()]
        public void QueueWithStringTest()
        {
            string[] list = new string[] { "pikatchu", "charaard", "bolbesaur", "ivi" };
            Gen.Queue<string> q = new Gen.Queue<string>();

            Assert.AreEqual(0, q.Count);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

            Assert.AreEqual(list.Length, q.Count);

            foreach (var item in list)
            {
                Assert.AreEqual(item, q.Dequeue());
            }

            Assert.AreEqual(0, q.Count);
        }

        [TestMethod()]
        public void QueueWithCarTest() 
        {
            Car[] list = new Car[] {
                new Car { Brand = "Toyota", Model = "Corolla", Color = "White", Year = 2018, Kilometers = 75000, Fuel = FuelType.Petrol },
                new Car { Brand = "Tesla", Model = "Model 3", Color = "Black", Year = 2022, Kilometers = 20000, Fuel = FuelType.Electric },
                new Car { Brand = "Volkswagen", Model = "Golf", Color = "Blue", Year = 2016, Kilometers = 120000, Fuel = FuelType.Diesel },
                new Car { Brand = "BMW", Model = "3 Series", Color = "Grey", Year = 2020, Kilometers = 50000, Fuel = FuelType.Petrol },
                new Car { Brand = "Ford", Model = "Focus", Color = "Red", Year = 2015, Kilometers = 140000, Fuel = FuelType.Diesel }
            };

            Gen.Queue<Car> q = new Gen.Queue<Car>();

            Assert.AreEqual(0, q.Count);

            foreach (var item in list)
            {
                q.Enqueue(item);
            }

            Assert.AreEqual(list.Length, q.Count);

            foreach (var item in list)
            {
                Assert.AreEqual(item, q.Dequeue());
            }

            Assert.AreEqual(0, q.Count);
        }
    }
}