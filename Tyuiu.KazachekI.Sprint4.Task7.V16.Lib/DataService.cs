using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.KazachekI.Sprint4.Task7.V16.Lib
{
    public class DataService : ISprint4Task7V16
    {
        public int Calculate(int n, int m, string value)
        {
            int product = 1;
            bool foundEven = false;

            for (int i = 0; i < value.Length; i++)
            {
                int number = int.Parse(value[i].ToString());

                if (number % 2 == 0)
                {
                    product *= number;
                    foundEven = true;
                }
            }

            if (foundEven)
            {
                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}