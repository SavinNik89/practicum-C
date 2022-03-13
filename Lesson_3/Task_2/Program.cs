// Задача 2: Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.

// Так и не придумал как нужно и можно в данной задаче использовать метод (функцию)

Console.WriteLine ("Введите координатe первой точки по оси Х:"); 
double X1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координату первой точки по оси Y:"); 
double Y1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координату первой точки по оси Z:"); 
double Z1 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координату второй точки по оси X:"); 
double X2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координату второй точки по оси Y:"); 
double Y2 = Convert.ToDouble (Console.ReadLine());

Console.WriteLine ("Введите координату второй точки по оси Z:"); 
double Z2 = Convert.ToDouble (Console.ReadLine());

double distance = Math.Sqrt (Math.Pow ((X2-X1),2)+Math.Pow ((Y2-Y1),2)+Math.Pow ((Z2-Z1),2));
Console.WriteLine ($"Расстояние между двумя точками равно: {distance}"); 

