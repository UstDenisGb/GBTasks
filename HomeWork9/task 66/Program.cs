// Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);
int Sum = 0;

WriteLine(GetSum(M, N, Sum));

string GetSum (int num1, int num2, int summa) 
{
    if (num1 <= num2) 
    {
        summa = summa+num1;
        num1++;
        return GetSum (num1, num2, summa);
    }
    return summa.ToString();
}