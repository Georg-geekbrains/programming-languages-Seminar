/*напишите программу, которая выводит третью цифру
заданного числа или сообщает, что третьей цифры нет.*/


int num;

while(true)
{
        Console.Write("Введите целое число");

        try
        {
            num = Convert.ToInt32(Console.ReadLine()?? "");
            break;
        }
        catch(Exception exc) //исключение присваевается переменной exc
        {
            Console.WriteLine($"Ошибка ввода! {exc.Message}"); // выводим переменную
            //exc со свойством Massage в котором записано сообщение от Exception
        }
}


int num_abc = Math.Abs(num);

if (num_abc < 100)
{
    Console.WriteLine("Третьей цифры нет");
    return;
}

int thirdNumberRight = num_abc / 100 % 10;

while(num_abc > 999)
{
    num_abc = num_abc/10;
}
int thirdNumberLeft = num_abc % 10;

Console.WriteLine($"Третья цифра числа {num} справа -> {thirdNumberRight}");
Console.WriteLine($"Третья цифра числа {num} слева -> {thirdNumberLeft}");