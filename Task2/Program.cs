// Задача2. Напишите программу, которая на входд принимает два числа и выдает максимальное.
// a = 5 b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine($"Максимальное число {a}");
}
else
{
    Console.WriteLine($"Максимальное число {b}");
}
