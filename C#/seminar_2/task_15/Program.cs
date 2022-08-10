//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру, обозначающую день недели: ");
int dgtDay = int.Parse(Console.ReadLine());
    if ((dgtDay < 1) | (dgtDay > 7))
    {
    Console.WriteLine("Такого дня недели нет");
    }
    else
    {
        Console.Write("Выходной ли этот день? Ответ: ");
        if ((dgtDay <= 5) && (dgtDay >=1))
        {
        Console.Write("Нет.");
        }
        else 
        {
        Console.Write("Да.");
        }
    }
 

