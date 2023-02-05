// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

using static System.Console;
Clear();

WriteLine("Введите числа через пробел: ");

int [] ar = Array.ConvertAll(ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries), int.Parse);
int count = 0;

for (int i = 0; i < ar.Length; i++)
{
    if (ar[i] > 0) 
    {
        count++;
    }
}

WriteLine ($"{count}");
