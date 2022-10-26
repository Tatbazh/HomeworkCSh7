// Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
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
PrintArray(array);

void MeanSum(int[,] ArrayNumb)
{    
    //double[] arr = new double[ArrayNumb.GetLength(1)];
    double sumMean = 0;
    for (int column = 0; column < ArrayNumb.GetLength(1); column++)
    {
        double sum = 0;
        for (int row = 0; row < ArrayNumb.GetLength(0); row++)
        { 
            sum = sum + ArrayNumb[row, column];                      
        }
        sumMean = sum / ArrayNumb.GetLength(0);
        
        Console.Write($"{sumMean:f1}; ");            
    } 
    // for (int i = 0; i < arr.Length; i++)
    // { arr[i] = sumMean;}   
    // return arr;
}
//Console.Write($"Среднеарифметические столбцов: {MeanSum(array)}; ");
Console.Write("Значения среднеарифметических столбцов: ");
MeanSum(array);