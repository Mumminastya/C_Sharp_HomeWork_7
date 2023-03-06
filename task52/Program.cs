// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] FillMatrixWithRandom(int row, int column)
{
    int[,] matrix = new int[row, column];
    Random rnd = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(0, 10);
            System.Console.Write(matrix[i,j] + " ");
        }
        System.Console.WriteLine();
    }
    return matrix;
}

double[] AverageColumn(int[,] matrix)
{     
    int colCount = matrix.GetLength(0);
    int rowCount = matrix.GetLength(1);
    double[] averagemassive = new double[colCount];
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        int summ = 0;
        for (int i = 0; i < rowCount; i++)
        {
            summ = summ + matrix[i,j];
        }
        averagemassive[j] = Math.Round(1.0 * summ/rowCount, 1);
    }
    return averagemassive;  
}

System.Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrixWithRandom(row, column);
double[] averagemassive = AverageColumn(matrix);
System.Console.WriteLine();
Console.Write("Среднее арифметическое каждого столбца: ");
Console.Write(string.Join("; ", averagemassive));