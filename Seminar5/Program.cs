// Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных элементов.
/*
int[] CreateRandomeArray(int size, int minValue, int maxValue) //создать рандомный массив величиной size, в диапазорне от ... до ..
{
    int[] array = new int[size]; // инициализация массива (выделить память для size элементов (заполняется нулями по ума=олчанию))

    for(int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);

        return array;
}   

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}

int FindNegativeSum(int[] array)
{
    int sum = 0;

    for(int i = 0; i < array.Length; i++)
        if(array[i] < 0)
            sum += array[i];
        
    return sum;

}

Console.Write("Введите колличество эллементов массива ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный эллемент массива ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный эллемент массива ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomeArray(n, min, max);

ShowArray(myArray);

int negativeSum = FindNegativeSum(myArray);
Console.WriteLine (negativeSum);

*/

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

bool Array2(int[] array, int a)
{
    bool s = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == a)
            s = true;
    }
    return s;
}
Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
bool m = Array2(myArray, a);
ShowArray(myArray);
Console.WriteLine(m);


// Задача 3. Задайте одномерный массив из m случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [a,b].

/*
int Array3 (int[] array, int a, int b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] <= b && array[i] >= a)
            count++;
    return count;
}
Console.Write("Input a number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number b: ");
int b = Convert.ToInt32(Console.ReadLine());
ShowArray(myArray);
int l = Array3(myArray, a, b);
Console.WriteLine($"Количество эл-ов массива, значения которых лежат в отрезке [{a}, {b }] = {l}");
*/

// Задача 4. Напишите программу замены элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

/*
int[] Array4(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];
    return array;
}
ShowArray(myArray);
Array4(myArray);
ShowArray(myArray);