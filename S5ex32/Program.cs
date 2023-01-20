//Задача 32. Напишите программу замены элементов массива. 
//Положительные элементы замените на соответсвующие отрицательные, и наоборот

 /* В данном случае исходный массив не сохраняется. Поэтому последовательность вывода. Выводим первый
массив, затем меняем и выводим измененный массив. Пояснения Семинар 5 time cod 1:05;00
Доп задание написать так чтобы сохранилось оба массива*/




Console.Clear();
int[] array = GetArray(10, -9, 10);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
GetNewArray(array);
Console.WriteLine($"[ {String.Join(", ", array)} ]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);
    }
    return result;
}

void GetNewArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = -arr[i];
    }

}