using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task2.V1.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task2.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckProductEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 2, 3, 4 };
            int result = ds.Calculate(array);

            int expected = 8;

            Assert.AreEqual(expected, result);
        }
    }
}
