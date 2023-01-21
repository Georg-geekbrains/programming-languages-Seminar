/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.*/
Console.Clear();

int[] array = GetNewArray(10, 1, 10);
int sumNegativePosition = NegativePosition(array);

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"{sumNegativePosition}");

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
int NegativePosition(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1) sum = sum + arr[i];
    }
    return sum;
}
