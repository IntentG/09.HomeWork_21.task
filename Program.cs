// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X точки A ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки A ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки A ");
double za = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координату X точки B ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки B ");
double yb = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки B ");
double zb = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
Console.WriteLine($"Расстояние между точками = {distance}");
