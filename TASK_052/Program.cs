/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);


double Sum = NewGetArray(array);
double Sum1 = NewGetArray1(array);
double Sum2 = NewGetArray2(array);
double Sum3 = NewGetArray3(array);
Console.WriteLine($"Среднее арифметическое каждого столбца: {Sum} ; {Sum1} ; {Sum2} ; {Sum3}.");



int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

double NewGetArray(int[,] array)
{
    double SumNum = 0;
    double mid = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i < 4) && (j < 1))
            {
                SumNum = SumNum + array[i, j];           
            }
            mid = SumNum / array.GetLength(0);
        }   
    }
    return mid;
}
double NewGetArray1(int[,] array)
{
    double SumNum = 0;
    double mid = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i < 4) && ((j < 2) && (j > 0)))
            {
                SumNum = SumNum + array[i, j];           
            }
            mid = SumNum / array.GetLength(0);
        }   
    }
    return mid;
}
double NewGetArray2(int[,] array)
{
    double SumNum = 0;
    double mid = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i < 4) && ((j < 3) && (j > 1)))
            {
                SumNum = SumNum + array[i, j];           
            }
            mid = SumNum / array.GetLength(0);
        }   
    }
    return mid;
}
double NewGetArray3(int[,] array)
{
    double SumNum = 0;
    double mid = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if ((i < 4) && ((j < 4) && (j > 2)))
            {
                SumNum = SumNum + array[i, j];           
            }
            mid = SumNum / array.GetLength(0);
        }   
    }
    return mid;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}