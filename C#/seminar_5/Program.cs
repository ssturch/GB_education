//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 4-х заданий 5-го семинара.");
Console.WriteLine("'1' - решение задачи 34");
Console.WriteLine("'2' - решение задачи 36");
Console.WriteLine("'3' - решение задачи 38");
Console.WriteLine("'4' - решение задачи *");
Console.Write("Введите символ (от 1 до 4), соответствующий задаче: ");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    task34func ();
    break;

    case "2":
    task36func ();
    break;

    case "3":
    task38func ();
    break;

    case "4":
    taskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №34
void task34func ()
{   Console.WriteLine("******************************************************");
    Console.WriteLine("Программа показывает количество чётных чисел в массиве");
    Console.WriteLine("******************************************************");
    Console.Write("Введите размер массива: ");
    int qty = int.Parse(Console.ReadLine());
    int initCountEven;
    string output = String.Join(", " ,funcCountEvenFromArr(qty, out initCountEven));
    Console.WriteLine($"В массиве: {output}");
    Console.WriteLine($"Количество четных чисел = {initCountEven}");

}

int[] funcCountEvenFromArr(int qty, out int countEven)
{
    int index = 0;
    int[] array = new int[qty];
    countEven = 0;
    while (index < qty)
    {
        array[index] = new Random().Next(100,999);
        if (array[index] % 2 == 0) countEven ++;
        index++;
    }
    return array;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №36
void task36func ()
{   
    Console.WriteLine("***********************************************************************");
    Console.WriteLine("Программа показывает сумму чисел в массиве стоящих на нечетных позициях");
    Console.WriteLine("***********************************************************************");
    Console.Write("Введите размер массива: ");
    int qty = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN число для генерации массива: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX число для генерации массива: ");
    int maxInt = int.Parse(Console.ReadLine());
    int initSummOddIndexDig;
    string output = String.Join(", ",funcSummOddIndexDigFromArray(qty, minInt, maxInt, out initSummOddIndexDig));
    Console.WriteLine($"В массиве: {output}");
    Console.WriteLine($"Cумма чисел на нечетных позициях = {initSummOddIndexDig}");
}

int [] funcSummOddIndexDigFromArray (int qty, int minInt, int maxInt, out int summOddIndexDig)
{
    int index = 0;
    summOddIndexDig = 0;
    int[] array = new int[qty];
    while (index < qty)
    {
        array[index] = new Random().Next(minInt,maxInt);
        if (index % 2 != 0) summOddIndexDig += array[index];
        index++;

    }
    return array;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №38
void task38func ()
{   
    Console.WriteLine("******************************************************************");
    Console.WriteLine("Программа показывает разность между MAX и MIN вещественными числами");
    Console.WriteLine("******************************************************************");
    Console.Write("Введите размер массива: ");
    int qty = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации массива: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации массива: ");
    int maxInt = int.Parse(Console.ReadLine());
    Console.Write("Введите точность числа (кол-во цифр после запятой): ");
    int accuracy = int.Parse(Console.ReadLine());
    double initDiff;
    double initMinResult;
    double initMaxResult;
    string output = String.Join(" | ",funcDiffMaxMinDig(qty, accuracy, minInt, maxInt, out initMinResult, out initMaxResult, out initDiff));
    Console.WriteLine($"В массиве: {output}");
    Console.WriteLine($"MIN число: {initMinResult}");
    Console.WriteLine($"MAX число: {initMaxResult}");
    Console.WriteLine($"Разность между MAX и MIN = {initDiff}");
}

double [] funcDiffMaxMinDig (int qty, int accuracy, int minInt, int maxInt, out double minResult, out double maxResult, out double diff)
{
    int index = 0;
    double min = 0;
    double max = 0;
    double [] array = new double [qty];
    diff = 0;
    while (index < qty)
    {
        array[index] = Math.Round(new Random().Next(minInt, maxInt) + new Random().NextDouble(), accuracy, MidpointRounding.AwayFromZero);
        if (index > 0) 
        {
            if (array [index] < min) min = array [index];
            if (array [index] > max) max = array [index];
        }
        index++;
    }
    minResult = min;
    maxResult = max;
    diff = Math.Round(max - min, accuracy, MidpointRounding.AwayFromZero);
    return array;
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи со звездочкой

void taskExtra ()
{
    Console.WriteLine("**********************************************");
    Console.WriteLine("Функция, реализующая невозрастающую сторировку");
    Console.WriteLine("**********************************************");
    Console.Write("Введите размер массива: ");
    int qty = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации массива: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации массива: ");
    int maxInt = int.Parse(Console.ReadLine());
    int [] initArrayResult = funcInitArray(qty, minInt, maxInt);
    string output = String.Join(", ",initArrayResult);
    Console.WriteLine($"Задан массив: {output}");
    output = String.Join(", ",funcSortBubbleReverse(initArrayResult));
    Console.WriteLine($"Результат   : {output}");
}

int [] funcInitArray(int qty, int minInt, int maxInt)
{   
    int index = 0;
    int[] initArrayRandom = new int[qty];
    while (index < qty)
    {
        initArrayRandom[index] = new Random().Next(minInt, maxInt);
        index++;
    }
    return initArrayRandom;
}
int [] funcSortBubbleReverse(int [] initArray)
{   
    for (int index = 0; index < initArray.Length - 1; index ++)
    {
        for (int counter = index + 1; counter < initArray.Length; counter ++)
        {
            if (initArray[index] < initArray[counter])
            {
                 int tempDigit = initArray[index];
                 initArray[index] = initArray[counter];
                 initArray[counter] = tempDigit;
            }
        }
    }
    return initArray;
}
