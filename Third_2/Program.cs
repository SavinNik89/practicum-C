// Задача 3: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число:"); 
string strValue = Console.ReadLine();
int Value = strValue.Length;
    if (Value < 3) Console.WriteLine ("Третья цифра отсутствует");
    else
        {
        char thirdChar = strValue [2];
        Console.WriteLine ($"{thirdChar}");    
        }
