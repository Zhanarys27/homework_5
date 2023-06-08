// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

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
        array[i] = new Random().Next(-100,100);
    }
}

void  ChetArray(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if(i%2 != 0)
        {
            count+=array[i];
        }

    }
    System.Console.WriteLine($"сумма: {count}");
    
}
int[] Array = new int[4];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
ChetArray(Array);