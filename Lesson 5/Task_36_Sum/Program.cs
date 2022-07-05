// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateArray(int size)
{
    int i = 0;
    int[] Array = new int[size];
    var rnd = new Random();
    while (i < Array.Length)
    {
        Array[i] = rnd.Next();
        i++;
    }
    return Array;
}

int SumOfOddNumbers(int[] Array)
{
    int index = 0;
    int sum = 0;
    while (index < Array.Length)
    {
        if (index % 2 != 0) sum += Array[index];
        index++;
    }
    return sum;
}

void PrintArray(int[] Array)
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
int[] ArrayRnd = CreateArray(arraySize);
int result = SumOfOddNumbers(ArrayRnd);
PrintArray(ArrayRnd);
Console.WriteLine();
Console.WriteLine($"Сумма чисел, стоящих на нечетных позициях = {result}");