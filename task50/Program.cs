// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает
//значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
        }
    }
    return matrix;
}

void ReturnNumb(int[,] matrix, int i, int j)
{
    int rowCount = matrix.GetLength(0);
    int colCount = matrix.GetLength(1);
    if (i >= rowCount || j >= colCount)
    {
        Console.WriteLine("Такого элемента в массиве нет!");
    }
    else
    {
        Console.WriteLine(matrix[i,j]);
    }
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}


System.Console.Write("Введите номер строки: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(value: Console.ReadLine());
int[,] matrix = FillMatrixWithRandom(5, 5);
PrintMatrix(matrix);
Console.WriteLine();
ReturnNumb(matrix, row, column);