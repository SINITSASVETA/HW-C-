// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int SecondDigitNum(int num1)
{
    int num2 =(num1/10);
    num2 = num2%10;
    return num2;
}


Console.WriteLine(SecondDigitNum(num));