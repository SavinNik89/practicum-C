// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N используя рекурсию.


int Promt(string msg)
{
    Console.Write(msg);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

//для  m < n
int PrintNaturalNumberSumInc (int m, int n) 
{
    int firstNutNum = 1;
    int sum = 0;
        if (n <= 0) Console.WriteLine("Натуральные числа в указанном диапазоне отсутствуют");
        if (m <= 0) m = firstNutNum;
        if (m > n) return 0;
        sum = sum + m + PrintNaturalNumberSumInc (m + 1, n);
    return sum;
}

// для m>n
int PrintNaturalNumberSumDec (int m, int n)
{
        int firstNutNum = 1;
        int sum = 0;
        if (m < n) return 0;
        if (n <= 0) n = firstNutNum;
        if (m <= 0) Console.WriteLine("Натуральные числа в указанном диапазоне отсутствуют");
        sum = sum + m + PrintNaturalNumberSumDec (m - 1, n);
    return sum;
}

int m = Promt("Введите число M: ");
int n = Promt("Введите число N: ");
Console.WriteLine($"Сумма натуральных чисел от {m} до {n}: ");
if (m<n) Console.WriteLine ($"{PrintNaturalNumberSumInc (m, n)}");
else Console.WriteLine ($"{PrintNaturalNumberSumDec (m, n)}");