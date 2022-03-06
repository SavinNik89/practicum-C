// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Введите первое число:"); 
string strValue=Console.ReadLine();
int Value = int.Parse(strValue);

Console.WriteLine ("Введите второе число:"); 
string strValue1=Console.ReadLine();
int Value1 = int.Parse(strValue1);

Console.WriteLine ("Введите третье число:"); 
string strValue2=Console.ReadLine();
int Value2 = int.Parse(strValue2);

int max = Value;
if (Value1>max) max = Value1;
if (Value2>max) max = Value2;

Console.WriteLine ($"Максимальное число = {max}");