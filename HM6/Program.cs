// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();
Console.WriteLine("Введите любое число от 100 и больше: ");
int n = Convert.ToInt32(Console.ReadLine());
string n1 = n.ToString();
if (n < 100)
{
    Console.WriteLine("Мне нечего сказать");
    return;
}
Console.WriteLine(n1[2]);

