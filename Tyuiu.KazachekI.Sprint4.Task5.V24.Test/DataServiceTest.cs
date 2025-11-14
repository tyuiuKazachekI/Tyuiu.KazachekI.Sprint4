using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task5.V24.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckPositiveNumbersCount()
        {
            DataService ds = new DataService();

            int[,] matrix =
            {
                { 1, -2 },
                { 3,  0 }
            };

            int result = ds.Calculate(matrix);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}