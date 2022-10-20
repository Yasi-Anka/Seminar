// Напишите программу, которая по заданному
//номеру четверти, показывает диапазон возможных
 //координат точек в этой четверти(x и y).

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