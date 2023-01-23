/*Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
 значения b1, k1, b2 и k2 задаются пользователем.*/

Console.Clear();

double k1 = GetNumberFromUser("Введите число k1: ", "Ошибка ввода");
double b1 = GetNumberFromUser("Введите число b1: ", "Ошибка ввода");
double k2 = GetNumberFromUser("Введите число k2: ", "Ошибка ввода");
double b2 = GetNumberFromUser("Введите число b2: ", "Ошибка ввода");

double [] crossPoint = crossFunction(k1,b1,k2,b2);

PrintArray(crossPoint);

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
double[] crossFunction(double k1, double b1, double k2, double b2)
{

    double x = (-b2 + b1) / (-k1 + k2);
    double y = k2 * x + b2;
    double[] cross = new double[2] { x, y };
    return cross; 
}
void PrintArray(double [] crossPoint1)
{
    //Вывод массива
    Console.Write("(");
    for (int i = 0; i < crossPoint.Length; i++)
    {

        Console.Write($" {crossPoint[i]} ");

        if (i < crossPoint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write(")");
}




