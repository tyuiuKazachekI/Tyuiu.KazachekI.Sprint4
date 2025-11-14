using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task3.V19.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task3.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckEvenNumbersCount()
        {
            DataService ds = new DataService();

            int[,] array =
            {
                { 2, 3 },
                { 4, 5 }
            };

            int result = ds.Calculate(array);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
