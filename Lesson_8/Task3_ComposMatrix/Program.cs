//Задача 3: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
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

int[,] ComposMatrix(int[,] array1, int[,] array2)
{
    int[,] arrayCompos = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                if (array1.GetLength(0) != array2.GetLength(1))
                {
                    Console.WriteLine("Умножение матриц невозможно, задайте равные матрицы");
                    break;
                }
                arrayCompos[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return arrayCompos;
}

int[,] matrix1 = FillArray(2, 2);
int[,] matrix2 = FillArray(2, 2);
int[,] matrixComp = ComposMatrix(matrix1, matrix2);

PrintArray(matrix1);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
PrintArray(matrixComp);
