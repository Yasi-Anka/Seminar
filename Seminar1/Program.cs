
// КОМЕНТИРОВАНИЕ
/* Здесь можно писать всё что угодно
и всё что между палочками со звёздочкой
будет как комментарии*/

//можно через ctrl+/
//Выделить нужный текст и нажать эти кнопки

// Типы переменных
int a = 25;
double b = -14.7;
string c = "word";
char d = '!';
bool e = false;

// Аналогичные команды
Console.WriteLine("My number is " + a);
Console.WriteLine($"My number is {a}");

// Запросить у пользователя число, внести значение в ячейку num,
 // Convert.ToInt32 -конвертировать полученное сзначение в число,
 // 32 - выдлеляет место для значения
Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Yor new number is " + num);

// Напишите программу, которая на вход принимает
//два числа и проверяет,
//является ли первое число квадратом второго.
/*
Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(n1 == quad2)
{
    Console.WriteLine("Yes");
}
// Если только одна команда, то можно скобки {} не ставить
// Если 2 и больше команды то скобки нужны
else
{
    Console.WriteLine("No");
}
*/
/* Напишите программу, которая на вход принимает
одно число (N), а на выходе показывает все целые
числа в промежутке от -N до N.
*/

// Вели и прочитали переменную

Console.Write("Input a positive integer number: ");
int n = Convert.ToInt32(Console.ReadLine());

int current = -n;
while(current <= n)
{
   Console.Write(current + "");
   current++; // Увеличить на 1 переменную, можно на любое число уменьшить, увеличить, умножить и так далее.

}

// Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю
// цифру этого числа.
/*
остаток от деления
31625 % 10 = 5
31625 % 100 = 25
31625 % 1000 = 625
31625 % 10000 = 1625
31625 % 100000 = 316225
(выделяем младший разряд)

деление без остатка
31625 / 10 = 3126
31625 / 100 = 312
31625 / 1000 = 31
31625 / 10000 = 3
(отсекаем младший разряд)

3125 получить 12 нужно /10 %100
*/

Console,Write("Input a three-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 10;
Console.WriteLine($"Lust digit of {num} is {result}");
