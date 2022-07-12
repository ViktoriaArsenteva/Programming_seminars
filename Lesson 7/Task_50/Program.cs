// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] CreateRndTwoDimensionalArray()
{
    var rnd = new Random();
    int lines = rnd.Next(1,20);
    int columns = rnd.Next(1,20);
    int[,] TwoDimensionalArray = new int[lines, columns];
    for (int i = 0; i < TwoDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < TwoDimensionalArray.GetLength(1); j++)
        {
            TwoDimensionalArray[i, j] = rnd.Next();
        
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
Console.WriteLine("Введите значения строки и столбца: ");
Console.Write("Строка = ");
int i = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбец = ");
int j = Convert.ToInt32(Console.ReadLine());
int[,] Array = CreateRndTwoDimensionalArray();
PrintTwoDimensionalArray(Array);
if (i < Array.GetLength(0))
{
    if (j < Array.GetLength(1))
    {
        Console.WriteLine($"Значение данного массива с позицией [{i},{j}] = {Array[i,j]}");
    }
    else Console.WriteLine("Значение отсутствует");
}
else Console.WriteLine("Значение отсутствует");
