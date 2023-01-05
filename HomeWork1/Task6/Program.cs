using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

if (a%2 == 0)
{
    WriteLine("да");
}
else
{
    WriteLine("нет");
}