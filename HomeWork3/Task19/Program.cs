using static System.Console;

WriteLine("Введите пятизначное число: ");
int a = int.Parse(ReadLine()!);
int reverse = 0;
int a2 = a;

while(a2>0) 
{
    reverse *= 10;
    reverse += a2%10;
    a2 = a2/10;
}
if(a==reverse) 
{
    WriteLine("Это палиндром");
}
else 
{
    WriteLine("Это не палиндром");
}