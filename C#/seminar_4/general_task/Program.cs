//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 4-х заданий 4-го семинара.");
Console.WriteLine("'1' - решение задачи 25");
Console.WriteLine("'2' - решение задачи 27");
Console.WriteLine("'3' - решение задачи 29");
Console.WriteLine("'4' - решение задачи *");
Console.WriteLine("Введите символ (от 1 до 4), соответствующий задаче:");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    task25func ();
    break;

    case "2":
    task27func ();
    break;

    case "3":
    task29func ();
    break;

    case "4":
    taskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №25
void task25func ()
{   Console.WriteLine("**************************************");
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
        else Console.WriteLine($"Результат: {num}^{pow} = {result}");
    }
}

int funcPow (int num, int pow)
{
    int result = 1;
    for (int i = 1; i <= pow; i++)
    {
        result *= num;
    }
    return result;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №27
void task27func ()
{   
    Console.WriteLine("***********************************************");
    Console.WriteLine("Программа суммирует все цифры в введенном числе");
    Console.WriteLine("***********************************************");
    Console.Write("Введите число: ");

    int num = int.Parse(Console.ReadLine());
    Console.Write($"Сумма всех цифр в числе {num} = {funcSummDigits(num)}");
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
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №27
void task29func ()
{   
    Console.WriteLine("**************************************************************");
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

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи со звездочкой

void taskExtra ()
{
    Console.WriteLine("*******************************************");
    Console.WriteLine("Функция, рисующая ёлочку согласно её высоте");
    Console.WriteLine("*******************************************");
    Console.Write("Введите высоту ёлочки: ");
    int height = int.Parse(Console.ReadLine());
    funcFirTree(height);

}

void funcFirTree (int maxHeight)
{   
    Console.Clear();
    int startPoint = 100; // точка старта (верхушка ёлки)
    int minHeight = 3; // минимальная высота секции елки
    int multiplRatio = 3; // множитель размеров секции елки
    int minChrPlace = 0; // положение строки начала новой секции
    int x = 0;
    int y = 0; 

    for (int i = 0; i < maxHeight; i++) // цикл построения секций елки
    {
        if (i != 0) minChrPlace = minChrPlace + minHeight; // смещение строки начала новой секции, если строится не первая секция
        if (i != 0) minHeight = minHeight + multiplRatio; // изменение высоты секции, если строится не первая секция
        int m = 1;                                       // счетчик для получения нечетного количества символов
        for (int j = 0; j < minHeight; j++) // цикл построения строк секций (построчно)
        {         
            for (int n = 0; n < m; n++) // цикл отрисовки символов в строке секции
            {
                x = startPoint + n - j; // положение указателя с учетом стартовой точки и смещения по столбцу
                y = j + minChrPlace; // положение указателя с учетом стартовой точки и смещения по строке
                Console.SetCursorPosition(x,y); 
                Console.Write("*");
            }
            m += 2; // инкремент счетчика для получения нечетного количества символов      
        }
    }
}
