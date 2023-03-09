Console.Clear();
Console.Write("Введите 1ое число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2ое число ");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
Console.WriteLine("Первое число " + a + " больше чем второе " + b);
}
else
{
Console.WriteLine("Второе число " + b + " больше чем первое " + a);
}