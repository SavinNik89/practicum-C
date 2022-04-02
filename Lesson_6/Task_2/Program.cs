//Задача 2. Напишите программу, которая найдёт точку 
//пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

//  x=(b2-b1)/(k1-k2) , y=k1(b2-b1)/(k1-k2)+b1


double Promt(string msg)
{
    Console.Write(msg);
    string strValue = Console.ReadLine();
    double d1 = Convert.ToDouble(strValue);
    double Value = double.Parse(strValue);
    return Value;
}

double b1 = Promt("Значение b1 = ");
double k1 = Promt("Значение k1 = ");
double b2 = Promt("Значение b2 = ");
double k2 = Promt("Значение k2 = ");

Console.WriteLine($"b1={b1}, k1={k1}, b2={b2}, k2={k2}");

if (k2 == k1 & b1 != b2) Console.WriteLine("Прямые параллельны - точки пересечения отсутствуют");
else
{
    if (k2 == k1 & b1 == b2) Console.WriteLine("Прямые совпадают - бесконечное количество точек пересечения");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * ((b2 - b1) / (k1 - k2)) + b1;
        Console.WriteLine($"Координаты точки пересечения: x = {x}, y = {y}");
    }
}