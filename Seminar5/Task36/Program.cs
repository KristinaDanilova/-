// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19

int[] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumNumber(int[] array)
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
