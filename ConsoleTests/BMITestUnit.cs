
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;
using System;
using ConsoleAppProject.App02;

namespace ConsoleTests
{
    [TestClass]
    public class BMITestUnit

    {
        [TestMethod]

        public void TestCalculateMetricBMI()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 70;
                bmiCalculator.metre = 1.75;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(22.86, bmiCalculator.IndexBMI, 0.01);
            }
        }
      
        [TestMethod]

        public void TestCalculateMetricBMIobese2()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 140;
                bmiCalculator.metre = 1.8;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(43.2, bmiCalculator.IndexBMI, 0.01);
            }
        }
        [TestMethod]

        public void TestCalculateMetricBMIUnderweight()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 40;
                bmiCalculator.metre = 1.75;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(13.1, bmiCalculator.IndexBMI, 0.01);
            }
        }
        [TestMethod]

        public void TestCalculateMetricBMIObese1()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 100;
                bmiCalculator.metre = 1.75;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(32.7, bmiCalculator.IndexBMI, 0.01);
            }
        }
        [TestMethod]

        public void TestCalculateMetricBMIObese22()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 70;
                bmiCalculator.metre = 1.75;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(39.2, bmiCalculator.IndexBMI, 0.01);
            }
        }
        [TestMethod]

        public void TestCalculateMetricBMIObese3()
        {
            BMI bmiCalculator = new BMI();

            {
                bmiCalculator = new BMI();
                bmiCalculator.Kilogram = 140;
                bmiCalculator.metre = 1.75;

                bmiCalculator.CalculateMetricBMI();

                Assert.AreEqual(45.7, bmiCalculator.IndexBMI, 0.01);
            }
        }

    }

}
        

