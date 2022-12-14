//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Write("Введите число: ");
int num = Math.Abs(int.Parse(Console.ReadLine())); // Math.Abs добавлен на случай, если пользователь введет отрицательное число
    if (num > 99)
    {
    //Поиск количества чисел с помощью логарифма и результата его округления до целого в большую сторону
    double countDgt = Math.Ceiling(Math.Log10(Convert.ToDouble(num)));
    //Поиск делителя, чтобы получить 3-х значное число после деления num
    int dividerCalc = Convert.ToInt32(Math.Pow(10,countDgt - 3));
    //Вычисление результата, используя полученный делитель и вычисления остатка от деления
    int result = (num / dividerCalc) % 10; 
    Console.Write($"Третьей цифрой введенного числа является {result}");
    }
else 
    {
    Console.Write("Третьей цифры нет.");
    }
 
