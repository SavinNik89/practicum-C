// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа 
// в промежутке от M до N с помощью рекурсии.


int Promt(string msg)
{
    Console.Write(msg);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

//для  m < n
void PrintNaturalEvenNumberInc(int m, int n) 
{
    int firstEvenNum = 2;
        if (n <= 0) Console.WriteLine("Четные натуральные числа в указанном диапазоне отсутствуют");
        if (m % 2 != 0) m = m + 1;
        if (m <= 0) m = firstEvenNum;
        if (n < m) return;
        Console.Write($"{m}\t");
        PrintNaturalEvenNumberInc(m + 2, n);
}
// для m>n
void PrintNaturalEvenNumberDec (int m, int n)
{
        int firstEvenNum = 2;
        if (m < n) return;
        if (n <= 0) n = firstEvenNum;
        if (m <= 0) Console.WriteLine("Четные натуральные числа в указанном диапазоне отсутствуют");
        if (m % 2 != 0) m = m - 1;
        Console.Write($"{m}\t");
        PrintNaturalEvenNumberDec(m - 2, n);
}

int m = Promt("Введите число M: ");
int n = Promt("Введите число N: ");
Console.WriteLine($"Натуральные четные числа от {m} до {n}: ");
if (m<n) PrintNaturalEvenNumberInc (m, n);
else PrintNaturalEvenNumberDec (m, n);

