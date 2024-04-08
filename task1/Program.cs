// Задача 1: Задайте значения M и N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.




void PrintAllNaturalNumbers(int M, int N)
{
    if (M < 1 || N < 1) return; // проверка на натуральность 
     
    else if (N > M)
    {
        Console.Write(M + " ");
        PrintAllNaturalNumbers(M + 1, N);
    }
    
    else if (M > N)
    {
        Console.Write(N + " ");
        PrintAllNaturalNumbers(N + 1, M);
    }
    
}


Console.WriteLine("Введите число M: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int M = Convert.ToInt32(Console.ReadLine());

PrintAllNaturalNumbers(M, N);
