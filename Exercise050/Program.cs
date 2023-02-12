// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет (формат ввода произвольный, не обязательно через запятую)

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
    Console.Write("[");
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (j == (array.GetLength(1) - 1))
        Console.WriteLine(String.Format("{0,4}]", array[i, j]));
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

int ColumnsPosition()
{
  Console.Write("Ведите номер столбца для поиска элемента массива: ");
  int.TryParse(Console.ReadLine(), out int num);
  while (num <= 0)
  {
    Console.Write("Число меньше 1! Попробуйте ещё: ");
    int.TryParse(Console.ReadLine(), out num);
  }
  return num;
}

int RowsPosition()
{
  Console.Write("Введите номер строки для поиска элемента массива: ");
  int.TryParse(Console.ReadLine(), out int num);
  while (num <= 0)
  {
    Console.Write("Число меньше 1! Попробуйте ещё: ");
    int.TryParse(Console.ReadLine(), out num);
  }
  return num;
}

void SearchElement(int[,] array2d, int row, int column)
{
  if (row > array2d.GetLength(0) || column > array2d.GetLength(1))
  {
    Console.WriteLine($"Элемента на позиции {row},{column} не существует");
    return;
  }
  else
  {
    Console.WriteLine($"Элемент на позиции {row},{column} => {array2d[row - 1, column - 1]}");
    return;
  }
}

int m = NumberOfRows();
int n = NumberOfColumns();
int min = ReceiveMinMax("минимума");
int max = ReceiveMinMax("максимума");

int[,] random2dArray = Generate2DArray(m, n, min, max);
PrintArray2D(random2dArray);

int rowsPosition = RowsPosition();
int columnsPosition = ColumnsPosition();

SearchElement(random2dArray, rowsPosition, columnsPosition);


