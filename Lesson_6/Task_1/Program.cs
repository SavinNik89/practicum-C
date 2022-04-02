// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь


int Promt(string msg)
{
    Console.WriteLine(msg);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int[] CreateArray(int M)
{
    int[] array = new int[M];
    for (int i = 0; i < M; i++)
    {
        array[i] = Promt ($"Введите число {i+1}:");
    }
    return array;
}

void PrintArr (int [] arr)
{
for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write (arr [i]+", ");
    }
    Console.WriteLine (arr [arr.Length-1]);
}

int CountPos (int [] arr)
{
    int count = 0;
    for (int i = 0; i<arr.Length; i++)
    {
        if (arr [i] > 0) count++;
    }
    return count;
}


int M = Promt ("Какое количество чисел необходимоо ввести? =>");
int [] numbers = CreateArray (M);
Console.WriteLine ("Введенные числа:");
PrintArr (numbers);
Console.WriteLine ($"Количество положительных чисел = {CountPos(numbers)}");
