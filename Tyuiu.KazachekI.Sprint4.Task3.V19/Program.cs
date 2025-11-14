using System;
using Tyuiu.KazachekI.Sprint4.Task3.V19.Lib;

Console.Title = "Спринт #4 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (статические данные)                            *");
Console.WriteLine("* Задание #3                                                              *");
Console.WriteLine("* Вариант #19                                                             *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5x5, заполненный статическими        *");
Console.WriteLine("* значениями в диапазоне от 3 до 9. Подсчитать количество чётных элементов*");
Console.WriteLine("* во всём массиве.                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] array =
{
    { 6, 5, 6, 3, 8 },
    { 9, 4, 4, 3, 4 },
    { 3, 3, 6, 8, 6 },
    { 6, 5, 3, 4, 3 },
    { 9, 3, 5, 3, 7 }
};

Console.WriteLine("Исходный массив:");
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(array);

Console.WriteLine($"Количество чётных элементов в массиве = {result}");
Console.ReadLine();
