// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

int [,] ar = new int [M, N];
FullArray(ar);
PrintArray(ar);

WriteLine($"{PrintMinSumRow (ar)+1} - строкa с наименьшей суммой элементов");

void FullArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
        }
    }
}

void PrintArray (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]}  ");
        }
    WriteLine();
    }
}
int PrintMinSumRow(int [,] array)
{
    int row = 0;
    int minsum = 0;
    for (int i = 1; i < array.GetLength(1); i++)
    {
        minsum += array [0, i];
    }
    for (int i = 1; i < array.GetLength(0); i++) 
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i,j];
        }
    if (minsum > sum) 
    {
        minsum = sum;
        row = i;
    }
    }
    return row;
}