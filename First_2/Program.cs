// Задача 1: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число:"); 
string strValue = Console.ReadLine();
int Value = strValue.Length;
 if (Value == 3)
    {
        int number = int.Parse(strValue);
        int A = number/10;
        int B = A%10;
        Console.WriteLine ($"Вторая цифра: {B}"); 
    }
else
    {
    Console.WriteLine ("Ошибка: число не является трехзначным");    
    }

