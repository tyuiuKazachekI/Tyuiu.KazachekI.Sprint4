using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.KazachekI.Sprint4.Task4.V1.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {

            [TestMethod]
            public void CheckSumEvenNumbers()
            {
                DataService ds = new DataService();

                // Создаем простой массив 2x2
                int[,] matrix =
                {
                { 2, 3 },
                { 4, 5 }
            };

                int result = ds.Calculate(matrix);

                int expected = 6;

                Assert.AreEqual(expected, result);
            }
        }
    }

