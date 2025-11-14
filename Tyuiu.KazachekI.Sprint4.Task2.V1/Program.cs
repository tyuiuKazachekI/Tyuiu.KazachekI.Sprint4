using System;
using Tyuiu.KazachekI.Sprint4.Task2.V1.Lib;

Console.Title = "Спринт #4 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (генерация случайных чисел)                    *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив из 10 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от 1 до 9. Подсчитать произведение    *");
Console.WriteLine("* чётных элементов массива.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = new int[10];
Random rnd = new Random();

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1, 10);
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Произведение чётных элементов массива = {result}");
Console.ReadLine();
