// Напишите программу, которая принимает на вход координаты
// 2х точек и находит расстояние между ними в 2D пространстве.
//d=|AB|=|BA| вектора. d=кв корень из ((x1-x2)кв)+(y1-y2)кв)

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine());

int sqr1 = (x1 - x2) * (x1 - x2);
int sqr2 = (y1 - y2) * (y1 - y2);

int sum = sqr1 + sqr2;
double result = Math.Sqrt(sum);
Console.WriteLine($"{result:f2}");
