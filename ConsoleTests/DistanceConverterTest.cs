using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using System;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class DistanceConverterTest
    {
        [TestMethod]
        public void TestMicrometresToMicrometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "micrometres";
                converter.Unit2 = "micrometres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMicrometresToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "micrometres";
                converter.Unit2 = "centimetres";
                converter.Unit1Value = 10000000000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1000000000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMicrometresToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "micrometres";
                converter.Unit2 = "metres";
                converter.Unit1Value = 10000000000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 10000000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMicrometresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "micrometres";
                converter.Unit2 = "feet";
                converter.Unit1Value = 10000000000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 32810000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMicrometresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "micrometres";
                converter.Unit2 = "miles";
                converter.Unit1Value = 10000000000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 6214;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestCentimetresToMicrometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "centimetres";
                converter.Unit2 = "micrometres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 10000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestCentimetresToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "centimetres";
                converter.Unit2 = "centimetres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestCentimetresToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "centimetres";
                converter.Unit2 = "metres";
                converter.Unit1Value = 10000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 100000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestCentimetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "centimetres";
                converter.Unit2 = "feet";
                converter.Unit1Value = 10000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 328100;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestCentimetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "centimetres";
                converter.Unit2 = "miles";
                converter.Unit1Value = 10000000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 62;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMetresToMicrometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "metres";
                converter.Unit2 = "micrometres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1000000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMetresToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "metres";
                converter.Unit2 = "centimetres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 100;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMetresToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "metres";
                converter.Unit2 = "metres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "metres";
                converter.Unit2 = "feet";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 3;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "metres";
                converter.Unit2 = "miles";
                converter.Unit1Value = 100000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 62;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestFeetToMicrometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "feet";
                converter.Unit2 = "micrometres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 304785;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestFeetToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "feet";
                converter.Unit2 = "centimetres";
                converter.Unit1Value = 10000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 304785;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "feet";
                converter.Unit2 = "metres";
                converter.Unit1Value = 10000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 3048;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestFeetToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "feet";
                converter.Unit2 = "feet";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "feet";
                converter.Unit2 = "miles";
                converter.Unit1Value = 10000;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 2;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMilesToMicrometres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "miles";
                converter.Unit2 = "micrometres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1609344000;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMilesToCentimetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "miles";
                converter.Unit2 = "centimetres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 160934;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "miles";
                converter.Unit2 = "metres";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1609;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "miles";
                converter.Unit2 = "feet";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 5280;
                Assert.AreEqual(expectedDistance, result);
            }
        }
        [TestMethod]
        public void TestMilesToMiles()
        {
            DistanceConverter converter = new DistanceConverter();
            {
                converter.Unit1 = "miles";
                converter.Unit2 = "miles";
                converter.Unit1Value = 1;
                int result = Convert.ToInt32(converter.ConverterResult(false));
                int expectedDistance = 1;
                Assert.AreEqual(expectedDistance, result);
            }
        }
    }
}
