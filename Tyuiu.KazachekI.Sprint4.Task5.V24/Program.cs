using System;
using Tyuiu.KazachekI.Sprint4.Task5.V24.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task5.V24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int rows = 5;
            int cols = 5;
            int[,] matrix = new int[rows, cols];

            Random rand = new Random();

            Console.Title = "Спринт #4 | Выполнил: Казачек И. | Вариант 24";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант 24                                                              *");
            Console.WriteLine("* Выполнил: Казачек Иван                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный массив 5x5 со случайными числами от -7 до 6.              *");
            Console.WriteLine("* Найти количество положительных элементов массива.                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("\nИсходный массив:\n");

            // Заполнение массива и вывод
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-7, 7); // от -7 до 6
                    Console.Write(matrix[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }

            int result = ds.Calculate(matrix);

            Console.WriteLine("\nКоличество положительных элементов: " + result);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}
