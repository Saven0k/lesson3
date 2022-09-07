// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a = 1;
Console.Write($"{a} -> ");
if (number <= 0) Console.WriteLine("Не точное число");
else
{
    while(a<number)
    {
    Console.Write($"{Math.Pow((a) , 2)} , ");
    a++;
    }
Console.Write($"{Math.Pow((number) , 2)  }. ");
}
