// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] Koefficient = new double[2, 2];
double[] TochkaPer = new double[2];

void koef(double[,] koef)
{
    for (int i = 0; i < koef.GetLenght(0); i++)
    {
        Console.Write($"Введите коэффициенты уравнения: {i + 1}");
        for (int j = 0; j < koef.GetLenght(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите k1 и k2: ");
            }
            else Console.Write($"Введите b1 и b2: ");
            koef[i,j] = int.Parse(Console.ReadLine()); 
        }
    }
}

double[] TochkaPeresechenia(double[,] koef)
{
    // x = (b2 - b1) / (k1 - k2)
    // y = x * k1 + b1
    TochkaPer[0] = (koef[1,1] - koef[0,1]) / (koef[0,0] - koef[1,0]);
    TochkaPer[1] = TochkaPer[0] * koef[0,0] + koef[0,1];
    return TochkaPer;
}

Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine($"Пересечение в точке: ({x};{y})");








Console.WriteLine($"Пересечение в точке: ({x};{y})");