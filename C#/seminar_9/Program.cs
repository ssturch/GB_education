using System.Diagnostics;
//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 4-х заданий 9-го семинара.");
Console.WriteLine("'1' - решение задачи 64");
Console.WriteLine("'2' - решение задачи 66");
Console.WriteLine("'3' - решение задачи 68");
Console.WriteLine("'4' - решение задачи *");
Console.Write("Введите символ (от 1 до 4), соответствующий задаче: ");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    Task64 ();
    break;

    case "2":
    Task66 ();
    break;

    case "3":
    Task68 ();
    break;

    case "4":
    TaskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №64 - решена обратным выводом
void Task64 ()
{   
    Console.WriteLine("**********************************************************************************");
    Console.WriteLine("Программа выводит все натуральные числа в промежутке от M до N в обратную сторону.");
    Console.WriteLine("**********************************************************************************");

    bool correct = false;
    int digitMin = 0;
    int digitMax = 0;

    while (correct == false)
    {
        Console.Write("Введите натуральное число M: ");
        digitMin = int.Parse(Console.ReadLine());
        Console.Write("Введите натуральное число N: ");
        digitMax = int.Parse(Console.ReadLine());
        if (digitMin < digitMax) correct = true;
        else Console.WriteLine("M должно быть > N!");
    }

    void DigitsGenerator (int m, int n)
    {
        if (m == n) 
        {   
            Console.Write(m);
        }
        else 
        {
            Console.Write($"{n}, ");
            DigitsGenerator (m, n - 1);  
        }
    }

    DigitsGenerator(digitMin, digitMax);
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №66
void Task66 ()
{   
    Console.WriteLine("***************************************************************");
    Console.WriteLine("Программа найдёт сумму натуральных чисел в промежутке от M до N");
    Console.WriteLine("***************************************************************");
    bool correct = false;
    int digitMin = 0;
    int digitMax = 0;

    while (correct == false)
    {
        Console.Write("Введите натуральное число M: ");
        digitMin = int.Parse(Console.ReadLine());
        Console.Write("Введите натуральное число N: ");
        digitMax = int.Parse(Console.ReadLine());
        if (digitMin < digitMax) correct = true;
        else Console.WriteLine("M должно быть > N!");
    }


    int SummGenerator (int m, int n)
    {
        return m == n? n : m += SummGenerator(m + 1, n);
    }

    Console.WriteLine($"Сумма чисел от {digitMin} до {digitMax} = {SummGenerator (digitMin, digitMax)}");
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №68
void Task68 ()
{   
    Console.WriteLine("************************************************************");
    Console.WriteLine("Программа осуществляет функцию Аккермана и выводит результат");
    Console.WriteLine("************************************************************");
    bool correct = false;
    double digitM = 0;
    double digitN = 0;

    while (correct == false)
    {
        Console.Write("Введите натуральное положительное число M: ");
        digitM = double.Parse(Console.ReadLine());
        Console.Write("Введите натуральное положительное число N: ");
        digitN = double.Parse(Console.ReadLine());
        if (digitM >= 0 && digitN >= 0) correct = true;
        else Console.WriteLine("M и N должны быть положительными числами!");
    }
    
    double AkkermanFunc(double m, double n)
    {
        if (m == 0) return n + 1;
        else if (n == 0 && m > 0) return AkkermanFunc(m - 1, 1);
        else return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }

    Console.WriteLine($"Результ: {AkkermanFunc(digitM, digitN)}");
}
 
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи со звездочкой
void TaskExtra ()
{   
    Console.WriteLine("******************************************************************************");
    Console.WriteLine("Программа определяющая, правильная ли скобочная последовательность была введена");
    Console.WriteLine("******************************************************************************");
    Console.Write("Введите скобочную последовательность: ");
    string input = Console.ReadLine();

    char tempCh ='0';
    bool correct = false;

    foreach(char ch in input)
    {   
        if (ch == '(' || ch == '[' || ch == '{') 
        {
            tempCh = ch;
            Console.WriteLine(ch + "OK");
            correct = true;
            continue;
        }
        else if (ch == ')' && tempCh == '(' ||
                 ch == ']' && tempCh == '[' || 
                 ch == '}' && tempCh == '{')
        {
            tempCh = '0';
            correct = true;
            continue;
        }
        else 
        { 
            correct = false;
            break;
        }
    }

    if (correct == false) Console.WriteLine("Скобочная последовательность введена НЕПРАВИЛЬНО!");
    else Console.WriteLine("Скобочная последовательность введена ПРАВИЛЬНО!");
}