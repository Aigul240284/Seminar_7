// Напишите программу, которая на вход принимает позиции элемента в 
// двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Clear();

int[,] array = GetArray(5, 5, 1, 10);
PrintArray(array);

Console.Write("Введите число массива:  ");
int A = int.Parse(Console.ReadLine() ?? "");

int CountEL = FindEL(array);

if (CountEL > 0) Console.Write($"{A} -> в массиве найдено {CountEL} эл.");
else Console.Write($"{A} -> такого числа в массиве нет");

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int FindEL(int[,] array)
{
    int CountEl = 0;
    foreach (int el in array)
    {
        if (el == A) CountEl += 1;
    }
    return CountEl;
}

