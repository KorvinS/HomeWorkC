// Задана последовательность натуральных чисел, завершающаяся числом 0. 
// Требуется определить значение второго по величине элемента в этой последовательности, 
// то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.

Console.Clear();

Random rnd = new Random();

Console.WriteLine("Сколько чисел Вам сгенерировать?");
int n = Convert.ToInt32(Console.ReadLine());
for (uint ctr = 1; ctr <= n; ctr++)
    Console.WriteLine($"{rnd.Next(100)}");

int a = 0;
int b = 0;
int max = 0;
int pred_max = 0 ;

if (a >= b)
{
    max = a;
    pred_max = b;
}
else
{
    max = b;
    pred_max = a;
}
while (a != 0)
{
    if (a == 0) break;
    if (max <= a)
    {
        pred_max = max;
        max = a;
    }
    else if (pred_max < a)
    {
        pred_max = a;
    }
}
Console.WriteLine(pred_max);

