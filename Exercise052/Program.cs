// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] Generate2DArray(int m, int n, int min, int max)
{
  int[,] array2D = new int[m, n];
  Random random = new Random();
  for (int i = 0; i < array2D.GetLength(0); i++)
  {
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
      array2D[i, j] = random.Next(min, max + 1);
    }
  }
  return array2D;
}

void PrintArray2D(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == (array.GetLength(1) - 1))
        Console.WriteLine(String.Format("{0,4}", array[i, j]));
      else
        Console.Write(String.Format("{0,4} ", array[i, j]));
    }
  }
}

int NumberOfColumns()
{
  Console.Write("Ведите количество столбцов 2D массива: ");
  int.TryParse(Console.ReadLine(), out int num);
  while (num <= 0)
  {
    Console.Write("Число меньше 1! Попробуйте ещё: ");
    int.TryParse(Console.ReadLine(), out num);
  }
  return num;
}

int NumberOfRows()
{
  Console.Write("Ведите количество строк 2D массива: ");
  int.TryParse(Console.ReadLine(), out int num);
  while (num <= 0)
  {
    Console.Write("Число меньше 1! Попробуйте ещё: ");
    int.TryParse(Console.ReadLine(), out num);
  }
  return num;
}

int ReceiveMinMax(string minOrMax)
{
  Console.Write($"Введите значение {minOrMax}: ");
  int.TryParse(Console.ReadLine(), out int result);
  return result;
}

void PrintArray(float[] arrayPrint)
{
  for (int index = 0; index < arrayPrint.Length; index++)
  {
    if (index == (arrayPrint.Length - 1))
      Console.WriteLine(String.Format("{0,5:0.00}", arrayPrint[index]));
    else
      Console.Write(String.Format("{0,5:0.00} ", arrayPrint[index]));
  }
}

float[] CreateArithmeticMeanArray(int[,] array2d)
{
  float[] resultArray = new float[array2d.GetLength(1)];
  float sum = 0;
  for (int i = 0; i < array2d.GetLength(1); i++)
  {
    sum = 0;
    for (int j = 0; j < array2d.GetLength(0); j++)
    {
      sum += array2d[j, i];
    }
    resultArray[i] = sum / array2d.GetLength(0);
  }
  return resultArray;
}


int m = NumberOfRows();
int n = NumberOfColumns();
int min = ReceiveMinMax("минимума");
int max = ReceiveMinMax("максимума");

int[,] random2dArray = Generate2DArray(m, n, min, max);
PrintArray2D(random2dArray);
float[] arithmeticMeanArray = CreateArithmeticMeanArray(random2dArray);
Console.Write("Среднее арифметическое каждого столбца:");
PrintArray(arithmeticMeanArray);