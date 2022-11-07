// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.

int FindSum(int number)
{
    int sum = 0;

    for(int current = 1; current <= number; current++)
    sum += current;

    return sum;
}

Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма числел равна " + FindSum(a));
