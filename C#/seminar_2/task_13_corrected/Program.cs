//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Строки и циклы в решении использовать нельзя! Цифры подсчитываются справа - налево.

//645 -> 6
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
    if (num > 99)
    {
    num = (num % 1000) / 100;
    Console.Write($"Результат: {num}");
    }
else 
    {
    Console.Write("Третьей цифры нет.");
    }
 