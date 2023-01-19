// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.



Console.Clear();
int[] array = GetUserArray(8);
PrintArray(array);

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
int[] GetUserArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        int n = GetNumberFromUser("Введите число: ", "Ошибка ввода");
        arr[i] = n;
    }
    return arr;
}
void PrintArray(int [] printArray)
{
    //Вывод массива

    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($" {array[i]} ");

        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


