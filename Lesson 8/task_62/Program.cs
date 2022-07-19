// Задача 62. Заполните спирально массив 4 на 4.

int[,] ArrayFilling(int lines, int columns)
{
    int[,] Matrix = new int[lines, columns];
    int i = 0;
    int j = 0;
    int checkI = Matrix.GetLength(0);
    int checkJ = Matrix.GetLength(1);
    int number = 1;
    while (number < Matrix.GetLength(0) * Matrix.GetLength(1))
    {
        while (j < checkJ - 1)
        {
            Matrix[i, j] = number;
            j++;
            number++;
        }
        while (i < checkI - 1)
        {
            Matrix[i, j] = number;
            i++;
            number++;
        }
        while (j > Matrix.GetLength(1) - checkJ)
        {
            Matrix[i, j] = number;
            j--;
            number++;

        }
        checkI--;
        while (i > Matrix.GetLength(0) - checkI)
        {
            Matrix[i, j] = number;
            i--;
            number++;
        }
        checkJ--;
    }
    Matrix[i,j] = number;
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

Console.Write("Введите количество строк: ");
int lines = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] Array = ArrayFilling(lines, columns);
PrintTwoDimensionalArray(Array);