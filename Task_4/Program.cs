// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c;

Console.WriteLine("Введите первое число");

a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

b = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число");

c = int.Parse(Console.ReadLine());

if (a > b)

if (a > c)
{
    Console.WriteLine("Максимальное значение " + a);
}

if (b > a)

if (b > c)
{
    Console.WriteLine("Максимальное значение " + b);
}

if (c > a)

if (c > b)
{
    Console.WriteLine("Максимальное значение " + c);
}