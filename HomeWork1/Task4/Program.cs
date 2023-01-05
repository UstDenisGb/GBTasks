using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

WriteLine("Введите число c: ");
int c = int.Parse(ReadLine()!);

if (a > b & a > c)
{
    WriteLine($"{a}");
}
if (b > a & b > c)
{
    WriteLine($"{b}");
}
if (c > a & c > b)
{
    WriteLine($"{c}");
}