using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ConsoleAppProject.Tests
{
    [TestClass]
    public class BMICalculatorWebTests
    {
        [TestMethod]
        public void Test_BMIcalc_Imperial()
        {
            // Arrange
            BMICalculatorWeb bmiCalculator = new()
            {
                Feet = 5,
                Inches = 10,
                Weight = 160
            };

            // Act
            ;
            double result = Convert.ToInt32(bmiCalculator.BMIcalc(false));
            double expectedDistance = 22.9;
            // Assert
            Assert.AreEqual(expectedDistance, result);
        }

        [TestMethod]
        public void Test_BMIcalc_Metric()
        {
            // Arrange
            BMICalculatorWeb bmiCalculator = new()  
            {
                Height = 1.75,
                Weight = 70
            };


            // Act
            ;
            double result = Convert.ToInt32(bmiCalculator.BMIcalc(false));
            double expectedDistance = 22.86;
            // Assert
            Assert.AreEqual(expectedDistance, result);
        }

        [TestMethod]
        public void Test_BMIdescription_Underweight()
        {
            // Arrange
            BMICalculatorWeb bmiCalculator = new() { Bmi = 18 };

            // Act
            string description = bmiCalculator.BMIdescription(0);

            // Assert
            Assert.AreEqual("Underweight", description);
        }

        [TestMethod]
        public void Test_BMIdescription_Normal()
        {
            // Arrange
            BMICalculatorWeb bmiCalculator = new()
            {
                Bmi = 24.9
            };

            // Act
            string description = bmiCalculator.BMIdescription(0);

            // Assert
            Assert.AreEqual("Normal", description);
        }

        [TestMethod]
        public void Test_BMIdescription_Overweight()
        {
            // Arrange
            BMICalculatorWeb bmiCalculator = new()
            {
                Bmi = 30
            };

            // Act
            string description = bmiCalculator.BMIdescription(0);

            // Assert
            Assert.AreEqual("Overweight", description);
        }

    }
    }
