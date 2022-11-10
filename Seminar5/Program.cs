// Задайте массив из 12 элементов, заполненный
//случайными числами из промежутка [-9, 9].
//Найдите сумму отрицательных элементов.

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