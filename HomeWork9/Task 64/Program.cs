// Напишите программу, которая реализует рекурсивный метод вывода всех натуральных чисел в промежутке от N до 1
using static System.Console;
Clear();

WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

WriteLine(GetNumbers(N));

string GetNumbers (int num) 
{
    if (num==1) return num.ToString();
    else return $"{num},{GetNumbers(num-1)}";
}