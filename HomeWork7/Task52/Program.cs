// Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

int [,] ar = new int [M, N];
FullArray(ar);
PrintArray(ar);
WriteLine();
GetAr(ar);

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
            Write($"{array[i, j]} ");
        }
    WriteLine();
    }
}

void GetAr (int [,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        double sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[j,i];
        }
        double average = Math.Round(sum/array.GetLength(0), 2);
        int n = i + 1;
        Write($"{average} ");
    }
}