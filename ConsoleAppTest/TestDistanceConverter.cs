global using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;


namespace ConsoleAppTest
{
    [TestClass]
    public class TestDistanceConverter
    {
       [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceConverter.MILES;
            converter.ToUnit = DistanceConverter.FEET;
            double expectedDistance = 5280;
            Assert.AreEqual(expectedDistance, converter.ToDistance);
        }
    }
}