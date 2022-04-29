/* Задача 4: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)?
 Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰ */

// Задача 73: Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы,
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)?
// Найдите M при заданном N и получите одно из разбиений на группы N <= 10^20.

// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48

using System;

void SimpleNumbersGroup(int n, int[,] baseArray)  // делаем расчет матрицы
{
    bool flag = false;
    for (int k = 1; k <= n; k++)  // цикл по всем числам
    {
        flag = false;
        for (int i = 0; i < baseArray.GetLength(0); i++)
        {
            for (int j = 0; j < baseArray.GetLength(1); j++)
            {
                if (baseArray[i, j] == 0)  // если нашли пустую ячеку - то заполняем ее 
                {                           // и прерываем цикл j
                    baseArray[i, j] = k;
                    flag = true;
                    break;
                }
                else
                {
                    if (k % baseArray[i, j] == 0) break;  // переход к следующей строке 
                }
            }
            if (flag) break;  // если ячейка была заполнена прерываем цикл i, k++
        }
    }
}

void PrintArray(int[,] baseArray)
{
    for (int i = 0; i < baseArray.GetLength(0); i++)
    {
        if (baseArray[i, 0] == 0) break; // прерывание печати пустой строки
        else
        {
            Console.Write($"Группа {i + 1}: ");
            for (int j = 0; j < baseArray.GetLength(1); j++)
            {
                if (baseArray[i, j] == 0) break; // вывод только заполненных ячеек
                else
                    Console.Write($"{baseArray[i, j],4}");
            }
            Console.WriteLine();
        }
    }
}





Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[,] baseArray = new int[N, N];
SimpleNumbersGroup(N, baseArray);
int M = 0;
for (int i = 0; i < baseArray.GetLength(0); i++)
    if (baseArray[i, 0] == 0) break;
    else { M++; }
Console.WriteLine($"Для N={N}, будет M={M} взаимно простых групп:");
PrintArray(baseArray);


