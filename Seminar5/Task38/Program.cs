// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arrayNumbers = new double[5];
  for (int i = 0; i < arrayNumbers.Length; i++ )
  {
    arrayNumbers[i] = new Random().Next(1, 5) + new Random().NextDouble();
    Console.Write(arrayNumbers[i] + " ");
  }

double maxNumber = arrayNumbers[0];
double minNumber = arrayNumbers[0];

  for (int i = 1; i < arrayNumbers.Length; i++)
  {
    if (maxNumber < arrayNumbers[i])
    {
      maxNumber = arrayNumbers[i];
    }
        if (minNumber > arrayNumbers[i])
    {
      minNumber = arrayNumbers[i];
    }
  }

  double diff = maxNumber - minNumber;

  Console.WriteLine($"\n{diff}");