// 34. Задайте массив заполненый случайными положительными трехзн числами.
//     Напишите программу,которя покажет количество четных чисел в массиве.

int[] CreateArrayRdnInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] =  new Random().Next(100, 999);
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


int NumberArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0);
       count++;
    }
    return count;
}


int[] arr = CreateArrayRdnInt(10, 100, 999);
PrintArray(arr);
int resut = NumberArray(arr);
Console.Write($"Количество четных чисел в массиве = {result}" );



