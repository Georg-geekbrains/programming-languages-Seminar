/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

Console.Clear();

int[,] array = Spiral(5,5);
PrintArray(array);

int[,] Spiral(int x, int y)
{
    int[,] matrix = new int[x, y];
    int counter = 1;
    int startRow = 0;
    int endRow = matrix.GetLength(0) - 1;
    int startCol = 0;
    int endCol = matrix.GetLength(1) - 1;
    while (startRow <= endRow && startCol <= endCol)
    {
        for (int i = startCol; i <= endCol; i++)
        {
            matrix[startRow, i] = counter++;
        }
        startRow++;
        for (int i = startRow; i <= endRow; i++)
        {
            matrix[i, endCol] = counter++;
        }
        endCol--;
        for (int i = endCol; i >= startCol; i--)
        {
            matrix[endRow, i] = counter++;
        }
        endRow--;
        for (int i = endRow; i >= startRow; i--)
        {
            matrix[i, startCol] = counter++;
        }
        startCol++;
    }
    return matrix;
}

void PrintArray(int[,] resArray)
{
    Console.WriteLine();
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            
             Console.Write($"{string.Format("{0:d2}", resArray[i, j])} ");
        }
        Console.WriteLine();

        
    }
}



