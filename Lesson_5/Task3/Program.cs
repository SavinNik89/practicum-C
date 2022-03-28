// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

double[] createRandArray(string msg)
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

    double[] array = new double[quantityElements];
    Random rand = new Random();
    for (int i = 0; i < quantityElements; i++)
    {
        array[i] = rand.NextDouble()*100;
        string result = string.Format ("{0:0.000}", array[i]);
        Console.Write($"|{result}| ");
    }
    return array;
}

double Min (double [] array)
{
    double min = array [0];
    for (int i=1; i<array.Length; i++)
    {
        if (min > array[i]) 
        min = array[i];
    }
    return min;
}

double Max (double [] array)
{
    double max = array [0];
    for (int i=1; i<array.Length; i++)
    {
        if (max < array[i]) 
        max = array[i];
    }
    return max;
}


double [] randArr = createRandArray ("Введите количество элементов массива");
Console.WriteLine ();
double sumMinMax = Max (randArr) + Min (randArr);
string printSum = string.Format ("{0:0.000}", sumMinMax);
Console.Write(printSum);
