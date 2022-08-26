// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Task №47");
double[,] CreatRandomDoubleMatrix(int rowCount, int columnCount)
{
    Random random = new Random();
    double[,] array = new double[rowCount, columnCount];
    for (int row = 0; row < rowCount; row++)
    {
        for (int column = 0; column < columnCount; column++)
        {
            array[row, column] = Math.Round(20 * random.NextDouble() - 10, 1);
        }
    }
    return array;
}

void PrintRandomDoubleMatrix(double[,] arr)
{

    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

double[,] matrix = CreatRandomDoubleMatrix(7, 9);
PrintRandomDoubleMatrix(matrix);


//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.WriteLine();
Console.WriteLine("Task №50");
int[,] CreatMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] array = new int[rowCount, columnCount];
    for (int row = 0; row < rowCount; ++row)
    {
        for (int column = 0; column < columnCount; ++column)
        {
            array[row, column] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintMatrix(int[,] arr)
{
    for (int row = 0; row < arr.GetLength(0); ++row)
    {
        for (int column = 0; column < arr.GetLength(1); ++column)
        {
            Console.Write($"{arr[row, column]}\t");
        }
        Console.WriteLine();
    }
}

void PrintPositionMatrix(int[,] arr, int n, int m)
{
    if (n < arr.GetLength(0) && m < arr.GetLength(1))
    {
        Console.WriteLine($"{arr[n, m]}");
    }
    else
    {
        Console.WriteLine($"{n}, {m} такого числа в массиве нет!");
    }


}

int[,] mat = CreatMatrix(3, 4, 1, 10);
PrintMatrix(mat);
PrintPositionMatrix(mat, 2, 6);


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Берем матрицу из задачи 50
Console.WriteLine();
Console.WriteLine("Task №52");

void PrintAverageMatrix(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{Math.Round(sum / arr.GetLength(0), 1)} ");
    }
}


PrintMatrix(mat);
PrintAverageMatrix(mat);