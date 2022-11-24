//     36. Задайте одномерный  массив.заполненный случайными числами.
//     Найдите сумму элументов, стоящих на нечетных позициях.
//     [3, 7, 23, 12] -> 19
//     [-4, -6, 89, 6] -> 0

int[] CreateArrayRdnInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] =  new Random().Next(0 ,100);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+ ",");
    }
    Console.Write("]");
}

int[] GetSumPositiveElem(int[] array)
{
    int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > 0 ) sumPositive += array[i];
    }
    return new int[]{sumPositive};
}

int[] arr = CreateArrayRdnInt(10, -10, 10);
PrintArray(arr);
int[] getSumPositiveElem = GetSumPositiveElem(arr);
Console.WriteLine($"Сумма положительных элементов = {getSumPositiveElem[0]}");

