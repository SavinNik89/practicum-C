// Задача 2: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 20);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void FoundMinRow (int [,] array)
{
    int minSum = 0;
    int minPos = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            tempSum += array [i,j];
        }
        if (tempSum < minSum || minSum == 0) 
        {
           minSum = tempSum;
           minPos = i+1; 
        }
    }
Console.WriteLine ($"Минимальная сумма элементов в строке {minPos} и равна {minSum}");
}

int [,] array = FillArray (3, 4);
PrintArray (array);
FoundMinRow (array);