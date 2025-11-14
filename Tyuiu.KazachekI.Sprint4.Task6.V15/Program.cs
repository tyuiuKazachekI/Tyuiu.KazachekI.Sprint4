using System;
using Tyuiu.KazachekI.Sprint4.Task6.V15.Lib;

namespace Tyuiu.KazachekI.Sprint4.Task6.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string[] cities = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

            Console.Title = "Спринт #4 | Казачек И. | Вариант 15";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы строк                                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант 15                                                              *");
            Console.WriteLine("* Выполнил: Казачек Иван                                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив городов.                                           *");
            Console.WriteLine("* Используя класс Array, подсчитать количество элементов, длина которых   *");
            Console.WriteLine("* меньше 7 символов.                                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("\nИсходный массив строк:\n");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            int result = ds.Calculate(cities);

            Console.WriteLine("\nКоличество элементов, длина которых меньше 7: " + result);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
