// Задача 2: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.

string Promt(string msg)
{
    Console.WriteLine(msg);
    string Value = Console.ReadLine();
    string newValue = Value.Trim(new Char[] { ' ', '-' } );
    return newValue;
}

int[] numberToArray(string numbers)
{
    int[] array = new int[numbers.Length];
    for (int i = 0; i < numbers.Length; i++)
    {
        array[i] = int.Parse(numbers[i].ToString());
    }
    return array;
}

int sumElementOfArray (int [] array)
{
    int sum = 0;
    for (int i=0; i<array.Length; i++)
    {
        sum = sum + array [i];
    }
    return sum;
}

string number = Promt("Введите число:");

int[] digits = numberToArray(number);
int sumDigits = sumElementOfArray (digits);

Console.WriteLine($"Сумма цифр в числе: {sumDigits}");
