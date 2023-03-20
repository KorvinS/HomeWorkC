// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string s = Console.ReadLine()!;
while (s.Length > 5 || s.Length < 5)
{
    Console.WriteLine("Введите пятизначное число: ");
    s = Console.ReadLine()!;
}
if (s[0] == s[4] && s[1] == s[3])
    Console.WriteLine("Это Палиндром");
else
    Console.WriteLine("Это НЕ палиндром");