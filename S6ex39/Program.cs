/*Задача 39: Напишите программу, которая перевернёт одномерный массив
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]*/

Console.Clear();
Console.WriteLine($"_______Решение с созданием второго массива_____");
Console.WriteLine();

int[] array = GetNewArray(10, 1, 10);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
int[] newArray = reversArray(array);
Console.WriteLine($"[ {String.Join(", ", newArray)} ]");

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

int[] reversArray(int[] inArray)
{
    int[] res = new int[inArray.Length];

    for (int i = 0; i < inArray.Length; i++)
    {
        res[i] = inArray[inArray.Length - 1 - i];
    }
    return res;
}


Console.WriteLine();
Console.WriteLine($"_______Решение без создания второго массива, перезаписывается первый_____");
Console.WriteLine();

int[] array2 = GetNewArray2(10, 1, 10);
Console.WriteLine($"[ {String.Join(", ", array2)} ]");
ReversArray(array2);
Console.WriteLine($"[ {String.Join(", ", array2)} ]");

int[] GetNewArray2(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
} 

void ReversArray(int[] inArray)
{
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        int k = inArray[i];
        inArray[i] = inArray[inArray.Length - 1 - i];
        inArray[inArray.Length - 1 - i] = k;
    }
}