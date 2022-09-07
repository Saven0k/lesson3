// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

//ВАриант не плохой но не продуман - поэтому никак
// Console.Clear();
// Console.WriteLine("Введите координату  точкек: ");
// string numbers = Console.ReadLine();
// double result = Math. Sqrt(((numbers[3] - numbers[12])*(numbers[3] - numbers[12])) + ((numbers[5] - numbers[14])*(numbers[5] - numbers[14])));
// Console.WriteLine(result);

Console.Clear();
Console.WriteLine("Введите координату A-x: ");
int Ax = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату A-y: ");
int Ay = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b-x: ");
int Bx = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату b-y: ");
int By = int.Parse(Console.ReadLine());
Console.WriteLine(Math.Round(Math.Sqrt((Math.Pow((Ax-Bx) , 2)) + (Math.Pow((Ay-By), 2))) , ));
