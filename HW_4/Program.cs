// Задачи из третьего семинара

//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());

 MetodPolindrom(number);
 
void MetodPolindrom(int num)
{
    int NumberSleva = num / 10000;
    int NumberSprava = num % 10;
    if(NumberSleva ==NumberSprava )
    {
        NumberSleva = (num / 1000) % 10;
        NumberSprava = (num % 100) / 10;
        if(NumberSleva ==NumberSprava )
        {
            Console.WriteLine("Введённое число палиндром: ");
        }
        else
        {
            Console.WriteLine("Ввведённое число не является палиндромом: ");
        }  
    }
    else
    {
         Console.WriteLine("Ввведённое число не является палиндромом: ");
    }  
}
*/
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double Distanse3D(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double xDistans = x2 - x1;
    double yDistans = y2 - y1;
    double zDistans = z2 - z1;
    double resalt = Math.Sqrt(Math.Pow(xDistans,2) + Math.Pow(yDistans,2) + Math.Pow(zDistans,2));
    return resalt;
}

double xA, yA, zA, xB, yB, zB;
Console.Write("Введите координату xA: ");
xA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату уA: ");
yA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату zA: ");
zA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату xB: ");
xB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату yB: ");
yB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату zB: ");
zB = Convert.ToDouble(Console.ReadLine());

 Console.WriteLine(Distanse3D(xA, yA, zA, xB, yB, zB));
 */
 //Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
 Console.WriteLine("Введите число для вывода таблицы кубов: ");
 int Number = Convert.ToInt32(Console.ReadLine());
 int index = 1;

 while(index <= Number)
 {
     int KubNumber = Convert.ToInt32(Math.Pow(index,3));
     Console.Write(KubNumber + " ");
     index = index + 1; 
 }
 */
