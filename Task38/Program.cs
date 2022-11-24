// 38. Задайте массив вещественных чисел . найдите разницу между мин и мах элементов массива.
//     [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (double i = 0; i < size; i++)
    {
        array[i] = rnd.Next(max - min) + min;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ",");
    }
    Console.Write("]");
}

double Differense(double[] array)
{
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }
    double result = max - min;
    return result;
}

double[] arr = CreateArrayRndDouble(6, 99, 999);
PrintArray(arr);
double result = Differense(arr);
Console.Write($"Разница между максимальным и минимальным элементов массива равна = {result}");
