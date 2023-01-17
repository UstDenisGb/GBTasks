using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

int SumNumber = GetSumNumber(a);
WriteLine($"{SumNumber}");

int GetSumNumber (int C) 
{
    int result = 0;
    while (a > 0)
    {
        result += a%10;
        a = a/10;
    }
    return result;
}
