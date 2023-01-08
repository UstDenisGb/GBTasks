using static System.Console;

WriteLine("Введите число a: ");
int a = int.Parse(ReadLine()!);

if (a>99) 
{
    int a1 = (a/100)%10;
    WriteLine($"Третья цифра числа {a} - {a1}");
}
else 
{
    WriteLine($"Третьей цифры нет");
}