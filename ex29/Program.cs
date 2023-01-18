// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

Console.Clear();
//int num = GetNumberFromUser("Введите число: ", "Ошибка ввода");
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

//формирование массива
 
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        int n = GetNumberFromUser("Введите число: ", "Ошибка ввода");
        array[i] = n;
    }
 
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
