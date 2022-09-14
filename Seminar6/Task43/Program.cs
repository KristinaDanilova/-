// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double[,] koef = new double[2, 2];
double[] TochkaPer = new double[2];

void Inkoef()
{
    Console.Write($"Введите коэффициенты уравнения \n");
    for (int i = 0; i < koef.GetLength(0); i++)
    {
        for (int j = 0; j < koef.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите k{i + 1}: ");
            }
            else Console.Write($"Введите b{i + 1}: ");
            koef[i,j] = int.Parse(Console.ReadLine()); 
        }
    }
}

double[] TochkaPeresechenia(double[,] koef)
{
    TochkaPer[0] = (koef[1,1] - koef[0,1]) / (koef[0,0] - koef[1,0]);
    TochkaPer[1] = TochkaPer[0] * koef[0,0] + koef[0,1];
    return TochkaPer;
} 

Inkoef();
Console.WriteLine($"Пересечение в точке: ({String.Join("; ",TochkaPeresechenia(koef))})");