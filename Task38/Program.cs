// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]:F2}; ");
        else Console.Write($"{arr[i]:F2}");
    }
    Console.Write("]");
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i]) max = arr[i];
    }
    return Math.Round(max, 2);
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i]) min = arr[i];
    }
    return Math.Round(min, 2);
}

double[] array = CreateArrayRndDouble(5, 10, 20);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"min = {FindMin(array)}");
Console.WriteLine($"max = {FindMax(array)}");
double result = FindMax(array) - FindMin(array);
Console.WriteLine();
Console.Write($"Разница между максимальным и минимальным = {Math.Round(result, 2)}");