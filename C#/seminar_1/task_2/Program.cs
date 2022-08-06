// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.Write("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

if (numA == numB);
else if (numA > numB) Console.WriteLine($"Число {numA} является бóльшим. \nЧисло {numB} является меньшим.");
     else Console.WriteLine($"Число {numB} является бóльшим. \nЧисло {numA} является меньшим.");
