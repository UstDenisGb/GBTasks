using static System.Console;

WriteLine("Введите цифру дня недели: ");
int a = int.Parse(ReadLine()!);

if (a>0&a<8) 
{
    WriteLine(a==6|a==7?"Выходной":"Рабочий");
}
else 
{
    WriteLine($"Это не день недели");
}
