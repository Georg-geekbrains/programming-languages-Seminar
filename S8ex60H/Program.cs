/*Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.*/


Console.Clear();
int[,,] array3d = GetArray(3,3,3);
PrintArray(array3d);

int[,,] GetArray(int z, int y, int x)
{
int[,,] array = new int[z,y,x];
Random random = new Random();
for (int i = 0; i < array.GetLength(0); i++)// z
{
    for (int j = 0; j < array.GetLength(1); j++) // y
    {
        for (int k = 0; k < array.GetLength(2); k++) // x
        {
            array[i, j, k] = random.Next(0,10000);
        }
    }
}
return array;
}

void PrintArray(int[,,] array)
{
for (int i = 0; i < array.GetLength(0); i++)// z
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++) // y
    {
        for (int k = 0; k < array.GetLength(2); k++) // x
        {
            Console.Write($"({i}{j}{k})  {array[i,j,k]}");
            Console.WriteLine();
        }
    }
}
}