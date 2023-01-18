// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.

//int [] myarray;
//myarray =new int [8];
//myarray[1] = 3;


/*int[] array = new int[8];
Random myRandom = new Random();

Console.WriteLine("Вывод с помощью for");
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);
    Console.Write(" {0} ", array[i] );
}*/

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
//int[] newArray(string message)

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