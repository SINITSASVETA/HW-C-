//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число: ");
int b  = Convert.ToInt32(Console.ReadLine());
if (a > b) 
{
    Console.WriteLine("Максимальное число " + a);
}
else
{
    Console.WriteLine("Максимальное число " + b);
}
  */
  //Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе  число: ");
int b  = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
Console.WriteLine("Максимальное число " + max);
*/
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a %2 ==0)
{
    Console.WriteLine("число " + a + " является чётным числом");

}
else
{
    Console.WriteLine("число " + a + " не является чётным числом");
}
*/
//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int a = 1;
while(a <= N) 
{
    if (a %2 == 0) 
    {
        Console.WriteLine(a);
        a++;
    }
    else
    {
        a++;
    }
}

