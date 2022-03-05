// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SecondDigitNum(num));

int SecondDigitNum(int num1)
{
    int num2 =(num1/10);
    num2 = num2%10;
    return num2;
}
*/

//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.


/*Console.WriteLine("Введите любое число: ");
int num = Convert.ToInt32(Console.ReadLine());
    ThirdDigitNum(num);



 void ThirdDigitNum(int a)
{
    if (a > 99)
    {
        while (a > 999)
        {
            a = a / 10;
        }
        a = a % 10;
        Console.WriteLine(a);
    }
    else
    {
    Console.WriteLine("Третьей цифры нет");
    }
    
}
*/
//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());
DayOff(DayNumber);


void DayOff (int day)
{
    if (day ==6||day ==7)
    {
        Console.WriteLine("ВЫходной");
        
    }
    else
    {
        if(day>7||day<=0)
        {
            Console.WriteLine("Неккоретное число");
        }
        else
        {
            Console.WriteLine("Не является выходным");
        }


    }
}
