/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

Console.Clear();
int row = GetNumberFromUser("Введите количество строк: ", "Ошибка ввода");
int col = GetNumberFromUser("Введите количество столбцов: ", "Ошибка ввода");
int[,] array = GetArray(row, col, 0, 10);
PrintArray(array);
Average(array);


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
int[,] GetArray(int row, int col, int minVol, int maxVol)
{
    int[,] getArray = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            getArray[i, j] = new Random().Next(minVol, maxVol);
        }
    }
    return getArray;
}
void Average(int[,] array)
{
    double sum = 0;
for (int j = 0; j < array.GetLength(1); j ++)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
       sum = (sum + array[i,j]) ;
    }
    double avg = sum / array.GetLength(0);

    Console.Write($" {avg};  ");
    sum = 0;
}
Console.WriteLine();
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++)
    {
        for (int j = 0; j < array.GetLength(1); j ++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}