Console.Clear();
Console.Write("Введите 1ое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ое число ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 3ое число ");
int c = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    if (a > c) Console.WriteLine("Максимальное число: " + a);
    else Console.WriteLine("Максимальное число: " + c);
}
else if (b > c) Console.WriteLine("Максимальное число: " + b);
else Console.WriteLine("Максимальное число: " + c);