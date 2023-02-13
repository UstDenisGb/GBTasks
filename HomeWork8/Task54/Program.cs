// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

int [,] ar = new int [M, N];
FullArray(ar);
PrintArray(ar);
RangeArray(ar);
WriteLine();
PrintArray(ar);

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
void RangeArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++) 
            {
                if (array[i, k] < array [i, k+1])
                {   
                    int temp = array [i, k+1];
                    array [i, k+1] = array [i, k];
                    array [i, k] = temp;

                } 
            }
        }
    }
}