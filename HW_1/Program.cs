Console.WriteLine("Найти максимальное и минимальное числа");
int a = 5;
int b = 7;
int max = b;
int min = a;
if (a < max) min = a;
if (b > min) max = b;
Console.WriteLine(min);
Console.WriteLine(max);
