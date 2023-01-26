//Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
int rows = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода");

double[,] array = GetArray(rows, columns, 0, 10);

PrintArray(array);


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
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