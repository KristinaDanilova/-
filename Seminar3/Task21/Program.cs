﻿// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z1");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите z2");
int z2 = int.Parse(Console.ReadLine());

int sqr1 = (x2 - x1) * (x2 - x1);
int sqr2 = (y2 - y1) * (y2 - y1);
int sqr3 = (z2 - z1) * (z2 - z1);

int sum = sqr1 + sqr2 + sqr3;
double result = Math.Sqrt(sum);
Console.WriteLine($"{result:f2}");

