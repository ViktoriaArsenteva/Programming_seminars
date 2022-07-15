// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] CreateRndTwoDimensionalArray()
{
    var rnd = new Random();
    int lines = rnd.Next(3, 10);
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
int[,] ArrayDescending(int[,] Matrix)
{
    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            int max = Matrix[i, j];
            for (int index = 0; index < j; index++)
            {
                if (Matrix[i, j] > Matrix[i, index])
                {
                    if (max > Matrix[i, index])
                    {
                        max = Matrix[i, index];
                        Matrix[i, index] = Matrix[i, j];
                        Matrix[i, j] = max;
                    }
                }
            }
        }
    }
    return Matrix;
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
int[,] Array = CreateRndTwoDimensionalArray();
PrintTwoDimensionalArray(Array);
int[,] NewArray = ArrayDescending(Array);
Console.WriteLine();
PrintTwoDimensionalArray(NewArray);