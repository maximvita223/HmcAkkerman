// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


Console.Clear();
Console.Write("Введите M: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите N: ");
int n = int.Parse(Console.ReadLine()!);
int sum = 0;
Console.WriteLine(RecursMetod(m, n, sum));
int RecursMetod(int a, int b, int sum)
{
    if (a <= b)
    {
        sum = sum + a;
        return RecursMetod(a + 1, b, sum);
    }
    Console.Write("Сумма элементов = ");
    return sum;
}
