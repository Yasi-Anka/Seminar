// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)//генерация рандомного двумерного массива
{
    int[,] array = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
                array[i,j] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void Show2dArray(int[,] array)// печать двумерного массива
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(0); j++)
        Console.Write(array[i,j] + " ");

    Console.WriteLine();
    }
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= 0 && row1 < array.GetLength(0) &&
        row2 >= 0 && row2 < array.GetLength(0) &&
        row1 != row2)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                int temp = array[row1, j];
                array[row1, j] = array[row2, j];
                array[row2, j] = temp;
            }
        }
}

Console.Write("Input a number of cows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(myArray);
Console.Write("Введите номер первой строки ");
int r1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер второй строки ");
int r2 = Convert.ToInt32(Console.ReadLine());

ChangeRows(myArray, r1, r2);
Show2dArray(myArray);

// Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае,
// если это невозможно, программа должна вывести
// сообщение для пользователя.
/*
3 4 9
2 6 8
1 0 6

3 2 1
4 6 0
1 0 6
*/
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue){
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array){
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
void Replaceing(int[,] array){
    if(array.GetLength(0) == array.GetLength(1))
    for(int i = 0; i< array.GetLength(0)-1; i++){
    for(int j = i+1; j< array.GetLength(1); j++){
        int temp = array[i,j];
        array[i,j] = array[j,i];
        array[j,i] = temp;
        }
    }
    else Console.WriteLine("Array is assimetric");
}
Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);
Console.WriteLine();
Replaceing(myArray);
Show2dArray(myArray);


// Из двумерного массива целых чисел удалить строку
// и столбец, на пересечении которых расположен
// наименьший элемент.

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue){
    int[,] array = new int[rows, columns];
    for(int i = 0; i<rows; i++){
        for(int j = 0; j< columns; j++){
            array[i,j] = new Random().Next(minValue, maxValue+1);
        }
    }
    return array;
}
void Show2dArray(int[,] array){
    for(int i = 0; i< array.GetLength(0); i++){
        for(int j = 0; j< array.GetLength(1); j++){
            Console.Write(array[i,j] + " ");}
    Console.WriteLine();
    }
}
int FindIndexOfMin(int[,] array)
{
    int min = array[0,0];
    int minI = 0;
    int minJ = 0;
    for(int i = 0; i< array.GetLength(0); i++)
        for(int j = 0; j< array.GetLength(1); j++)
            if(array[i,j] < min) 
            {
                min = array[i,j];
                minI = i;
                minJ = j;
            }
    int[,] nArray = new int[array.GetLength(0)-1, array.GetLength(1)-1];
        for(int i = 0; i< array.GetLength(0); i++)
        if()
            for(int j = 0; j< array.GetLength(1); j++)

}

Console.WriteLine("Input a number of rows:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number of columns:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mininmum of value:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input maximum of value:");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateRandom2dArray(m,n,min,max);
Show2dArray(myArray);