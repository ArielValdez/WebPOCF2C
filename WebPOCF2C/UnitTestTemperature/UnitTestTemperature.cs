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

            Assert.AreEqual(59, temp.C2F(number));
        }

        [TestMethod]
        public void Truncate_Test()
        {
            var temp = new Temperature();
            double number = 17;
            var result = temp.C2F(number);

            Assert.AreEqual(62.5, temp.Truncate(result, 1));
        }
    }
}
