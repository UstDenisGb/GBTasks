// Напишите программу, реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях
using static System.Console;

int [] ar = new int [4];

FullArray(ar);
PrintArray(ar);

WriteLine();
int UnevenSum = 0;
foreach (int a in ar)
{
    UnevenSum += a%2==0 ? 1 : 0;
}
WriteLine ($"{EvenNum}");

void FullArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        array[i] = new Random().Next();
    }
}
void PrintArray (int [] array) 
{
    for (int i = 0; i < array.Length; i++) 
    {
        Write($"{array[i]} ");
    }
}
