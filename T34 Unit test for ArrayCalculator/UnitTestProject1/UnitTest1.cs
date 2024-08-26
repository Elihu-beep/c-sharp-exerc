using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ArrayCalculatorTests
{
    [TestMethod]
    public void TestSum()
    {
        double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
        Assert.AreEqual(25.6, ArrayCalculator.Sum(array));
    }
}
