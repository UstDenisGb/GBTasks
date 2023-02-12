// Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

int [,] ar = new int [M, N];
FullArray(ar);
PrintArray(ar);

WriteLine("Введите позицию, указав номер строки: ");
int numRow = int.Parse(ReadLine()!);
WriteLine("Введите позицию, указав номер столбца: ");
int numCol = int.Parse(ReadLine()!);
GetPos(ar, numRow, numCol);

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
            Write($"{array[i, j]}   ");
        }
    WriteLine();
    }
}

void GetPos (int [,] array, int R, int C)
{
    if (R < array.GetLength(0) && C < array.GetLength(1)) WriteLine($"{array[R, C]}");         
    else WriteLine("Таких элементов нет");
}
