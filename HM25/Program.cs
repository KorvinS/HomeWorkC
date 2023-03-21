// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// Нельзя использовать функцию Math.Pow()!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
Console.Write("Введите 1ое число: ");
int a = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите 2ое число (степень): ");
int b = Convert.ToInt32(Console.ReadLine()!);
int i = 0;
int s = 1;
for (i = 0; i < b; i++)
{
    s = s * a;
}
Console.Write($"Решение {s}");

