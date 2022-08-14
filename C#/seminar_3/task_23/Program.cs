//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write("Результат: ");

int i = 1;
do 
{
    double result = Math.Pow(i, 3);
    Console.Write($"{result}");
    if (i < num) Console.Write(", "); // Для того, чтобы не ставилась запятая после последнего числа
    i++;
}
while (i < num + 1);

//for (int j = 1; i < num + 1; j++) //цикл for так же рабочий, но хотелось посмотреть конструкцию do/while
//{
//   double result = Math.Pow(j, 3);
//    Console.Write($"{result}, ");
//} 