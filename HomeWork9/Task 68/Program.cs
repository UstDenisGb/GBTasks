// Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n
using static System.Console;
Clear();

WriteLine("Введите M: ");
int M = int.Parse(ReadLine()!);
WriteLine("Введите N: ");
int N = int.Parse(ReadLine()!);

WriteLine(Akk(M, N));

int Akk (int num1, int num2) 
{
    if (num1 == 0) return num2+1;
    else 
    {
        if ((num1 != 0) && (num2 == 0)) return Akk(num1 - 1, 1);
        else return Akk(num1 - 1, Akk(num1, num2 - 1));
    }
}