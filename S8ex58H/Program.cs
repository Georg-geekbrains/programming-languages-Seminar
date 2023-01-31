/*Задача 58: Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.Clear();

int[,] array1 = GetArray(2, 2, 0, 10);
int[,] array2 = GetArray(2, 2, 0, 10);
int[,] array3 = ResMatrix(array1, array2);
PrintArray(array1);
PrintArray(array2);
PrintArray(array3);



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

int[,] ResMatrix(int[,] array1, int[,] array2)
{
    int[,] array3 = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(1); k++)
            {
                array3[i, j] = array3[i, j] + array1[i, k] * array2[k, j];
            }
        }
    }
   return array3; 
}