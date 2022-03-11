// Задача 4: Напишите программу, которая принимает 
//на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.WriteLine ("Введите порядковый номер дня недели:"); 
string strValue = Console.ReadLine();
int Value = int.Parse(strValue);
    if (Value <= 7 & Value >= 1) 
    {
        if (Value <= 5 & Value >= 1) Console.WriteLine ("Будний день");
        else Console.WriteLine ("Выходной день");
    }
    else
    {
        Console.WriteLine ("Нет такого дня недели");    
    }

