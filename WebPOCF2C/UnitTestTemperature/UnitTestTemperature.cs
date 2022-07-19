using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebPOCF2C.Models;

namespace UnitTestTemperature
{
    [TestClass]
    public class UnitTestTemperature
    {
        [TestMethod]
        public void Create_Temperature_With_Only_Value()
        {
            var temp = new Temperature(15);

            Assert.AreEqual(15, temp.Temp);
        }
        [TestMethod]
        public void Create_Temperature_Celsius()
        {
            var temp = new Temperature(15, 0);

            Assert.AreEqual(Scale.Celsius, temp.Scale);
        }
        [TestMethod]
        public void Create_Temperature_Farenheit()
        {
            var temp = new Temperature(15, 1);

            Assert.AreEqual(Scale.Farenheit, temp.Scale);
        }

        [TestMethod]
        public void Create_Temperature_Farenheit_Above_One()
        {
            var temp = new Temperature(15, 2);

            Assert.AreEqual(Scale.Farenheit, temp.Scale);
        }

        [TestMethod]
        public void Temperature_C2F()
        {
            var temp = new Temperature();
            double number = 15;

            Assert.AreEqual(59, temp.C2F(number), 0.001, "Method failed on convertion.");

            number = 10;

            Assert.AreEqual(50, temp.C2F(number), 0.001, "Method failed on convertion.");

            number = 4;

            Assert.AreEqual(39.2, temp.C2F(number), 0.001, "Method failed on convertion.");

            number = 1;

            Assert.AreEqual(33.8, temp.C2F(number), 0.001, "Method failed on convertion.");

            number = -96;

            Assert.AreEqual(-140.8, temp.C2F(number), 0.001, "Method failed on convertion.");
        }
    }
}
