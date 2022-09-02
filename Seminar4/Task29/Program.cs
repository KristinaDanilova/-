// Напишите программу, которая задаёт массив из N элементов,
// заполненных случайнми числами из [a, b) и выводит их на экран.
// 5, 0, 20 -> [1, 2, 5, 7, 19]. 3, 1, 35 -> [6, 1, 33]

int[] CreateArray(int n, int a, int b)
{
int[] arrayOfNumbers = new int[n];
for (int i = 0; i < n; i++)
{
    arrayOfNumbers[i] = new Random().Next(a, b-1);
}
return arrayOfNumbers;
}

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.Write("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine(String.Join(", ", CreateArray(n, a, b)));
