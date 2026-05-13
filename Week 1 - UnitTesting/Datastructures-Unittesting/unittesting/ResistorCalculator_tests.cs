using System;
using Datastructures_ClassLibrary.UnitTesting;
using Datastructures_ConsoleApp;

namespace Datastructures_Unittesting.unittesting;

[TestClass]
public class ResistorCalculator_tests
{

    [TestMethod]
    public void Test3Colors()
    {
        Color r1 = Color.Red;
        Color r2 = Color.Blue;
        Color r3 = Color.Green;

        double value = ResistorCalculation.CalculateResistor(r1, r2, r3);

        //test with source: https://resistorcolorcodecalc.com/
        //Expect 2,6 MOhm = 2600000 Ohm
        Assert.AreEqual(2600000, value);
    }

    [DataTestMethod]
    [DataRow(Color.Black, 0)]
    [DataRow(Color.Brown, 110)]
    [DataRow(Color.Red, 2200)]
    [DataRow(Color.Orange, 33000)]
    [DataRow(Color.Yellow, 440000)]
    [DataRow(Color.Green, 5500000)]
    [DataRow(Color.Blue, 66000000)]
    [DataRow(Color.Purple, 770000000)]
    [DataRow(Color.Grey, 8800000000)]

    public void Test3IdenticalColorsMultipleTests(Color r, double expectedValue)
    {
        double value = ResistorCalculation.CalculateResistor(r, r, r);

        //test with source: https://resistorcolorcodecalc.com/
        Assert.AreEqual(expectedValue, value);
    }

    [DataTestMethod]
    [DataRow(Color.Brown, Color.Black, Color.Yellow, 100000 )]
    [DataRow(Color.Green,Color.Orange, Color.Blue, 53000000)]
    [DataRow(Color.Purple, Color.Yellow, Color.Brown, 740)]
    [DataRow(Color.Orange, Color.Green, Color.Red, 3500)]
    [DataRow(Color.Blue, Color.Purple, Color.Grey, 6700000000)]
    public void Test3ColorsMultipleTests(Color r1, Color r2, Color r3, double expectedValue)
    {
        double value = ResistorCalculation.CalculateResistor(r1, r2, r3);

        //test with source: https://resistorcolorcodecalc.com/
        Assert.AreEqual(expectedValue, value);
    }
}
