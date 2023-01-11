using static System.Console;

WriteLine("Введите координату x точки А: ");
int.TryParse(ReadLine(),out int ax);
WriteLine("Введите координату y точки А: ");
int.TryParse(ReadLine(),out int ay);
WriteLine("Введите координату z точки А: ");
int.TryParse(ReadLine(),out int az);
WriteLine("Введите координату x точки B: ");
int.TryParse(ReadLine(),out int bx);
WriteLine("Введите координату y точки B: ");
int.TryParse(ReadLine(),out int by);
WriteLine("Введите координату z точки B: ");
int.TryParse(ReadLine(),out int bz);

double length = Math.Sqrt(Math.Pow((bx-ax),2)+Math.Pow((by-ay),2)+Math.Pow((bz-az),2));
WriteLine(length);

