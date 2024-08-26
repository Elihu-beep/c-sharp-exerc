using Microsoft.VisualStudio.TestTools.UnitTesting;
using T34_Unit_test_for_ArrayCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T34_Unit_test_for_ArrayCalculator.Tests
{
    [TestClass()]
    public class ArrayCalculatorTests
    {
        [TestMethod]
        public void TestSum()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Assert.AreEqual(25.6, ArrayCalculator.Sum(array));
        }

        [TestMethod]
        public void TestAverage()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Assert.AreEqual(25.6 / array.Length, ArrayCalculator.Average(array));
        }

        [TestMethod]
        public void TestMin()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Assert.AreEqual(-4.5, ArrayCalculator.Min(array));
        }

        [TestMethod]
        public void TestMax()
        {
            double[] array = { 1.0, 2.0, 3.3, 5.5, 6.3, -4.5, 12.0 };
            Assert.AreEqual(12.0, ArrayCalculator.Max(array));
        }
    }
}