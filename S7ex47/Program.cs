//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");
double[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
double[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double rnd = new Random().Next(-10,11);
            result[i, j] = new Random().NextDouble() * 10 * rnd;
        }
    }
    return result;
}
void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{string.Format("{0:0.00}", inArray[i, j])} ");
        }
        Console.WriteLine();
    }
}

