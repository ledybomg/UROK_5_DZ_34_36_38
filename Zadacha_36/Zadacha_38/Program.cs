// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[] arr = { 3, 7, 22, 2, 78 };

double min = arr[0];
double max = arr[0];

for (int i = 1; i < arr.Length; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double diff = max - min;

Console.WriteLine(diff);