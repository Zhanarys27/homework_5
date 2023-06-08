// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();


void PrintArray(int[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"{Arr[i]} ");
    }
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}

void  ChetArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0)
        {
            count++;
        }
    }
    if(count>0) System.Console.WriteLine($"количество четных чисел в массиве: {count}");
    else System.Console.WriteLine("количество четных чисел массиве равно нулю");
}
int[] Array = new int[4];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
ChetArray(Array);