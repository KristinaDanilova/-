// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = Convert.ToInt32(new Random().Next(0, 10)); 
        }
    }     
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t ");
        }
        Console.WriteLine();
    }
}
            
void AverageColumn(int m, int n, int[,] matrix)
{
    double[] sum = new double[m];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            sum[i] += matrix[j, i];    
        } 
        Console.WriteLine($"Среднее арифметическое чисел в {i+1} стобце равно: {sum[i] / n}");
    }
}
            
Console.Write("Введите количество строк:");
int n = int.Parse(Console.ReadLine());  
Console.Write("Введите количество столбцов:");
int m = int.Parse(Console.ReadLine());
int[,] array = new int[n, m];
FillArray(array);
PrintArray(array);
AverageColumn(m, n, array);
