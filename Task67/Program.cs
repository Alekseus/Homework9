//Показать натуральные числа от N до 1, N задано. N = 5. -> "5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine();

string Number(int n)
{
    if (n >= 1)
    {
        return $"{n} " + Number(n - 1);
    }
    else
    {
        return string.Empty;
    }
}
int n = 5;
Console.WriteLine("Натуральные числа в промежутке от N до 1:");
Console.WriteLine(Number(n));
