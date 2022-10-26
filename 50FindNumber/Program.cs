// Задача 50. Напишите программу, которая на вход принимает число 
//и возвращает индексы элемента в двумерном массиве или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
int[,] RandomArray(int m, int n, int minValue, int maxValue)
{
    int[,] randomArray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        { randomArray[i, j] = new Random().Next(minValue, maxValue + 1); }
    }
    return randomArray;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Двумерный массив:");
int[,] array = RandomArray(3, 4, 1, 9);
PrintArray(array);

void FindNumberIndex(int[,] arrayNumbers, int find)
{
    int position = 0;
    for (int i = 0; i < arrayNumbers.GetLength(0); i++)
    {
        for (int j = 0; j < arrayNumbers.GetLength(1); j++)
        {
            if (arrayNumbers[i, j] == find)
            {
                position = arrayNumbers[i, j];
                Console.WriteLine($"число {position} стоит на строке {i} и столбце {j}");  
                return;              
            }            
        }          
    } 
    if (position != find) Console.WriteLine("такого числа нет");
    return;
}

Console.Write("Введите число от 1 до 9, которое будем искать в массиве: ");
int number = int.Parse(Console.ReadLine()!);
FindNumberIndex(array, number);