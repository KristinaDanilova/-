Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
if (a > b)
{
    Console.WriteLine($"max = {a}");
    Console.WriteLine($"min = {b}");
} 
else if (a < b)
{
    Console.WriteLine($"min = {a}");
    Console.WriteLine($"max = {b}");
}
else {
    Console.WriteLine("Введённые числа равны");
}
