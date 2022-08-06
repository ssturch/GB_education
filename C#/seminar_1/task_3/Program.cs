// Задача 3: Напишите программу, которая будет выдавать названия дня недели по заданному номеру.
//
//3 -> среда
//5 -> пятница

//Данное решение очень уж напоминает индусский код, но раз уж без массивов, то без массивов :)

Console.Write("Введите порядковый номер дня недели: ");
int dayWeek = int.Parse(Console.ReadLine());

Console.Write("Ответ: ");

switch(dayWeek)
{
    case 1:
     Console.WriteLine("Понедельник");
     break;

    case 2:
     Console.WriteLine("Вторник");
     break;

    case 3:
     Console.WriteLine("Среда");
     break;

    case 4:
     Console.WriteLine("Четверг");
     break;
    
    case 5:
     Console.WriteLine("Пятница");
     break;

    case 6:
     Console.WriteLine("Суббота");
     break;

    case 7:
     Console.WriteLine("Воскресение");
     break;

    case < 1 or > 7:
     Console.WriteLine("Такого дня недели не существует.");
     break;

}
