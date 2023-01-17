using static System.Console;

int [] ar = new int [8];
FullArray(ar);
PrintArray(ar);

void FullArray (int [] array) 
{
    for (int i = 0; i < 8; i++) 
    {
        array[i] = new Random().Next(0, 100);
    }
}
void PrintArray (int [] array) 
{
    for (int i = 0; i < 8; i++) 
    {
        Write($"{array[i]} ");
    }
}

