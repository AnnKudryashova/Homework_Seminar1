// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a, b;

Console.WriteLine("Введите первое число");

a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число");

b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Максимальное значение " + a);
} 

else
{
    Console.WriteLine("Максимальное значение " + b);
}