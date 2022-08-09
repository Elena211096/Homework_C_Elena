// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.Write("Введите положительное число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int specialNumber = 2;


while(specialNumber<=Number)
{
    Console.WriteLine(specialNumber);
    specialNumber=specialNumber + 2;
}
