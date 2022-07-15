// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateRndTwoDimensionalArray()
{
    var rnd = new Random();
    int lines = rnd.Next(3, 15);
    int columns = rnd.Next(3, 10);
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
int MinSumInLines(int[,] Array)
{
    int minSumm = 1000;
    int minSummIndex = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum += Array[i,j];
        }
        if (sum < minSumm)
        {
            minSumm = sum;
            minSummIndex = i;
        }
    }
    return minSummIndex;
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
int [,] Array = CreateRndTwoDimensionalArray();
PrintTwoDimensionalArray(Array);
int result = MinSumInLines(Array);
Console.WriteLine($"Наименьшая сумма элементов в {result} строке");
