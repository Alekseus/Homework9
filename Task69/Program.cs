//Задайте значения M и N. Напишите программу, которая найдёт сумму элементов в промежутке от M до N.


Console.Clear();
Console.WriteLine();
int Sum(int m, int n)
{
    int sum = m;
    if (m < n)
    {
        sum += Sum(m + 1, n);
    }
    return sum;
}
int m = 1;
int n = 5;
int result = Sum(m, n);
Console.WriteLine($"Сумма элементов от {m} до {n}: {result}");