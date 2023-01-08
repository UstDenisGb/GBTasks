using static System.Console;

WriteLine("Введите трехзначное число a: ");
int a = int.Parse(ReadLine()!);

if (a>99&a<1000) 
{
    int a1 = (a%100)/10;
    WriteLine($"Вторая цифра числа {a} - {a1}");
}
else 
{
    WriteLine($"Это не трехзначное число");
}
