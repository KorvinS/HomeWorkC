// Суперсдвиг
// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.

Console.Clear();
Console.WriteLine("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Random random = new Random();
int m = 0;
while (m < array.Length)
{
    array[m] = random.Next(0, 10);
    Console.Write($"{array[m]}, ");
    m++;
}
System.Console.WriteLine("в какое кол-во раз надо произвести сдвиг ");
int s = Convert.ToInt32(Console.ReadLine());
int i = 0;
int j = 0;
int box = 0;
int l = array.Length;
while (s > j)
{
    i = 0;
    box = array[l - 1];
    while (i < l - 1)
    {

        array[l - 1 - i] = array[l - 2 - i];
        i++;
    }
    array[0] = box;
    j++;
}
while (s < j)
{
    i = 0;
    box = array[0];
    while (i < l - 1)
    {
        array[i] = array[i + 1];
        i++;
    }
    array[l - 1] = box;
    j--;
}

i = 0;
while (i < array.Length)
{
    Console.Write(array[i] + ", ");
    i++;
}