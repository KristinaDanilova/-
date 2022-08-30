// Напишите программу, которая принимает на вход пятизначное число
// и проверяет,является ли оно палиндромом.

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());

if (num >= 10000 && num <= 99999)
{
int num1 = num / 10000;
int num2 = (num / 1000) % 10;
int num4 = (num % 100) / 10;
int num5 = num % 10;
if (num1 == num5 && num2 == num4)
{
    Console.WriteLine("Да,это палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}
}
else 
{
    Console.WriteLine("Введенное число не является пятизначным");
}