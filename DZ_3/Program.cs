// Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int[,] array = GetArray(3, 3, 1, 9);
PrintArray(array);
Console.Write("Среднее арифметическое каждого столбца:");
SumElArray(array);

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

void SumElArray(int[,] inArray)
{
    double result;
    double A = inArray.GetLength(0);

    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        int Sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            Sum = Sum + inArray[i, j];
        }
        result = Sum / A;
        Console.Write("{0,6:F1}", result);
    }
}
