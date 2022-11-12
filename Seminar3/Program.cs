// Напишите программу, которая по заданному
//номеру четверти, показывает диапазон возможных
 //координат точек в этой четверти(x и y).
/*
 void ShowRange(int quart)
 {
    if(quart == 1)
    Console.WriteLine("x > 0 and y > 0");
    else if(quart == 2)
    Console.WriteLine("x < 0 and y > 0");
    else if(quart == 3)
    Console.WriteLine("x < 0 and y < 0");
    else if(quart == 4)
    Console.WriteLine("x > 0 and y < 0");
    else
    Console.WriteLine("Wrong number!");
 }

Console.Write("Введите номар четверти ");
int quartNum = Convert.ToInt32(Console.ReadLine());

ShowRange(quartNum);
*/

// 1  Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и
// выдаёт номер четверти плоскости, в которой находится
// эта точка.

int Quad (int x, int y)
{
    int quart = 0;
    if(x > 0 && y > 0)
        quart = 1;
    if(x < 0 && y > 0)
        quart = 2;
    if(x < 0 && y < 0)
        quart = 3; 
    if(x > 0 && y < 0)
        quart = 4;
    return quart;
}

Console.Write("Input x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y: ");
int y = Convert.ToInt32(Console.ReadLine());
int z = Quad(x, y);
Console.WriteLine("Number quarter: " + z);

// 2 Напишите программу, которая принимает на вход
// координаты двух точек и находит расстояние между
// ними в 2D пространстве.

double Two_d (int x1, int y1, int x2, int y2)
{
    double lenght;
    lenght = Math.Round(Math.Sqrt(Math.Pow((x2 -x1), 2) + Math.Pow((y2- y1), 2)), 3);
    return lenght;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Two_d(x1, y1, x2, y2);
Console.WriteLine("Lenght = " + res);

// 3 Напишите программу, которая принимает на вход
// число (N) и выводит квадраты чисел от 1 до N.

double Two_d (int x1, int y1, int x2, int y2)
{
    double lenght;
    lenght = Math.Round(Math.Sqrt(Math.Pow((x2 -x1), 2) + Math.Pow((y2- y1), 2)), 3);
    return lenght;
}

Console.Write("Input x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

double res = Two_d(x1, y1, x2, y2);
Console.WriteLine("Lenght = " + res);