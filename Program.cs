// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
Console.WriteLine("Введите координату A-x: ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату A-y: ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату A-z: ");
int Az = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B-x: ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B-y: ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату B-z: ");
int Bz = int.Parse(Console.ReadLine());
double result = (Math.Pow((Ax-Bx), 2)) + (Math.Pow((Ay-By), 2)) + (Math.Pow((Az-Bz), 2));
Console.WriteLine(Math.Round(Math.Sqrt(result) , 2));
