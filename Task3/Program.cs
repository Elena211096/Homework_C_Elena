// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным

Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0) 
{
    Console.Write("Введенное число является четным");
}
else
{
    Console.Write("Введенное число является нечетным");
}
