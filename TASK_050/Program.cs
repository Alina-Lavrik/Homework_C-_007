/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

i = 4, j = 2 -> такого числа в массиве нет
i = 1, j = 2 -> 2 */

int rows = new Random().Next(4, 5);
int columns = new Random().Next(4, 5);
Console.WriteLine($"Получили строк - {rows}");
Console.WriteLine($"Получили столбцов - {columns}");
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();


Console.WriteLine("Введите позицию i: ");
int i = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите позицию j: ");
int j = int.Parse(Console.ReadLine()!);


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


if (i > array.GetLength(0) || j > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {i} и {j} равно {array[i,j]}");
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