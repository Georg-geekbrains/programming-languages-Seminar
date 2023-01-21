/*Задача 37 Найтите произведение пар чисел в одномерном массиве.
Парой считается первый и последний элемент, второй и предпоследний и т.д. Результат запишите
в новом массиве*/

int[] array = GetNewArray(8, 0, 10);
int[] newArray = NewArray(array);

Console.WriteLine($"[ {String.Join(", ", array)} ]");
Console.WriteLine($"[ {String.Join(", ", newArray)} ]");



int[] GetNewArray(int size, int minValue, int maxValue)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(minValue, maxValue);
    }
    return arr;
}

int[] NewArray(int[] arr)
{
    int size = 0;

    if(arr.Length%2==1) size = arr.Length/2+1;
    else size = arr.Length/2;

    int[] res = new int[size];

    for(int i = 0; i < size; i++)
    {
    if((arr.Length%2==1)&&(i==size-1)) res[i] = arr[i];
    else res[i] = arr[i] * arr[arr.Length-i-1];
    }
    
return res;

}
