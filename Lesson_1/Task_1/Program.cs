//домашнее задание 1 Задача 1
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Введите первое число:"); 
string strValue=Console.ReadLine();
int Value = int.Parse(strValue);

Console.WriteLine ("Введите второе число:"); 
string strValue1=Console.ReadLine();
int Value1 = int.Parse(strValue1);

if (Value<Value1)
Console.WriteLine("Второе число больше первого"); 
else
Console.WriteLine("Первое число больше второго"); 
