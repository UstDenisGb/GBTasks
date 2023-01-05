using static System.Console;

WriteLine("Введите число N: ");
int a = int.Parse(ReadLine()!);
int b = 1;

while (b < a+1)
{
    if (b%2 == 0) 
    {
        WriteLine($"{b}");
    }
    b = b + 1;
}