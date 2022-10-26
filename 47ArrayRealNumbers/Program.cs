// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] RandomArray(int m, int n, int minValue, int maxValue)
{
    double[,] randomArray = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            randomArray[i, j] = random.Next(minValue, maxValue) + random.NextDouble();
        }
    }
    return randomArray;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]:f1}\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Массив вещественных чисел: ");

double[,] array = RandomArray(3, 4, -10, 10);
PrintArray(array);