using System;
using Tyuiu.KazachekI.Sprint4.Task1.V7.Lib;

Console.Title = "Спринт #4 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (ввод с клавиатуры)                            *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #7                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив из 11 элементов, заполненный        *");
Console.WriteLine("* значениями с клавиатуры в диапазоне от 1 до 8. Подсчитать сумму         *");
Console.WriteLine("* чётных элементов массива.                                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] array = new int[11];

Console.WriteLine("Введите 11 целых чисел (от 1 до 8):");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Элемент [{i + 1}] = ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Сумма чётных элементов массива = {result}");
Console.ReadLine();