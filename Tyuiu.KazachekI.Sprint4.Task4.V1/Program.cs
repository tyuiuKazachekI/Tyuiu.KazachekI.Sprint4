using System;
using Tyuiu.KazachekI.Sprint4.Task4.V1.Lib;

Console.Title = "Спринт #4 | Выполнил: Казачек Иван | ИСТНб-25-1";
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (ввод с клавиатуры)                             *");
Console.WriteLine("* Задание #4                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнил: Казачек Иван | ИСТНб-25-1                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5x5, заполненный значениями          *");
Console.WriteLine("* с клавиатуры в диапазоне от 1 до 9. Найдите сумму чётных элементов.     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[,] matrix = new int[5, 5];

Console.WriteLine("Введите элементы матрицы 5x5 (значения от 1 до 9):");
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write($"Элемент [{i + 1},{j + 1}] = ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

DataService ds = new DataService();
int result = ds.Calculate(matrix);

Console.WriteLine($"Сумма чётных элементов массива = {result}");
Console.ReadLine();
