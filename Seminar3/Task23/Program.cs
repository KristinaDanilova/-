﻿// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27.  5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int numberN = int.Parse(Console.ReadLine());

for (int i = 1; i <= numberN; i++)
{
    Console.Write($"{i*i*i}, ");
}
Console.WriteLine();
