using Datastructures_ClassLibrary.Helpers;
using Gen = Datastructures_ClassLibrary.Generics;

namespace Datastructures_ClassLibrary.Generics.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void TestStackWithInteger()
        {
            int[] list = new int[] { 100, 20, 80, 44, 1 };
            Gen.Stack<int> s = new Gen.Stack<int>();

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.IsFalse(s.IsEmpty);
            Assert.AreEqual(list.Length, s.Count);

            int index = list.Length - 1;
            while (s.Count > 0)
            {
                Assert.AreEqual(list[index], s.Pop());
                index--;
            }

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);
        }

        [TestMethod()]
        public void TestStackWithString()
        {
            string[] list = new string[] { "pikatchu", "charaard", "bolbesaur", "ivi" };
            Gen.Stack<string> s = new Gen.Stack<string>();

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.IsFalse(s.IsEmpty);
            Assert.AreEqual(list.Length, s.Count);

            int index = list.Length - 1;
            while (s.Count > 0)
            {
                Assert.AreEqual(list[index], s.Pop());
                index--;
            }

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);
        }

        [TestMethod()]
        public void TestStackWithCars()
        {
            Car[] list = new Car[] {
                new Car { Brand = "Toyota", Model = "Corolla", Color = "White", Year = 2018, Kilometers = 75000, Fuel = FuelType.Petrol },
                new Car { Brand = "Tesla", Model = "Model 3", Color = "Black", Year = 2022, Kilometers = 20000, Fuel = FuelType.Electric },
                new Car { Brand = "Volkswagen", Model = "Golf", Color = "Blue", Year = 2016, Kilometers = 120000, Fuel = FuelType.Diesel },
                new Car { Brand = "BMW", Model = "3 Series", Color = "Grey", Year = 2020, Kilometers = 50000, Fuel = FuelType.Petrol },
                new Car { Brand = "Ford", Model = "Focus", Color = "Red", Year = 2015, Kilometers = 140000, Fuel = FuelType.Diesel }
            };
            Gen.Stack<Car> s = new Gen.Stack<Car>();

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);

            foreach (var item in list)
            {
                s.Push(item);
            }

            Assert.IsFalse(s.IsEmpty);
            Assert.AreEqual(list.Length, s.Count);

            int index = list.Length - 1;
            while (s.Count > 0)
            {
                Assert.AreEqual(list[index], s.Pop());
                index--;
            }

            Assert.AreEqual(0, s.Count);
            Assert.IsTrue(s.IsEmpty);
        }
    }
}