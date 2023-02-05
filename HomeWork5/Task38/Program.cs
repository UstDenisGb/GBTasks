// Напишите программу, реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива
using static System.Console;

double [] ar = new double [4];

FullArray(ar);
PrintArray(ar);

WriteLine();
double min = ar[0];
double max = ar[0];
foreach (double a in ar)
{
    if (min > a) min = a;
    if (max < a) max = a;
}
double dif = max - min;
WriteLine ($"{dif}");

void FullArray (double [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(1, 100)/10.0;
    }
}
void PrintArray (double [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        Write($"{array[i]} ");
    }
}
