// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Введите число соответствующее дню недели: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n >= 1 && n <= 5)
{
    Console.WriteLine("Будний день!");
    return;
}
else if (n >= 6 && n <= 7)
{
    Console.WriteLine("Выходной!");
    return;
}

else
{
    Console.WriteLine("Мне нечего сказать");
    return;
}




