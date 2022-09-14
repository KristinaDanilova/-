// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int Num (int[] arr)
{
    int count = 0; 
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Сколько чисел необходимо ввести: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числа через пробел: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine($"Количество чисел > 0: {Num(arr)}");
