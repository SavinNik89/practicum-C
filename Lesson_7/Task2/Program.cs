// Задача 2: Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] FillArray(int row, int column)
{
    double[,] array = new double[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:0.00}   ");
        }
        Console.WriteLine();
    }
}

int Promt(string msg)
{
    Console.Write(msg);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}


void FoundElement(double[,] array)
{
    int i = Promt("Введите номер строки: ") - 1;
    int j = Promt("Введите номер столбца: ") - 1;
    if ((i+1) > array.GetLength(0) && (j+1) > array.GetLength(1)) 
    {
    Console.WriteLine ("такой позиции не существует");
    return;
    }
    Console.WriteLine($"Значение искомого элемента: {array[i, j]:0.00}");
}


double[,] array = FillArray(4, 4);
PrintArray(array);
Console.WriteLine();
FoundElement(array);