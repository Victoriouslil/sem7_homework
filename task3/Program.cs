// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

// создаем массив из рандомных чисел

Console.WriteLine("Введите число: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = new int[size];
Random rand = new Random();
for(int i = 0; i < size; i++)
{
    array[i] = rand.Next(1, 100);
} 

// выводим массив

void PrintArray(int[] array, int i)
{
if (i < array.Length)
{
    PrintArray(array, i + 1);
    Console.Write(array[i] + " ");
}
}

// Решение задачи 

void PrintTurnedArray(int[] array, int i)
{
    if(i >= 0)
    {
        PrintTurnedArray(array, i - 1);
        Console.Write($"{array[i]} ");
    }
}

// вывод полученного решения из задачи

Console.WriteLine("Исходный массив: ");
PrintArray(array, 0);

Console.WriteLine();
Console.WriteLine("Полученный результат: ");
PrintTurnedArray(array, size - 1);