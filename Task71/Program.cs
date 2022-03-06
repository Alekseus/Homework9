//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
//             n + 1, m = 0
// A(m,n) =    A(m - 1, 1) m > 0, n = 0;
//             A(m - 1, A(m, n - 1)) , m > 0, n > 0

Console.Clear();
Console.WriteLine();

int Function(int m, int n)
{
    if (m == 0)
    {
        return (n + 1);
    }
    if (m > 0 && n == 0)
    {
        return Function(m - 1, 1);
    }
    return Function(m - 1, Function(m, n - 1));
}
int m = 2;
int n = 3;
Console.WriteLine($"Даны два неотрицательных числа m = {m} и n = {n}");
Console.Write($"Результат функции Аккермана = ");
Console.WriteLine(FunctionAkkerman(m, n));

