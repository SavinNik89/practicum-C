// Задача 2: Проверка на простое число:
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int[] FillArray(int N)
{
    int[] array = new int[N];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
    return array;
}

void CheckNumber(int N)
{
    int[] array = FillArray(N);
    for (int i = 1; i < array.Length - 1; i++)
    {
        if (N % array[i] == 0)
        {
            Console.WriteLine("Число не является простым");
            return;
        }
    }
    Console.WriteLine("Число является простым");
}


Console.WriteLine("Введите число для проверки:");
int N = Convert.ToInt32(Console.ReadLine());
CheckNumber (N);