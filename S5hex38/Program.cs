/* Задача 38: Задайте массив вещественных чисел.
 Найдите разницу между максимальным и минимальным элементов массива.*/

Console.Clear();

int[] array = GetNewArray(10, 1, 10);
int diff = DiffBetweenNumbers(array);

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Разница между макс и мин: [ {diff} ]");

int[] GetNewArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
}

int DiffBetweenNumbers(int[] arr)
{
    int i = 0;
    int j = 0;
    int max;
    int min;
    int diff;
    max = arr[i];
    min = arr[j];
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    for (j = 0; j < arr.Length; j++)
    {
        if (arr[j] < min) min = arr[j];
    }
    diff = max - min;
    return diff;
}