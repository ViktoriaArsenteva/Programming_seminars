// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateRndTwoDimensionalArray()
{
    var rnd = new Random();
    int lines = rnd.Next(1, 10);
    int columns = rnd.Next(1, 10);
    int[,] TwoDimensionalArray = new int[lines, columns];
    for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
        {
            TwoDimensionalArray[i, j] = rnd.Next(1, 10);

        }
    }
    return TwoDimensionalArray;
}

void PrintTwoDimensionalArray(int[,] TwoDimensionalArray)
{
    for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
        {
            Console.Write(TwoDimensionalArray[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}
double[] AverageOfColumns(int[,] Matrix)
{
    double[] Array = new double[Matrix.GetLength(1)];
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            sum += Matrix[i, j];
        }
        Array[j] = Math.Round(((double)sum / Matrix.GetLength(0)), 1);
    }
    return Array;
}
void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i < Array.Length - 1) Console.Write(Array[i] + "; ");
        else Console.Write(Array[i]);
    }
}
int[,] RndTwoDimensionalArray = CreateRndTwoDimensionalArray();
double[] Average = AverageOfColumns(RndTwoDimensionalArray);
PrintTwoDimensionalArray(RndTwoDimensionalArray);
Console.Write("Значения среднего арифметического каждого столбца: ");
PrintArray(Average);