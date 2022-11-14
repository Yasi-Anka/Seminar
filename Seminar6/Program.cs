
int[] CreateRandomeArray(int size, int minValue, int maxValue) //создать рандомный массив величиной size, в диапазорне от ... до ..
{
    int[] array = new int[size]; // инициализация массива (выделить память для size элементов (заполняется нулями по умолчанию))

    for(int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}   

void ShowArray(int[] array) // Вывести массив на консоль
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


// Напишите программу, которая перевернёт
//одномерный массив (последний элемент будет
//на первом месте, а первый - на последнем и т.д.)

/*

void ReverseArray(int[] array)
{
    for(int i = 0, j = array.Length - 1; i < array.Length / 2; i++)
    {
        int temp = array[i];
    array[i] = array[j];
    array[j]= temp;
    }
}

Console.WriteLine("Введите величину массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное значение элемента массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное значение элемента массива ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);
ReverseArray(myArray);
ShowArray(myArray);

*/

// Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами
// такой длины.

/*
bool IsTriangle(int a, int b, int c)
{
    if(a + b > c && b + c > a && c + a > b)
    {
        return true;
    }
    return false;
}

Console.WriteLine("Введите длину стороны А");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны B");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите длину стороны C");
int c = Convert.ToInt32(Console.ReadLine());

bool result = IsTriangle(a,b,c);

*/

// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: a и b.
/*
int[] Fibonachi(int size, int a,int b )
{
    int [] array = new int[size];
    array[] = a;
    array[] = b;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
    return array;
}

Console.WriteLine("Введите величину ряда ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

int[] array = Fibonachi(n, a, b);
ShowArray(array);
*/

// Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

Console.WriteLine("Введите длину массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный эллемент массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный эллемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomeArray(n, min, max);
ShowArray(myArray);
ShowArray(CopyArray(myArray));


