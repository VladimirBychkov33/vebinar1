//Написать программу которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if(numberB * numberB == numberA)
{
    Console.WriteLine("Да, является");
}
else
{
    Console.Write("Нет, не является");
}



