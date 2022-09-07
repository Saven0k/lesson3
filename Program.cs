// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int a = 1;
Console.Write($"{a} -> ");
bool b = true;
while(b == true)
{
    if (number > 0)
    {
    b = false;
    while(a<number)
    {
    Console.Write($"{Math.Pow((a) , 2)} , ");
    a++;
    }
    Console.Write($"{Math.Pow((number) , 2)  }. ");
    b = false;
    }
    else 
    { 
    Console.WriteLine($"{number} это число не точно");
    b = true;
    Console.WriteLine("Введите число: ");
    int number1 = int.Parse(Console.ReadLine());
    if (number1 > 0)
    {
    b = false;
    while(a<number1)
    {
    Console.Write($"{Math.Pow((a) , 2)} , ");
    a++;
    }
    Console.Write($"{Math.Pow((number1) , 2)  }. ");
    b = false;
    }
    else 
    { 
    Console.WriteLine($"{number1} это число не точно");
    }    
}
}
