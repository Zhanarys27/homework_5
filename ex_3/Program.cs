
// Задача 38: Задайте массив вещественных случайных чисел. Найдите разницу между максимальным и минимальным элементов массива.// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2
Console.Clear();


void PrintArray(double[] Arr)
{
    for (int i = 0; i < Arr.Length; i++)
    {
        System.Console.Write($"{Arr[i]} ");
    }
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble()*10;
    }
}

void ChetArray(double[] array)
{
    double max = 0;
    double min = array[0];
    foreach (var item in array)
    {
        if (max < item)
        {
            max = item;
        }
        else if (min > item)
        {
            min = item;
        }

    }
    System.Console.WriteLine($"Разница между максимальным и минимальным элементом равна {max - min}");
}


double[] Array = new double[4];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
ChetArray(Array);