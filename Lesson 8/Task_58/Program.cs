// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateRndTwoDimensionalArray(int lines, int columns)
{
    var rnd = new Random();
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
int[,] ProductOfMatrix(int[,] Array1, int[,] Array2)
{
    for (int i = 0; i < Array1.GetLength(0); i++)
    {
        for (int j = 0; j < Array1.GetLength(1); j++)
        {
            Array1[i,j] *= Array2[i,j];
        }
    }
    return Array1;
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
Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] firstArray = CreateRndTwoDimensionalArray(lines,columns);
int [,] secondArray = CreateRndTwoDimensionalArray(lines,columns);
PrintTwoDimensionalArray(firstArray);
Console.WriteLine();
PrintTwoDimensionalArray(secondArray);
int [,] resultArray = ProductOfMatrix(firstArray,secondArray);
Console.WriteLine();
PrintTwoDimensionalArray(resultArray);
