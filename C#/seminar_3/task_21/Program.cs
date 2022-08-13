//Задача 21
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки А: ");
Console.Write("x = ");
int xA = int.Parse(Console.ReadLine());
Console.Write("y = ");
int yA = int.Parse(Console.ReadLine());
Console.Write("z = ");
int zA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки B: ");
Console.Write("x = ");
int xB = int.Parse(Console.ReadLine());
Console.Write("y = ");
int yB = int.Parse(Console.ReadLine());
Console.Write("z = ");
int zB = int.Parse(Console.ReadLine());

double pow_xAB = Math.Pow(xB - xA, 2); // 2-я степень координаты вектора AB по х
double pow_yAB = Math.Pow(yB - yA, 2); // 2-я степень координаты вектора AB по y
double pow_zAB = Math.Pow(zB - zA, 2); // 2-я степень координаты вектора AB по z

double lengthAB = Math.Round(Math.Sqrt(pow_xAB + pow_yAB + pow_zAB), 2); //как инженер я не могу просто отсекать цифры, уж простите))

Console.Write($"Длина между точками A и B: {lengthAB}");

