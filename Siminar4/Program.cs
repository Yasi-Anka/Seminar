// Напишите программу, которая принимает на вход число (А)
// и выдаёт сумму чисел от 1 до А.
/*
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
*/

// Напишите программу, которая принимает на вход число и
// выдаёт количество цифр в числе.
/*
int Proizwedenie(int N)
{
    int digit = 0;
    while( N != 0)
    {
        N = N/10;
        digit++;
    }
    return digit;
}
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Proizwedenie(a));
*/
// Написать программу, которая определит произведение чисел от 1 до N

int Prod(int number)

{
    int product = 1;
    for(int current =1; current <= number; current++)
    {
        product = product + current;
    }
    return product;
}

Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Prod(a));

