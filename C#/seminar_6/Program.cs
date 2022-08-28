//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 3-х заданий 6-го семинара.");
Console.WriteLine("'1' - решение задачи 41");
Console.WriteLine("'2' - решение задачи 43");
Console.WriteLine("'3' - решение задачи *");
Console.Write("Введите символ (от 1 до 3), соответствующий задаче: ");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    task41func ();
    break;

    case "2":
    task43func ();
    break;

    case "3":
    taskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №41
void task41func ()
{   Console.WriteLine("**************************************************************");
    Console.WriteLine("Программа показывает количество чисел > 0 во введенном массиве");
    Console.WriteLine("**************************************************************");
    int [] resultArr = funcInputArr();
    Console.Write($"Получен массив: ");
    funcWriteIntArray(resultArr);
    Console.WriteLine($"Кол-во чисел > 0: {funcCountDigitMoreThenZeroFromArr(resultArr)}");
}

int[] funcInputArr() //функция ввода массива (с исключением ошибок ввода)
{
    Console.Write("Введите массив целых чисел через пробел: ");
    string inputString = Console.ReadLine();
    int [] inputIntArr = {};
    int i = 0;
    string [] inputStringArr = inputString.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    foreach (string value in inputStringArr)
    {
        if (int.TryParse(value, out var intData)) 
        {
            Array.Resize(ref inputIntArr, inputIntArr.Length + 1);
            inputIntArr [i] = intData;
            i++;
        }
    }
    return inputIntArr;
}

int funcCountDigitMoreThenZeroFromArr(int [] arr) //Функция подсчета чисел >0
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count ++;
    }
    return count;
}

void funcWriteIntArray(int [] arr) //функция вывода целочисленного массива
{
    string outputString = System.String.Empty;
    foreach(int item in arr)
    {
        Console.Write(item.ToString());
        Console.Write(" ");
    }
    Console.WriteLine();
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №43
void task43func ()
{   
    Console.WriteLine("*****************************************************************************************");
    Console.WriteLine("Программа показывает точки пересечения прямых, заданных уравнениями y=k1*x+b1 и y=k2*x+b2");
    Console.WriteLine("*****************************************************************************************");
    Console.Write("Введите коэффициент k1: ");
    double k1 = double.Parse(Console.ReadLine());
    Console.Write("Введите коэффициент b1: ");
    double b1 = double.Parse(Console.ReadLine());
    Console.Write("Введите коэффициент k2: ");
    double k2 = double.Parse(Console.ReadLine());
    Console.Write("Введите коэффициент b2: ");
    double b2 = double.Parse(Console.ReadLine());

    funcFindInterSectPoint(k1, k2, b1, b2, out double resultX, out double resultY, out string message);
    if (message == System.String.Empty)  Console.WriteLine($"При заданных коэффициэнтах точкой пересечения является: x = {resultX}, y = {resultY}");
    else 
    {
        Console.WriteLine($"При заданных коэффициентах: {message}");
    }
}

void funcFindInterSectPoint (double k1, double k2, double b1, double b2, out double intersectX, out double intersectY, out string message)
{
    message = System.String.Empty;
    if (k1 == k2 && b1 == b2) 
    {
        message = "Данные прямые совпадают";
        intersectX = 0;
        intersectY = 0;
    }
    else if (k1 == k2) 
    {
        message = "Данные прямые параллельны";
        intersectX = 0;
        intersectY = 0;
    }
    else 
    {
        intersectX = (b2 - b1)/(k1 - k2);
        intersectY = k2 * intersectX + b2;
    }
}

void taskExtra ()
{
    Console.WriteLine("***********************************************************************************************************************");
    Console.WriteLine("Функция, реализующая разворачивание двухмерного массива в одномерный, начиная с последней строки против часовой стрелки");
    Console.WriteLine("***********************************************************************************************************************");
    Console.WriteLine("Введите размер двухмерного массива, а именно: ");
    Console.Write("Количество строк в двухмерном массиве = ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов в двухмерном массиве = ");
    int columns = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации массива: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации массива: ");
    int maxInt = int.Parse(Console.ReadLine());
    int [,] initMatrixResult = funcInitMatrix(rows,columns, minInt, maxInt);
    Console.Write("Полученный, развернутый, массив: ");
    arrayConsoleOutput(funcConvertMatrixToArray(initMatrixResult));
}

//Функция ниже инициализирует 2-х мерный массив из рандомных чисел
int [,] funcInitMatrix(int rows, int columns, int minInt, int maxInt)
{   
    Console.WriteLine(" ");
    Console.WriteLine("Сгенерирован массив:");
    int[,] initMatrixRandom = new int[rows,columns];

    for (int indexRow = 0; indexRow < rows; indexRow ++)
    {
        if (indexRow != 0) Console.WriteLine(" ");
        for (int indexColumn = 0; indexColumn < columns; indexColumn ++)
        {
            initMatrixRandom[indexRow, indexColumn] = new Random().Next(minInt, maxInt+1);
            Console.Write($"{initMatrixRandom[indexRow, indexColumn]} ");
        }
    }
    Console.WriteLine(" ");
    return initMatrixRandom;
}

// Данная функция выполняет условие задачи по разворачиванию 2-х мерного массива (матрицы) в 1-о мерный, против часовой стрелки, начиная с посленей строки
// Программа состоит из 3-х частей
// 1. Поиск максимального числа в матрице и получение из него стоп-числа
// 2. Получение в виде 2-х массивов очередности прохождения строк и столбцов матрицы для осуществления движения "против часовой стрелки"
// 3. Прохождение матрицы против часовой стрелки, запись значений в одномерный массив и замена записанных числе в матрице стоп-числом

int [] funcConvertMatrixToArray(int [,] matrix)
{   
    //---------------------------------------------
    // Данная часть находит стоп-число путем поиска максимального числа и прибавления к нему единицы
    int max = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix [i,j] > max) max = matrix [i,j];
        }
    }
    int stopValue = max + 1;
    //---------------------------------------------
    //---------------------------------------------
    // Данная часть находит очередность прохода строк и записывает ее в массив, например [2, 0, 1]
    int [] rowCountingOrder = new int [matrix.GetLength(0)]; 
    bool switchCounting = false; //переключатель
    int rowCountByEnd = matrix.GetLength(0) - 1;
    int rowCountByStart = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (switchCounting == false)
        {  
            rowCountingOrder [i] = rowCountByEnd;
            rowCountByEnd --;
            switchCounting = true;
            //Console.Write($"{rowCountingOrder [i]} ");
            continue;
        }
        if (switchCounting == true)
        {
            rowCountingOrder [i] = rowCountByStart;
            rowCountByStart ++;
            switchCounting = false;
            //Console.Write($"{rowCountingOrder [i]} ");
            continue;
        }
    }
    // Данная часть находит очередность прохода столбцов и записывает ее в массив, например [3, 0, 2, 1]
    int [] columnCountingOrder = new int [matrix.GetLength(1)];
    switchCounting = false;
    int columnCountByEnd = matrix.GetLength(1) - 1;
    int columnCountByStart = 0;

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        if (switchCounting == false)
        {  
            columnCountingOrder [i] = columnCountByEnd;
            columnCountByEnd --;
            switchCounting = true;
            //Console.Write($"{columnCountingOrder [i]} ");
            continue;
        }
        if (switchCounting == true)
        {
            columnCountingOrder [i] = columnCountByStart;
            columnCountByStart ++;
            switchCounting = false;
            //Console.Write($"{columnCountingOrder [i]} ");
            continue;
        }
    }
    //---------------------------------------------
    //---------------------------------------------
    // Данная программа с помощью выше полученных массива порядка перебора строк/столбцов и переключателей реализизует обход матрицы
    // при этом значение не равные стоп-числу записываются в массив, а в матрице они заменяются на стоп-число для исключения их попадания в результат вычислений
    int [] resultArr = new int [matrix.Length];
    bool switchRowColumn = false;
    bool switchDirection = false;
    int arrayCounter = 0;
    int n = 0;
    int m = 0;
    int MatrixDigitQty = matrix.GetLength(0) * matrix.GetLength(1);

    while (arrayCounter < MatrixDigitQty)
    {   
        if (switchRowColumn == false)
        {
            if (switchDirection == false)
            {
                for (int k = 0; k < matrix.GetLength(1); k ++)
                {   
                    if (matrix [rowCountingOrder[n], k] != stopValue)
                    {
                        resultArr[arrayCounter] = matrix [rowCountingOrder[n], k];
                        //Console.Write(resultArr[arrayCounter]);
                        arrayCounter ++;
                        matrix [rowCountingOrder[n], k] = stopValue;
                    }
                }
                n++;
                switchDirection = true;
                switchRowColumn = true;
                continue;
            }
            if(switchDirection == true)
            {
                for (int k = matrix.GetLength(1) - 1; k >= 0; k --)
                {
                    if (matrix [rowCountingOrder[n], k] != stopValue)
                    {
                        resultArr[arrayCounter] = matrix [rowCountingOrder[n], k];
                        //Console.Write(resultArr[arrayCounter]);
                        arrayCounter ++;
                        matrix [rowCountingOrder[n], k] = stopValue;
                    }
                }
                n++;
                switchDirection = false;
                switchRowColumn = true;
                continue;
            }
        }
        if (switchRowColumn == true)
        {
            if(switchDirection == false)
            {
                for (int k = 0; k < matrix.GetLength(0); k ++)
                {
                    if(matrix [k, columnCountingOrder[m]] != stopValue)
                    {
                        resultArr[arrayCounter] = matrix [k, columnCountingOrder[m]];
                        //Console.Write(resultArr[arrayCounter]);
                        arrayCounter ++;
                        matrix [k, columnCountingOrder[m]] = stopValue;
                    }
                }
                m ++;
                switchDirection = false;
                switchRowColumn = false;
                continue;
            }
            if(switchDirection == true)
            {
                for (int k = matrix.GetLength(0) - 1; k >= 0; k --)
                {
                    if (matrix [k, columnCountingOrder[m]] != stopValue)
                    {
                        resultArr[arrayCounter] = matrix [k, columnCountingOrder[m]];
                        //Console.Write(resultArr[arrayCounter]);
                        arrayCounter ++;
                        matrix [k, columnCountingOrder[m]] = stopValue;
                    }
                }
                m ++;
                switchDirection = true;
                switchRowColumn = false;
                continue;
            }
        }
    }
return resultArr;
}

// Функция для вывода массива
void arrayConsoleOutput (int [] array)
{
   for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" {array[i]}") ;
    } 
    Console.WriteLine();
}