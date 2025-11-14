using System;
using Tyuiu.KazachekI.Sprint4.Task0.V25.Lib;

Console.Title = "Спринт #4 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #25                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив из 10 элементов, заполненный        *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9. Подсчитать сумму         *");
Console.WriteLine("* чётных элементов массива.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + " ");
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.GetSumEvenArrEl(array);

Console.WriteLine($"Сумма чётных элементов массива = {result}");

Console.ReadLine();
