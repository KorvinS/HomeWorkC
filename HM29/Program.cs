﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.Clear();
int[] randomArray = new int[8];

Console.Write("Введите любое число: ");
int enterNumber = Convert.ToInt32(Console.ReadLine());

int[] array = new int[enterNumber];

for (int i = 0; i < enterNumber; i++)
{
    array[i] = new Random().Next(enterNumber + 1);
    Console.Write(array[i] + "; ");
}
Console.WriteLine();
