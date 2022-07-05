// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int i = 0;
    int[] Array = new int[size];
    var rnd = new Random();
    while (i < Array.Length)
    {
        Array[i] = rnd.Next(100, 1000);
        i++;
    }
    return Array;
}

int EvenNumbers(int[] Array)
{
    int amount = 0;
    int index = 0;
    while (index < Array.Length)
    {
        if (Array[index] % 2 == 0) amount++;
        index++;
    }
    return amount;
}

void PrintArray (int[] Array)
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
int[] array = CreateArray(arraySize);
int result = EvenNumbers(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество четных чисел в данном массиве = {result}");