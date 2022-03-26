// // Задача 3: Напишите программу, которая задаёт массив из 8 элементов 
// случайными числами и выводит их на экран. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах)

int [] createRandArray (string msg)
{
    Console.WriteLine("Введите количество элементов массива");
    string Value = Console.ReadLine();
    int quantityElements = int.Parse(Value);
    if (quantityElements < 1)
    {
        Console.WriteLine("Должно быть введено натуральное число, повторите ввод");
        Value = Console.ReadLine();
        quantityElements = int.Parse(Value);

        int[] array = new int[quantityElements];
        Random rand = new Random();
        for (int i = 0; i < quantityElements; i++)
             {
                array[i] = rand.Next();
                Console.Write ($"{array[i]}, ");
             }
             return array;
    }
    else
    {
        int[] array = new int[quantityElements];
        Random rand = new Random();
        for (int i = 0; i < quantityElements; i++)
             {
                array [i] = rand.Next();
                Console.Write ($"{array[i]}, ");
             }
             return array;
    }
    
}

int [] RandArr = createRandArray ("Введите количество элементов массива");