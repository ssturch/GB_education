//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if ((num > 99) && (num < 1000))
    {
    num = (num / 10) % 10;
    Console.Write($"Второй цифрой введенного числа является {num} ");
    } 
else 
    {
    Console.Write($"Введенное число не является трехзначным");
    }
