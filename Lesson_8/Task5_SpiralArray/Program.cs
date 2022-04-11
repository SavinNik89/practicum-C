// Задача *5: Заполните спирально массив 4 на 4 по возрастанию

int[,] FillArraySpiral ()
{
    int[,] array = new int[4, 4];
    int count = 1;
    //первая строка слева на право
    for (int i = 0; i <= 0; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //правый столбец сверху вниз
    for (int j = array.GetLength(1)-1; j < array.GetLength(1); j++)
    {
        for (int i = array.GetLength(0)-(array.GetLength(0)-1); i < array.GetLength(0); i++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //нижняя строка с права на лево
    for (int i = array.GetLength(0)-1; i < array.GetLength(0); i++)
    {
        for (int j = 2; j >= 0; j--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // левый столбец с низу в верх
    for (int j = 0; j >= 0; j--)
    {
        for (int i = 2; i >= 1; i--)
        {
            array[i, j] = count;
            count++;
        }
    }
    // вторая строка с лева на право
    for (int i = 1; i < 2; i++)
    {
        for (int j = 1; j <= 2; j++)
        {
            array[i, j] = count;
            count++;
        }
    }
    //третья строка с права на лево
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j >= 1; j--)
        {
            array[i, j] = count;
            count++;
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

int [,] SpiralArray = FillArraySpiral ();
PrintArray (SpiralArray);