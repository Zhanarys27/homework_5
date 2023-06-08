// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. Найдите максимальный элемент и его индекс,
//  минимальный элемент и его индекс, среднее арифметическое всех элементов.
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.

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
        array[i] = new Random().Next(0, 1000);
    }
}
void MinMaxArrayIndex(int[] array)
{
    int length = array.Length;
    int IndexMax = 0;
    int IndexMin = 0;
    int count1 = 0;
    int count2 = array[0];
    for (int i = 0; i < length; i++)
    {
        if (count1 < array[i])
        {
            IndexMax = i;
            count1 = array[i];
        }
        else if (count2 > array[i])
        {
            IndexMin = i;
            count2 = array[i];
        }
    }
    count1 = 0;
    count2 = 0;
    foreach (var item in array)
    {
        count1 += item;
        count2++;
    }
    int SredArif = count1 / count2;
    object[] output = new object[6];
    output[0] = "Индекс максимального элемента: ";
    output[1] = IndexMax;
    output[2] = "Индекс минимального элемента: ";
    output[3] = IndexMin;
    output[4] = "Среднее арифметическое всех чисел: ";
    output[5] = SredArif;
    foreach (var item in output)
    {
        System.Console.WriteLine(item);
    }

}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length-1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j]<array[minPosition])
            {
                minPosition=j;

            }
        }
        
        int temporary = array[i];
        array[i]=array[minPosition];
        array[minPosition] = temporary;
    }
}
void Mediana(int[] array)
{
    int length = array.Length;
    if(length%2!=0)
    {
        System.Console.WriteLine($"Медианное значение равна: {array[length/2]}");
    }
    else
    {
        int median = 0;
        median = (array[length/2]+array[length/2-1])/2;
        System.Console.WriteLine($"Медианное значение равна: {median}");
    }
}

int[] Array = new int[4];
FillArray(Array);
PrintArray(Array);
System.Console.WriteLine();
MinMaxArrayIndex(Array);

SelectionSort(Array);
Mediana(Array);
