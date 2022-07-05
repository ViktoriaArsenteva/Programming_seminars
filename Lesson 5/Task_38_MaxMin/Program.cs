// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] CreateArray(int size)
{
    int i = 0;
    double[] Array = new double[size];
    var rnd = new Random();
    while (i < Array.Length)
    {
        Array[i] = Math.Round(rnd.NextDouble() * 20, 2);
        i++;
    }
    return Array;
}

double[] MaxAndMin(double[] Array)
{
    int index = 1;
    double max = Array[0];
    double min = Array[0];
    while (index < Array.Length)
    {
        if (Array[index] > max) max = Array[index];
        else if (Array[index] < min) min = Array[index];
        index++;
    }
    double[] ArrayMaxMin = new double[] { max, min };
    return ArrayMaxMin;
}

void PrintArray(double[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < Array.Length - 1) Console.Write(Array[i] + ",");
        else Console.Write(Array[i] + "]");
    }
}
Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArray(arraySize);
double[] arrayMaxMin = MaxAndMin(array);
double result = Math.Round(arrayMaxMin[0] - arrayMaxMin[1],2);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разница между максимальным({arrayMaxMin[0]}) и минимальным({arrayMaxMin[1]}) элементами данного массива = {result}");
