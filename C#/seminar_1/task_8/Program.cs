//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

int count = 1;

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

while (count <= num)
{
    if (count % 2 == 0) Console.Write($"{count} ");
    count ++;
}
