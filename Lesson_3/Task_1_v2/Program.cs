// Задача 1: Напишите программу, которая принимает на вход 
//пятизначное число и проверяет, является ли оно палиндромом.
// ВАРИАНТ ДЛЯ ЛЮБЫХ ЧИСЕЛ С ИСПОЛЬЗОВАНИЕМ МАССИВА 


Console.WriteLine ("Введите число:"); 
string strValue = Console.ReadLine();
string Value = strValue.Trim(new Char[] { ' ', '-' } );

//Перевод в массив и разворот массива
char[] array1 = Value.ToArray(); 
char[] array2 = (char[])array1.Clone();
Array.Reverse (array1);

//вывод обратного порядка числа на экран (для проверки)
    Console.Write($"Обратный порядок введенного числа:");
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]}");
    }
    
    Console.WriteLine(" ");
// сравнение массива и обратного массива    
for(var i = 0; i < array1.Length; i++)
                {
                    if (array1[i].Equals(array2[i]))
                    {
                        if(i == array1.Length-1)
                        {
                            Console.WriteLine("Введенное число является палиндромом");
                        }
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Введенное число не является палиндромом");
                        break;
                    }
                }
