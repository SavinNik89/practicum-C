// Задача 1: Напишите цикл, который принимает 
// на вход два числа (A и B) и возводит число A в натуральную степень B.

int Promt(string msg)
{
    Console.WriteLine(msg);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

int numA = Promt("Введите число:");
int pow = Promt("Введите степень:");
int numPow = 1;
if (pow < 1)
{
    Console.WriteLine("Степень должна являться натуральным числом, повторите ввод");
    pow = Promt("Введите степень:");
    for (int i = 1; i <= pow; i++)
    {
        numPow = numPow * numA;
    }
}
else
{
    for (int i = 1; i <= pow; i++)
    {
        numPow = numPow * numA;
    }
}
Console.WriteLine($"Число {numA} в степени {pow} = {numPow}");