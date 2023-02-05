// Напишите программу, реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

using static System.Console;

int [] ar = new int [15];

FullArray(ar);
PrintArray(ar);

WriteLine();
int EvenNum = 0;
foreach (int a in ar)
{
    EvenNum += a%2==0 ? 1 : 0;
}
WriteLine ($"{EvenNum}");

void FullArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(100, 999);
    }
}
void PrintArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        Write($"{array[i]} ");
    }
}
