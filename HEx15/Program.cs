int varA;

while(true)
{
Console.WriteLine("Введите число от 1 до 7");
if(int.TryParse(Console.ReadLine(),out varA))
if(varA < 8 && varA > 0)
break;
Console.WriteLine("Ошибка ввода!");

}
//Console.WriteLine($"A = {varA}");
if(varA == 6 | varA == 7) Console.WriteLine($"{varA} --> да");
else
    Console.WriteLine($"{varA} --> нет");