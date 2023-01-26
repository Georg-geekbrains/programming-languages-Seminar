/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();
Console.Write("Введите номер строки; ", "Ошибка ввода");
int userRow = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите номер столбца; ", "Ошибка ввода");
int userCol = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(7, 8, 1, 9);
bool resCheck = Check(userRow, userCol, array);

PrintArray(array);
Console.WriteLine($"  {(resCheck ? array[userRow - 1, userCol - 1] : "Нет числа на данной позйции")}");



int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] res = new int[row, col];
    var rnd = new Random();
    for (int i = 0; i < res.GetLength(0); i++)
    {
        for (int j = 0; j < res.GetLength(1); j++)
        {
            res[i, j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return res;
}

bool Check(int userRow, int userCol, int[,] array)
{
    if (userRow < array.GetLength(0) && userCol < array.GetLength(1))
    {
        return true;
    }
    return false;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
