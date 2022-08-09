// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

int maximum;
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int Number3 = Convert.ToInt32(Console.ReadLine());


if(Number1>Number2) 
{
    maximum = Number1;
}
else
{
    maximum=Number2;
}
if(Number3>maximum) 
{
    maximum=Number3;
}

Console.Write("Максимальное число " + maximum);