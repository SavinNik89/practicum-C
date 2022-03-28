// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int[] createRandArray(string msg)
{
    Console.WriteLine(msg);
    string Value = Console.ReadLine();
    int quantityElements = int.Parse(Value);
    if (quantityElements < 1)
    {
        Console.WriteLine("Должно быть введено натуральное число, повторите ввод");
        Value = Console.ReadLine();
        quantityElements = int.Parse(Value);
    }

    int[] array = new int[quantityElements];
    Random rand = new Random();
    for (int i = 0; i < quantityElements; i++)
    {
        array[i] = rand.Next(100, 1000);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int CountEven (int [] array)
{
    int count = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0) 
        count = count + 1;
    }
    return count;
}

int [] randArr = createRandArray ("Введите количество элементов массива");
Console.WriteLine ();
Console.WriteLine ($"Количество четных элементов в массиве: {CountEven (randArr)}");
