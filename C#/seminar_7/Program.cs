//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 3-х заданий 6-го семинара.");
Console.WriteLine("'1' - решение задачи 47");
Console.WriteLine("'2' - решение задачи 50");
Console.WriteLine("'3' - решение задачи 52");
Console.WriteLine("'4' - решение задачи *");
Console.Write("Введите символ (от 1 до 4), соответствующий задаче: ");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    Task47 ();
    break;

    case "2":
    Task50 ();
    break;

    case "3":
    Task52 ();
    break;

    case "4":
    taskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №47
void Task47 ()
{   
    Console.WriteLine("********************************************************************************************");
    Console.WriteLine("Программа задает двумерный массив размером m х n, заполненный случайными вещественными числами");
    Console.WriteLine("********************************************************************************************");
    Console.WriteLine("Введите размер двухмерного массива, а именно: ");
    Console.Write("Количество строк в двухмерном массиве = ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов в двухмерном массиве = ");
    int columns = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации массива вещественных чисел: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации массива вещественных чисел: ");
    int maxInt = int.Parse(Console.ReadLine());
    Console.Write("Введите точность числа (кол-во цифр после запятой): ");
    int accuracy = int.Parse(Console.ReadLine());
    Console.WriteLine("Получен массив: ");

    ShowMatrixDouble(
               InitMatrixDouble(rows, columns, accuracy, minInt, maxInt));
}

// Функция ниже дает рандомное вещественное число с заданной точностью
double MakeRandomDouble (int accuracy, int minInt, int maxInt)
{
    int resultIntPart = new Random().Next(minInt, maxInt+1);
    double resultDoublePart = new Random().NextDouble();
    double result = resultIntPart + resultDoublePart;
    result = Math.Round(result, accuracy, MidpointRounding.AwayFromZero);
    return result;
}

// Функция ниже генерирует матрицу из случайных вещественных значений
double [,] InitMatrixDouble(int rows, int columns, int accuracy, int minInt, int maxInt)
{   
    double [,] matrix = new double [rows,columns];

    for (int indexRow = 0; indexRow < rows; indexRow ++)
    {
        for (int indexColumn = 0; indexColumn < columns; indexColumn ++)
        {
            matrix[indexRow, indexColumn] = MakeRandomDouble (accuracy, minInt, maxInt);
        }
    }
    return matrix;
}

// Функция ниже выводит матрицу на экран
void ShowMatrixDouble (double [,] matrix)
{
    for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow ++)
    {
        if (indexRow != 0) Console.WriteLine(" ");
        for (int indexColumn = 0; indexColumn < matrix.GetLength(1); indexColumn ++)
        {
            Console.Write($"{matrix[indexRow, indexColumn]} ");
        }
    }
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №50
void Task50 ()
{   
    Console.WriteLine("*************************************************************************");
    Console.WriteLine("Программа возвращает число в матрице, по индексам, заданным пользователем");
    Console.WriteLine("*************************************************************************");
    Console.WriteLine("Существует массив: ");

    int rowQty = 5; // указание кол-ва строк в матрице
    int columnQty = 5; // указание кол-ва столбцов в матрице
    int minDigit = 0; // указание минимального числа в матрице
    int maxDigit = 9; // указание максимального числа в матрице
    int [,] resultMatrix = InitMatrixInt(rowQty, columnQty, minDigit, maxDigit);
    ShowMatrixInt(resultMatrix);
    Console.WriteLine();
    Console.WriteLine("Укажите позицию нужного элемента:");
    Console.Write("Индекс строки: ");
    int chosenRow = int.Parse(Console.ReadLine());
    Console.Write("Индекс столбца: ");
    int chosenColumn = int.Parse(Console.ReadLine());

    double initResult = FindElementInMatrix(resultMatrix, chosenRow, chosenColumn, out bool changed);
    if (!changed) Console.WriteLine ("Не существует элемента в выбранной позиции");
    else Console.Write($"Результат: {initResult}");
}

// Функция ниже ищет элемент в заданной матрице и возвращает значение найденного элемента или возращает false если элемент не найден
int FindElementInMatrix (int [,] matrix, int row, int column, out bool changed)
{
    int result = 0;
    changed = false;
    if (row < matrix.GetLength(0) && column < matrix.GetLength(1) 
        &&
        row >= 0 && column >= 0) 
    {
        result = matrix [row,column];
        changed = true;
    }
    return result;
}

//код задачи №52
void Task52 ()
{   
    Console.WriteLine("***************************************************************************************************************************");
    Console.WriteLine("Программа задает двумерный массив целых чисел размером m х n и вычисляет среднее арифметическое элементов в каждом столбце");
    Console.WriteLine("***************************************************************************************************************************");
    Console.WriteLine("Введите размер двухмерного массива, а именно: ");
    Console.Write("Количество строк в двухмерном массиве = ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов в двухмерном массиве = ");
    int columns = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации целых чисел: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации целых чисел: ");
    int maxInt = int.Parse(Console.ReadLine());
    Console.Write("Получен массив: ");
    Console.WriteLine();

    int [,] resultMatrix = InitMatrixInt (rows, columns, minInt, maxInt);
    ShowMatrixInt(resultMatrix);
    
    double [] resultAverage = AverageColumnDigits(resultMatrix);
    string resultAverageToString = string.Join(" | ", resultAverage.Select(x => x.ToString()).ToArray());

    Console.WriteLine();
    Console.Write($"Среднее арифметическое элементов в каждом столбце = {resultAverageToString}"); 

}

// Функция ниже генерирует матрицу из случайных целых значений
int [,] InitMatrixInt(int rows, int columns, int minInt, int maxInt)
{   
    int [,] matrix = new int [rows,columns];

    for (int indexRow = 0; indexRow < rows; indexRow ++)
    {
        for (int indexColumn = 0; indexColumn < columns; indexColumn ++)
        {
            matrix[indexRow, indexColumn] = new Random().Next(minInt, maxInt + 1);
        }
    }
    return matrix;
}

// Функция ниже выводит матрицу на экран
void ShowMatrixInt (int [,] matrix)
{
    for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow ++)
    {
        if (indexRow != 0) Console.WriteLine(" ");
        for (int indexColumn = 0; indexColumn < matrix.GetLength(1); indexColumn ++)
        {
            Console.Write($"{matrix[indexRow, indexColumn]} ");
        }
    }
}

// Функция ниже вычисляет среднее арифмеическое в столбцах матрицы
double [] AverageColumnDigits (int [,] matrix)
{
    double [] resultArray = new double [matrix.GetLength(1)];
    for (int indexColumn = 0; indexColumn < matrix.GetLength(1); indexColumn ++)
    {
        double summ = 0;
        for (int indexRow = 0; indexRow < matrix.GetLength(0); indexRow ++)
        {   
            summ += matrix[indexRow, indexColumn];
        }
        resultArray [indexColumn] = summ / matrix.GetLength(0);
    }
    return resultArray;
}

void taskExtra ()
{
    Console.WriteLine("***********************************************************");
    Console.WriteLine("Программа для перевода римских чисел в десятичные арабские.");
    Console.WriteLine("***********************************************************");
    Console.Write("Введите число римскими числами: ");
    string stringRomanInput = Console.ReadLine();
    string stringRomanOutput = StringRomanCheckAndRepair(stringRomanInput);
    Console.WriteLine($"Будет преобразовано число: {stringRomanOutput}");
    Console.WriteLine($"Результат преобразования: {ConvertRomanToInt(stringRomanOutput)}");
}

// Функция ниже приводит введенную пользователем строку в преобразуемый вид
string StringRomanCheckAndRepair (string input)
{
    char [] avaibleRomanChars = {'I','V','X','L','C','D','M'}; // словарь основных римских чисел
    
    input = input.ToUpper();
    string output = String.Empty;

    foreach (var ch in input)
    {   
        if (input.Length == output.Length) break;
        for (int i = 0; i < avaibleRomanChars.Length; i ++)
        {   
            if (ch.Equals(avaibleRomanChars[i])) 
            {
                output += avaibleRomanChars[i];
                break;
            }
        }
        
    }
    return output;
}

// Функция принимает римскую цифру и выводит соответсвующее число
int OutputDigitFromRoman (char RomanDigit)
{   
    int result = 0; 
    switch (RomanDigit)
    {
        case 'I':
            result = 1;
            break;
        case 'V':
            result = 5;
            break;
        case 'X':
            result = 10;
            break;
        case 'L':
            result = 50;
            break;
        case 'C':
            result = 100;
            break;
        case 'D':
            result = 500;
            break;
        case 'M':
            result = 1000;
            break;
    }
    return result;
}

int ConvertRomanToInt (string input)
{   
    
    int [] digitArray = new int [input.Length];
    int i = 0;
    int summ = 0;

    // Часть функции ниже переводит римские цифры в массив чисел используя метод OutputDigitFromRoman
    foreach (var ch in input)
    {
        digitArray[i] = OutputDigitFromRoman(ch);
        i++;
    }

    // Часть функции анализирует число по принципу вычитания (если число меньше следующего, ему призваевается отрицательное значение)
    for (i = 1; i < digitArray.Length; i ++)
    {
        if (digitArray[i - 1] < digitArray[i]) digitArray[i - 1] *= -1;
    }

    // Часть функции складывает все числа в массиве
    foreach (int digit in digitArray) summ += digit;

    return summ;
}
