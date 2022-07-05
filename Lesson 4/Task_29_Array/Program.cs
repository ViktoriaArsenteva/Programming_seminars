// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] Array = new int[8];
int index = 0;
var rnd = new Random();
while (index < Array.Length)
{
    Array[index] = rnd.Next(0, 1000);
    index++;
}
for (int i = 0; i < Array.Length; i++)
{
    if (i == 0) Console.Write("[");
    if (i < Array.Length - 1) Console.Write(Array[i] + ",");
    else Console.Write(Array[i] + "]");
}