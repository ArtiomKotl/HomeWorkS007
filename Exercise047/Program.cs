// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


float[,] GenerateArray(int m, int n, int min, int max)
{
  Random random = new Random();
  float[,] array = new float[m, n];

  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      float randNum = random.NextSingle() * (max - min) + min;
      array[i, j] = (float)Math.Round(randNum, 1);
    }
  }
  return array;
}

void PrintArray2D(float[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == (array.GetLength(1) - 1))
        Console.WriteLine(String.Format("{0,5}]", array[i, j]));
      else
        Console.Write(String.Format("{0,5} ", array[i, j]));
    }
  }
}


float[,] array = GenerateArray(3, 4, -99, 99);
PrintArray2D(array);