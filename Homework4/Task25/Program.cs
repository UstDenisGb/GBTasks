using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);
int degree = GetDegree(a);
WriteLine($"{degree}");

int GetDegree (int C) 
{
    int result = 1;
    for (int i = 1; i<=b; i++) 
    {
        result *= a;
    }
    return result;
}