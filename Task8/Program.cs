Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
for (int i = 2; i <= n; i++)
if ((i % 2) == 0)
{
    Console.WriteLine(i);
}
