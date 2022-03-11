// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine ("Введите число"); 
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
int number = 0;
if (Value>0)
{
    number = 2;
    Console.Write($"{number}");
        while (number < Value)
        {
        number=number+2;
        Console.Write($" {number}");
        }
}
else
{
    number = -2;
    Console.Write($"{number}");
        while (number > Value)
        {
         number = number -2;
         Console.Write($" {number}");
        }
}