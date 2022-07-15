// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//массив размером 2 x 2 x 2

int[,,] CreateRndTreeDimensionalArray(int a, int b, int c)
{
    var rnd = new Random();
    int[,,] TreeDimensionalArray = new int[a, b, c];
    for (int i = 0; i < TreeDimensionalArray.GetLength(0); i++)
    {
        for (int j = 0; j < TreeDimensionalArray.GetLength(1); j++)
        {
            for (int k = 0; k < TreeDimensionalArray.GetLength(2); k++)
            {
                TreeDimensionalArray[i, j, k] = rnd.Next(10, 100);
            }
        }
    }
    return TreeDimensionalArray;
}
void PrintTreeDimensionalArray(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(2); i++)
    {
        for (int j = 0; j < Array.GetLength(0); j++)
        {
            for (int k = 0; k < Array.GetLength(1); k++)
            {
                Console.Write($"{Array[j, k, i]}({j},{k},{i}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] Array = CreateRndTreeDimensionalArray(2, 2, 2);
PrintTreeDimensionalArray(Array);