// Задача 2: Напишите программу, которая выводит 
//случайное трёхзначное число и удаляет вторую цифру этого числа.

Random rnd = new Random();
int value = rnd.Next(-999,1000);
    if ((value/100) != 0)
    {
        Console.WriteLine ($"Случайное трехзначное число: {value}"); 
        int A = value%10;
        int B = value/100;
        int result = B*10+A;
        Console.WriteLine ($"Результат: {result}"); 
    }
else
{
    Console.WriteLine ("Число не трехзначное, повторите запрос");
}
