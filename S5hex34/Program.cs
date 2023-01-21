/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.*/
Console.Clear();
int[] array = GetNewArray(10, 100, 1000);
int countPositive = CountPositiveNumbers(array);

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"Количество положительных чисел: {countPositive} ");

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

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    return count;
}