/*Задача 23
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N. */

int num;

while(true)
{
        Console.Write("Введите число: ");

        try
        {
            num = Convert.ToInt32(Console.ReadLine()?? "");
            break;
        }
        catch(Exception exc) 
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
        }
}
Console.Write($"{num} -> ");
double x;
int count = 1;
while(count <= num)
{
    Console.Write($"{x = (Math.Pow(count,3))}, ");
    count = count + 1;
}