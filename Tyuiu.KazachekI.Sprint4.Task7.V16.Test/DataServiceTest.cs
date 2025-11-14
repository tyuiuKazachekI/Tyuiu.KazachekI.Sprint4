using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task7.V16.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task7.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckProductEvenDigits()
        {
            DataService ds = new DataService();

            string value = "246";
            int n = 1;
            int m = 3;

            int result = ds.Calculate(n, m, value);

            int expected = 48;

            Assert.AreEqual(expected, result);
        }
    }
}
