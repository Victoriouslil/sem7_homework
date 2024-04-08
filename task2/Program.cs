// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.



static int FunctionOfAkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return FunctionOfAkerman(m - 1, 1);
    }
    else
    {
        return FunctionOfAkerman(m - 1, FunctionOfAkerman(m, n - 1));
    }
}

int m = 1;
int n = 3;
Console.WriteLine($"m = {m} ; n = {n} -  A(m, n) = {FunctionOfAkerman(m, n)}");