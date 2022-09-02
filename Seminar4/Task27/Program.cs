// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11

int sumNumber(int num)
{
int sum = 0;
while (num > 0)
{
    sum = sum + (num % 10);
    num = num / 10;
}
return sum;
}

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"{sumNumber(number)}");
