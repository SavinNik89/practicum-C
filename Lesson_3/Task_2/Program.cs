// Задача 2: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine ("Введите координатe первой точки по оси Х:"); 
double X1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координатe первой точки по оси Y:"); 
double Y1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координатe первой точки по оси Z:"); 
double Z1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координатe второй точки по оси X:"); 
double X2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координатe второй точки по оси Y:"); 
double Y2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координатe второй точки по оси Z:"); 
double Z2 = Convert.ToDouble (Console.ReadLine());

double distance = Math.Sqrt (Math.Pow ((X2-X1),2)+Math.Pow ((Y2-Y1),2)+Math.Pow ((Z2-Z1),2));
Console.WriteLine ($"Расстояние между двумя точками равно: {distance}"); 

