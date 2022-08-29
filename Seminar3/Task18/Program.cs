// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон координат (x,y).

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int num = int.Parse(Console.ReadLine());

if (num == 1)
{
    Console.WriteLine("x > 0 и y > 0");
}
else 
if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else 
if (num == 2)
{
    Console.WriteLine("x < 0 и y > 0");
}
else 
if (num == 3)
{
    Console.WriteLine("x < 0 и y < 0");
}
else 
if (num == 4)
{
    Console.WriteLine("x > 0 и y < 0");
}
else 
{
    Console.WriteLine("Введите правильный номер четверти 1-4");
}