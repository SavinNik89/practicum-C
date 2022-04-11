//Задача 4: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.


int[,,] Fill3dArray(int row, int column, int row2)
{
    int[,,] array = new int[row, column, row2];
    int n = 0;
    Random rnd = new Random();
    List<int> list = Enumerable.Range(10, row * column * row2).ToList();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = list[n];
                n++;
            }
        }
    }
    return array;
}

void Print3dArray (int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} [{i}, {j}, {k}]   ");
            }
            Console.WriteLine();
        }
    }
}

int [,,] array = Fill3dArray (4, 4, 4);
Print3dArray (array);