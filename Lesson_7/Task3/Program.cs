// Задача 3: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
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

void ColumnArithmeticMean (int[,] array)
{
    int sum = 0;
    double arithMean = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = sum + array[i, j];
        }
        arithMean = (double) sum / array.GetLength(0);
        Console.Write($"{arithMean:0.00}  ");
        sum = 0;
        arithMean = 0;
    }
}




int [,] array = FillArray(10, 10);
PrintArray(array);
Console.WriteLine("Среднее арифпетическое значений по столбцам =>");
ColumnArithmeticMean(array);