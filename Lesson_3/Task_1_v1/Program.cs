// Задача 1: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine ("Введите пятизначное число:"); 
string strValue = Console.ReadLine();
int number1 = int.Parse(strValue);
if (number1<0) number1 = -number1;
string value1 = Convert.ToString (number1);
int value2 = value1.Length;
    if (value2 != 5) 
    {
        Console.WriteLine ("Введенное значение не является пятизначным числом");
    }
    else
    {
        int number2 = int.Parse(value1);
        char [] array1 = number2.ToString().ToCharArray();
            if (array1 [0]==array1[4] && array1[1]==array1[3]) 
                Console.WriteLine ("Это число палиндром");
            else
                Console.WriteLine ("Это число не является палиндромом");       
    }

