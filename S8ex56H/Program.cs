/*Задача 56: Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.Clear();

int[,] array = GetArray(3, 3, 0, 10);
int[] newArray = FindSumRow(array);
int numMinRow = MinRowNum(newArray);

PrintArray(array);


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


int[] FindSumRow(int[,] resSum)
{
    
    int sumRow = 0;
    int size = resSum.GetLength(0);
    int[] newArray = new int[size];
    int k = 0;
    for (int i = 0; i < resSum.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < resSum.GetLength(1); j++)
        {
            sumRow = sumRow + resSum[i, j];
        }
        if (k < size) newArray[k] = sumRow;
        k++;
    }
    return newArray;
}


int MinRowNum(int[] minNum)
{
    int minValue = minNum[0];
    int k = 0;
    for (int i = 0; i < minNum.Length; i++)
    {
        if (minNum[i] <= minValue)
        {
        minValue = minNum[i];
        k = i+1;
        }
        
    }
    //Console.WriteLine($"{minValue}");
return k;
}


void PrintArray(int[,] resArray)
{
    for (int i = 0; i < resArray.GetLength(0); i++)
    {
        for (int j = 0; j < resArray.GetLength(1); j++)
        {
            Console.Write($"{resArray[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine($"[ {String.Join(", ", newArray)} ] ");
    Console.WriteLine();
    Console.WriteLine($"номер строки с наименьшей суммой: {numMinRow}");
    Console.WriteLine();
}

