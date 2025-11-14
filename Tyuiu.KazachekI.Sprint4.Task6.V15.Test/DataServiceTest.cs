using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task6.V15.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckShortWordsCount()
        {
            DataService ds = new DataService();

            string[] words = { "cat", "elephant", "dog", "butterfly" };

            int result = ds.Calculate(words);

            int expected = 2;

            Assert.AreEqual(expected, result);
        }
    }
}
