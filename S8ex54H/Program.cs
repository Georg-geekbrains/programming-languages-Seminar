/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.Clear();
int[,] array = GetArray(5, 5, 0, 10);
PrintArray(array);
int[,] sortArray = SortBubble(array);
PrintArray(sortArray);

int[,] GetArray(int row, int col, int minEl, int maxEl)
{
    int[,] resArray = new int[row, col];
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            resArray[i, j] = new Random().Next(minEl, maxEl);
        }
    }
    return resArray;
}

void PrintArray(int[,] resArray)
{
    Console.WriteLine();
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            Console.Write($"{resArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] SortBubble(int[,] resSortArray)
{
    for (int i = 0; i < resSortArray.GetLength(0); i++)
    {
        for (int j = 0; j < resSortArray.GetLength(1); j++)
        {
            for (int m = 0; m < resSortArray.GetLength(0)-1; m ++)
            {
                if ( resSortArray[i,m] < resSortArray[i,m+1])
                {
                    int temp = resSortArray[i,m];
                    resSortArray[i,m] = resSortArray[i,m+1];
                    resSortArray[i,m + 1] = temp;
                }
            }
        }
    }
    return resSortArray;
}