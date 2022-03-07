// Задача 3: Напишите программу, которая выводит 
//третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine ("Введите число:"); 
string strValue = Console.ReadLine();
int number = int.Parse(strValue);
if (number<0) number = -number;
//Console.WriteLine ($"{number}");  
string Value1 = Convert.ToString (number);
//Console.WriteLine ($"{Value1}");  
int Value = Value1.Length;
   
       if (Value < 3) Console.WriteLine ("Третья цифра отсутствует");
    else
        {
        char thirdChar = Value1 [2];
        Console.WriteLine ($"{thirdChar}");    
        }
