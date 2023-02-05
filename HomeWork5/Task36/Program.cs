// Напишите программу, реализующую методы формирования массива, 
// заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях
using static System.Console;

int [] ar = new int [4];

FullArray(ar);
PrintArray(ar);

WriteLine();
int UnevenSum = 0;
int In = 0;
while (In < ar.Length)
{
    if (In%2 > 0)
    {
        UnevenSum += ar[In];
    }
    In++;
}
WriteLine ($"{UnevenSum}");

void FullArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        Write($"{array[i]} ");
    }
}
