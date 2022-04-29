//Задача 3: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления 
//нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит, 
//которые занимают числа из массива info. Напишите программу, которая составит
 //массив десятичных представлений чисел массива data с учётом информации из массива info.


// заполнение массива
int[] FillArray(int len, int min, int max)
{
    int[] array = new int[len];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {

        array[i] = rnd.Next(min, max);
    }
    return array;
}

//вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}  ");
    }
}

// сумма элементов массива
int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        sum = sum + array[i];
    }
    return sum;
}

//возведение в степень
int Powering(int a, int b)
{
    if (b <= 0) return 1;
    return a * Powering(a, b - 1);
}

//перевод двоичного числа, заданного элементами массива по длине, равной элементам второго массива, в десятичное число
//вывод результата в виде нового массива
int[] BinToDec(int[] binaryArray, int[] bitArray, int start = 0, int len = 0)
{
    int[] newDec = new int[bitArray.Length];
    int c = 0;
    while (len < bitArray.Length)
    {
        int temp = 0;
        c = bitArray[len];
        for (int i = 0; i < c; i++)
        {
            temp = temp + binaryArray[start + c - i - 1] * Powering(2, i);
        }
        newDec[len] = temp;
        start = start + c;
        len = len + 1;
    }
    return newDec;
}



// создание и заполнение произвольных массивов, отвечающих условиям задачи
int[] info = FillArray(5, 1, 4);
int lenBinArray = SumArray(info);
int[] data = FillArray(lenBinArray, 0, 2);

// массивы из условия задачи (для проверки)
//int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
//int [] info = {2,3,3,1};

PrintArray(info);
Console.WriteLine();
PrintArray(data);
Console.WriteLine();
PrintArray(BinToDec(data, info));

