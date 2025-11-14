using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task0.V25.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task0.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckSumEvenNumbers()
        {
            DataService ds = new DataService();

            int[] array = { 2, 4, 6 };
            int result = ds.GetSumEvenArrEl(array);

            int expected = 12;

            Assert.AreEqual(expected, result);
        }
    }
}
