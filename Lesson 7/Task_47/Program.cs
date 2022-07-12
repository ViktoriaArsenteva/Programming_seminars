// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите два числа(m,n), где m - количество строк, а n - количество столбцов");
Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] CreateTwoDimensionalArray(int lines, int columns)
{
    double[,] TwoDimensionalArray = new double[lines, columns];
    var rnd = new Random();
    for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
        {
            TwoDimensionalArray[i, j] = Math.Round(rnd.NextDouble() * 100, 2);
        }
    }
    return TwoDimensionalArray;
}
void PrintTwoDimensionalArray(double[,] TwoDimensionalArray)
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
double[,] Array = CreateTwoDimensionalArray(m, n);
PrintTwoDimensionalArray(Array);