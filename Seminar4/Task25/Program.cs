// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)

int xNumber(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;
    }
    return result;
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

Console.WriteLine($"{xNumber(numberA, numberB)}");
