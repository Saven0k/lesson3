// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a = 1;
Console.Write($"{number} -> ");
bool b = true;
while(b == true)
{
    if (number > 0)
    {
    b = false;
    while(a<number)
    {
    Console.Write($"{Math.Pow((a) , 3)} , ");
    a++;
    }
    Console.Write($"{Math.Pow((number) , 3)  }. ");
    b = false;
    }
    else 
    { 
    Console.WriteLine($"{number} это число не точно");
    b = true;
    Console.Write("Введите число: ");
    int number1 = int.Parse(Console.ReadLine());
    Console.Write($"{number1} -> ");
    if (number1 > 0)
    {
    b = false;
    while(a<number1)
    {
    Console.Write($"{Math.Pow((a) , 3)} , ");
    a++;
    }
    Console.Write($"{Math.Pow((number1) , 3)  }. ");
    b = false;
    }
    else 
    { 
    Console.WriteLine($"{number1} это число не точно");
    }    
}
}
