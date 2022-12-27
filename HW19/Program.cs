/*Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.*/


int num;

while(true)
{
        Console.Write("Введите пятизначное число: ");

        try
        {
            num = Convert.ToInt32(Console.ReadLine()?? "");
            if(num < 99999 && num >9999 )
            break;
        }
        catch(Exception exc) 
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}"); 
        }
}
int firstNumberLeft = num / 10000;
int secondNumberLeft = num /1000 % 10;
int firstNumberRight = num % 10;
int secondNumberRight = num % 100 / 10;


if(firstNumberLeft == firstNumberRight && secondNumberLeft == secondNumberRight) 
{
        Console.WriteLine($"{firstNumberLeft}");
        Console.WriteLine($"{secondNumberLeft}");
        Console.WriteLine($"{firstNumberRight}");
        Console.WriteLine($"{secondNumberRight}");
        Console.WriteLine($"Число {num} -> палиндром");   
}
    else
    {
        Console.WriteLine($"{firstNumberLeft}");
        Console.WriteLine($"{secondNumberLeft}");
        Console.WriteLine($"{firstNumberRight}");
        Console.WriteLine($"{secondNumberRight}");
        Console.WriteLine($"Число {num} -> не палиндром");
    }