// Задача 1: Определите, является ли число степенью двойки:
//N = 16 -> "Является степень двойки"
//N = 12 -> “Не является степенью двойки”


void Power2(int N)
{
    double count = 0;
    int pow = 0;
    if (N == 1) 
    {
        count = 0;
        pow = 0;
    }
    else
    {
        if (N > 1)
        {
            while (N > 1)
            {
                count = count + (N % 2);
                N = N / 2;
                pow++;
            }
        }
    }
   if (count == 0) Console.WriteLine($"Число является {pow} степенью двойки");
   else Console.WriteLine("Число не является степенью двойки");
}

Console.WriteLine("Введите число для проверки:");
int N = Convert.ToInt32(Console.ReadLine());
Power2 (N);