// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

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
        array[i] = rand.Next(-100,100);
        Console.Write($"{array[i]} ");
    }
    return array;
}

int SumOdd (int [] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (i%2 != 0) 
        sum = sum + array [i];
    }
    return sum;
}

int [] randArr = createRandArray ("Введите количество элементов массива");
Console.WriteLine ();
Console.WriteLine ($"Сумма элементов в массиве на нечетных позициях: {SumOdd (randArr)}");