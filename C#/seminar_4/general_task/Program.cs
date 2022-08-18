void task25func ()
{   
    Console.WriteLine("Программа возводит число A в степень B");
    Console.WriteLine("**************************************");
    Console.Write("Введите число A: ");
    int num = int.Parse(Console.ReadLine());

    Console.Write("Введите степень B: ");
    int pow = int.Parse(Console.ReadLine());
    if (num == 0 && pow == 0) Console.Write($"Ошибка: {num}^{pow} - данное выражение не имеет смысла");
    else 
    {
        int result = funcPow(num, pow);
        if (num != 0 && pow != 0 && result == 0) Console.Write($"Ошибка: Результат вычисления {num}^{pow} переполняет переменную int");
        else Console.Write($"Результат: {num}^{pow} = {result}");
    }
}

void task27func ()
{   
    Console.WriteLine("Программа суммирует все цифры в введенном числе");
    Console.WriteLine("***********************************************");
    Console.Write("Введите число: ");

    int num = int.Parse(Console.ReadLine());
    Console.Write($"Сумма всех цифр в числе {num} = {funcSummDigits(num)}");
}

void task29func ()
{  
    Console.WriteLine("Программа создает массив из N чисел, случайно взятых из [A, B)");
    Console.WriteLine("**************************************************************");
    Console.Write("Введите количество чисел N: ");
    int qty = int.Parse(Console.ReadLine());

    Console.Write("Введите число A: ");
    int value1 = int.Parse(Console.ReadLine());

    Console.Write("Введите число B: ");
    int value2 = int.Parse(Console.ReadLine());

    string output = "";
    if (value1 <= value2) output = String.Join(", ",funcArrFromAtoB(qty, value1, value2));
    if (value1 > value2) output = String.Join(", ",funcArrFromAtoB(qty, value2, value1));

    Console.Write($"Результат: {output}"); 
}

// void taskExtra ()
// {
//     Console.WriteLine("Функция, рисующая ёлочку согласно её высоте");
//     Console.WriteLine("*******************************************");
//     Console.Write("Введите высоту ёлочки: ");
//     int height = int.Parse(Console.ReadLine());
//     funcFirTree(height);

// }




int funcPow (int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= num;
    }
    return result;
}

int funcSummDigits (int num)
{
    int result = 0;
    int lastDigit = 0;
    int summ = 0;
    do
    {      
        lastDigit += lastDigit;
        lastDigit = num % 10;
        num /= 10;
        summ += lastDigit;
    }
    while (num != 0);
    return summ;
}

int[] funcArrFromAtoB(int qty, int valueA, int valueB)
{
    int index = 0;
    int[] array = new int[qty];
    while (index < qty)
    {
        array[index] = new Random().Next(valueA,valueB - 1);
        index++;
    }
    return array;
}

// void funcFirTree (int height)
// {   
//     Console.Clear();
//     int x = 10; // точка старта (верхушка ёлки)
//     int k = 3; // минимальная высота секции елки
//     int f = 2; // множитель размеров секции елки
//     for (int i = 1; i < height - 1; i++)
//     {
//         for (int j = 0; j < i * k; j++)
//         {
//             for (int n = 0; n < )
//         Console.SetCursorPosition(x + j,j);
//         Console.WriteLine("+");
//         }
//     }
// }

task25func ();
//task27func ();
//task29func ();

//taskExtra ();