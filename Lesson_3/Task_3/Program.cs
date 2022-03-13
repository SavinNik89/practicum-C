// Задача 3: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


Console.WriteLine ("Введите натуральное число:"); 
string strValue = Console.ReadLine();
int N = int.Parse(strValue);
double [] arrPow = new double[N];
int a = 1;

for (int i = 0; i < arrPow.Length; i++)
            {
                arrPow[i] = Math.Pow (a,3); 
                a++;              
                Console.Write($"{arrPow[i]} ");               
            }


