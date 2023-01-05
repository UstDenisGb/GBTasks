using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

WriteLine("Введите число b: ");
int b = int.Parse(ReadLine()!);

if (a > b)
{
    WriteLine($"max = {a}");
}
else
{
    WriteLine($"max = {b}");
}
