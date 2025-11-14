using System;
using Tyuiu.KazachekI.Sprint4.Task7.V16.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task7.V16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int n = 5;
            int m = 3;
            string value = "382976421897948";

            Console.Title = "Спринт #4 | Казачек Иван | Вариант 16";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы и строки                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант 16                                                              *");
            Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана строка из цифр \"382976421897948\".                                  *");
            Console.WriteLine("* Преобразовать её в матрицу 5x3 и подсчитать произведение четных чисел.  *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("\nИсходная строка: " + value + "\n");

            int result = ds.Calculate(n, m, value);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Произведение четных чисел = {result}");
            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
