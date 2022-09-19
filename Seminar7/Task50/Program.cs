// Напишите программу, которая на вход принимает число и генерирует случайный двумерный массив, 
// и возвращает индексы этого элемента или же указание, что такого элемента нет.

void FillArray(int[,] array)
{
    for (     int i = 0; i < array.GetLength(0); i++) 
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

void CheckArray(int num, int[,] array)
{
    bool inArray = false;
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if (array [i, j]  == num)
           {
                Console.WriteLine($"({i};{j})");
                inArray = true;
           }
        }
    }     
    if (!inArray)
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
CheckArray(num, array);
