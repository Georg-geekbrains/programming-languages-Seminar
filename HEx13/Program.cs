int varA;

while (true)
{
    Console.Write("Введите целое число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine("Ошибка ввода!");
}

int x = 10;
int num3;
int number = varA;
int i = 0;

while(number > 0)
    {
    number = number / 10;
    i = i + 1;
    }

if(i<3) 
{
    Console.WriteLine($"{varA} --> Третьея цифра отсутствует");
}
else
{
    int A = Convert.ToInt32(Math.Pow(x,i-3));
    num3 = varA / A % 10;
    Console.WriteLine($"{varA} --> {num3}");
}
