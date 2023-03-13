// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Clear();
Console.WriteLine("Введите 3х значное число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 100 || n > 1000)
{
    Console.WriteLine("У Вас был шанс! Прощайте!");
    return;
}

int n1 = n / 100;
int n2 = n / 10;
Console.WriteLine(n2 - n1 * 10);
