// Задача4. Напишите программу, которая на вход принимает три числа и выдает максимальное из этих чисел.
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22
Console.WriteLine("Введите три целых числа:");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine($"Максимальное число: {max}");