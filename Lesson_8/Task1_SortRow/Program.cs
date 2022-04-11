﻿//Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 100);
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

int[,] SortRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = array[i, 0];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (var k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k]) continue;
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
    return array;
}

int[,] array = FillArray(3, 15);
PrintArray(array);
SortRow(array);
Console.WriteLine();
PrintArray(array);