﻿// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
Console.Write("Введите число: ");
string number = Console.ReadLine();
bool a = true;
while(a == true)
{
    if (number[0]==number[4] || number[1]==number[3])
    {
        Console.WriteLine($"{number} -> да.");
        a = false;
    }
    else 
    {
        Console.WriteLine($"{number} - > нет");
        if (number!.Length == 5)
        {
        Console.WriteLine($"Введи правильное число");
        }
        else{}
    }
}

