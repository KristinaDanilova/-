// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int ChetNumber(int[] array)
{
    int[] result = new int[array.Length];
    int number = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int chet = array [i] % 2;
        if (chet == 0)
        number++;
    }
    return number;
}

int[] myArray = GetArray(10, 100, 999);
Console.WriteLine(String.Join(" ", myArray));

int result = ChetNumber(myArray);
Console.WriteLine($"Количество четных чисел в массиве: {result}");
