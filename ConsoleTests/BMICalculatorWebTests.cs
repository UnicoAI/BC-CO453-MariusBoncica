using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;  
/// <summary>
                                /// Test Unit For BMI app
                                
                                /// Author: Marius Boncica
                                /// </summary>
namespace ConsoleApp.Test
{
    [TestClass]
    public class BMICalculatorWebTests
    {
        //method to test metric low boundary of underweight
        [TestMethod]
        public void TestMetricBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 70.4;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "19.9";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        [TestMethod]
        //method to imperial test low boundary of underweight
        public void TestImperialBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 187;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "24";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary f normal bmi
        [TestMethod]
        public void TestBMIdescription()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.BMIdata();
            bmiCalculator.Bmi = 18.7;

            string actualDescription = bmiCalculator.BMIdescription(0);
            string expectedDescription = "Normal";

            Assert.AreEqual(expectedDescription, actualDescription);
        }
        //method to test color bmi display
        [TestMethod]
        public void TestBMIColor()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.BMIdata();
            bmiCalculator.Bmi = 18.7;

            string actualColor = bmiCalculator.BMIdescription(1);
            string expectedColor = "#2fb52f";

            Assert.AreEqual(expectedColor, actualColor);
        }
        //method to test metric high boundary
        [TestMethod]
        public void TestUnderweightMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 63.6;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "18";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric normal bmi
        [TestMethod]
        public void TestNormalMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 70.4;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "19.9";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric high boundary obese

        [TestMethod]
        public void TestHighMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 95.3;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "27";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric underweight bmi
        public void TestImperialUnderWeightLowBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 70.4;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "17.46";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test mimperial low boundary underweight
        public void TestImperialUnderWeightHighBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 95.3;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "26.96";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 1
        [TestMethod]
        public void TestObeseIMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 97.8;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "27.7";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 2
        [TestMethod]
        public void TestObeseIIMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 115.9;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "32.8";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test imperial low boundary normal
        [TestMethod]
        public void TestImperiaNormaLowBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 95.3;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "12.2";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 1
        [TestMethod]
        public void TestImperiaObeseIHighBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 115.9;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "14.9";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test imperial low boundary obesse 1
        [TestMethod]
        public void TestImperialObeseWeightLowBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 97.8;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "12.6";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test imperial low boundary obesse 2
        [TestMethod]
        
        public void TestImperiaObeseIILowLowBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 141.2;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "18.1";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test imperial low boundary obesse 2
        [TestMethod]

        public void TestImperiaObeseIIHighBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 160.9;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "20.7";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 3
        [TestMethod]
        public void TestObeseIIIMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 115;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "32.5";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test imperial low boundary obesse 3
        [TestMethod]

        public void TestImperiaObeseIIILowLowBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 163.6;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "21";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 1
        [TestMethod]
        public void TestObeseILowMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 118.5;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "33.5";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric low boundary obesse 3
        [TestMethod]
        public void TestObeseIHighMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 160.9;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "45.5";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric high boundary obesse 3
        [TestMethod]
        public void TestObeseIIILowMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 163.6;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "46.3";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        //method to test metric  obesse 3
        [TestMethod]
        public void TestObeseIIIHighMetric()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Height = 1.88;
            bmiCalculator.Weight = 175.5;

            string actualBMI = bmiCalculator.BMIcalc(false);
            string expectedBMI = "49.7";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
        [TestMethod]
        //method to test imperial high boundary obesse 3
        public void TestImperiaObeseIIIHighBMIcalc()
        {
            BMICalculatorWeb bmiCalculator = new BMICalculatorWeb();
            bmiCalculator.Feet = 6;
            bmiCalculator.Inches = 2;
            bmiCalculator.Weight = 175.5;

            string actualBMI = bmiCalculator.BMIcalc(true);
            string expectedBMI = "22.5";

            Assert.AreEqual(expectedBMI, actualBMI);
        }
      
    }
}
