using System.Diagnostics;
//------------------------------------------------------------------------------------------------------------------------------------
//Стартовый код
Console.WriteLine("************************************************************");
Console.WriteLine("Данная программа содержит решения 6-ти заданий 8-го семинара.");
Console.WriteLine("'1' - решение задачи 54");
Console.WriteLine("'2' - решение задачи 56");
Console.WriteLine("'3' - решение задачи 58");
Console.WriteLine("'4' - решение задачи 60");
Console.WriteLine("'5' - решение задачи 62");
Console.WriteLine("'6' - решение задачи *");
Console.Write("Введите символ (от 1 до 6), соответствующий задаче: ");
string numTask = Console.ReadLine();

switch (numTask)
{
    case "1":
    Task54 ();
    break;

    case "2":
    Task56 ();
    break;

    case "3":
    Task58 ();
    break;

    case "4":
    Task60 ();
    break;

    case "5":
    Task62 ();
    break;

    case "6":
    taskExtra ();
    break;

    default:
    Console.WriteLine("Такой задачи в списке нет!");
    break;
}
//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №54
void Task54 ()
{   
    Console.WriteLine("******************************************************************************");
    Console.WriteLine("Программа упорядочивает по убыванию элементы каждой строки 2-х мерного массива");
    Console.WriteLine("******************************************************************************");
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

    for (int i = 0; i < resultMatrix.GetLength(0); i ++)
    {
        int [] tempArray = CopyFrom2DArray(resultMatrix, true, false, i, 0);
        tempArray = SortBubbleReverse(tempArray);
        resultMatrix = CopyTo2DArray(tempArray, resultMatrix, true ,false ,i ,0);
    }
    
    Console.WriteLine();
    Console.WriteLine($"Результат:"); 
    ShowMatrixInt(resultMatrix);

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

// Функция ниже сортирует по убыванию полученный массив
int [] SortBubbleReverse(int [] initArray)
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

// Функция ниже копирует в одномерный массив строку или столбец двухмерного массива

int [] CopyFrom2DArray (int [,] initArray, bool copyRow, bool copyColumn, int indexRow, int indexColumn)
{
    int [] resultArr = new int [0];
    if (copyRow == true)
    {
        resultArr = new int [initArray.GetLength(1)];
        for (int i = 0; i < initArray.GetLength(1); i ++)
        {
            resultArr [i] = initArray[indexRow, i];
        }
    }

    if (copyColumn == true)
    {
        resultArr = new int [initArray.GetLength(0)];
        for (int i = 0; i < initArray.GetLength(0); i ++)
        {
            resultArr [i] = initArray[i, indexColumn];
        }
    }
    return resultArr;
}

// Функция ниже копирует в строку или столбец двухмерного массива одномерный массив

int [,] CopyTo2DArray (int [] arrayToCopy, int [,] oldArray, bool copyToRow, bool copyToColumn, int indexRow, int indexColumn)
{
    if (copyToRow == true)
    {
        for (int i = 0; i < oldArray.GetLength(1); i ++)
        {
            oldArray[indexRow, i] = arrayToCopy[i];
        }
    }

    if (copyToColumn == true)
    {
        for (int i = 0; i < oldArray.GetLength(0); i ++)
        {
            oldArray[i, indexColumn] = arrayToCopy[i];
        }
    }
    return oldArray;
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №56
void Task56 ()
{   
    Console.WriteLine("*****************************************************************************************");
    Console.WriteLine("Программа находит строку в прямоугольном 2-х мерном массиве с наименьшей суммой элементов");
    Console.WriteLine("*****************************************************************************************");
    Console.WriteLine("Введите размер прямоугольно двухмерного массива, а именно: ");
    Console.Write("Количество строк в двухмерном прямоугольном массиве = ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов в двухмерном прямоугольном массиве = ");
    int columns = int.Parse(Console.ReadLine());
    while (rows == columns) 
    {
        Console.WriteLine("Данный 2-х мерный массив не является прямоугольным, введите кол-во столбцов > или < кол-ву строк!");
        Console.Write("Количество столбцов в двухмерном прямоугольном массиве = ");
        columns = int.Parse(Console.ReadLine());
    }
    Console.Write("Введите MIN целое число для генерации целых чисел: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации целых чисел: ");
    int maxInt = int.Parse(Console.ReadLine());
    Console.Write("Получен массив: ");
    Console.WriteLine();

    int [,] resultMatrix = InitMatrixInt (rows, columns, minInt, maxInt);
    ShowMatrixInt(resultMatrix);
    Console.WriteLine();

    int minSumm = maxInt * columns;
    int minSummIndex = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i ++)
    {
        int [] tempArray = CopyFrom2DArray(resultMatrix, true, false, i, 0);
        int tempSumm = SummOfDigitsInArray(tempArray);
        if (minSumm > tempSumm)
        {
            minSumm = tempSumm;
            minSummIndex = i + 1; 
        } 
    }

    if (minSummIndex == 0) 
    {
        Console.WriteLine("Все строки имеют одинаковую сумму!");
    }
    else
    {
    Console.WriteLine($"Наименьшую сумму элементов имеет строка №: {minSummIndex}");
    }
}

//Функция ниже считает сумму элементов в массиве

int SummOfDigitsInArray (int [] inputArray)
{
    int summ = 0;
    foreach (var digit in inputArray) summ += digit;
    return summ;
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №58
void Task58 ()
{   
    Console.WriteLine("******************************************");
    Console.WriteLine("Программа находит произведение двух матриц");
    Console.WriteLine("******************************************");
    Console.WriteLine("Введите размер матриц:");
    Console.Write("Количество строк в каждой матрице = ");
    int rows = int.Parse(Console.ReadLine());
    Console.Write("Количество столбцов в каждой матрице = ");
    int columns = int.Parse(Console.ReadLine());
    Console.Write("Введите MIN целое число для генерации целых чисел в матрицах: ");
    int minInt = int.Parse(Console.ReadLine());
    Console.Write("Введите MAX целое число для генерации целых чисел в матрицах: ");
    int maxInt = int.Parse(Console.ReadLine());

    int [,] matrixA = InitMatrixInt (rows, columns, minInt, maxInt);
    int [,] matrixB = InitMatrixInt (rows, columns, minInt, maxInt);

    Console.WriteLine("------------------");
    Console.WriteLine("Получена матрица A");
    ShowMatrixInt(matrixA);
    Console.WriteLine();
    Console.WriteLine("------------------");

    Console.WriteLine("Получена матрица B");
    ShowMatrixInt(matrixB);
    Console.WriteLine();
    Console.WriteLine("-----------------------");

    Console.WriteLine("Произведение матриц A*B");
    ShowMatrixInt(MatrixMultiply(matrixA, matrixB));
    Console.WriteLine();
    Console.WriteLine("-----------------------");


}

// Функция ниже реализует произведение двух матриц используя метод ScalarMultiplyVector
int [,] MatrixMultiply (int [,] matrixA, int [,] matrixB)
{
    int [,] resultMatrix = new int [matrixA.GetLength(0),matrixB.GetLength(1)];
    for (int i = 0; i < matrixA.GetLength(0); i ++)
    {
        int [] tempArrayFromMatrixA = CopyFrom2DArray(matrixA, true, false, i, 0);
        for (int j = 0; j < matrixB.GetLength(1); j ++ )
        {
            int [] tempArrayFromMatrixB = CopyFrom2DArray(matrixB, false, true, 0, j);
            resultMatrix[i,j] = ScalarMultiplyVector(tempArrayFromMatrixA,tempArrayFromMatrixB); 
        }
    }  
    return resultMatrix;
}
    
//Функция ниже реализует скалярное произведение двух вектор - строк

int ScalarMultiplyVector (int [] vectorA, int [] vectorB)
{
    int result = 0;
    int i = 0;
    if (vectorA.Length != vectorB.Length) return result;
    foreach (var digit in vectorA) 
    {   
        result += vectorA[i] * vectorB[i]; 
        i++;
    }
    return result;
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №60
void Task60 ()
{   
    Console.WriteLine("**************************************************************************");
    Console.WriteLine("Программа формирует трехмерный массив из неповторяющихся двухзначных чисел");
    Console.WriteLine("Массив выводится построчно, совместно в инжексами каждого элемента");
    Console.WriteLine("**************************************************************************");
    Console.WriteLine("Введите размер массива:");
    bool exitUserChoise = false;
    //Проверка максимальной размерности массива (общее кол-во цифр не должно быть > 90, согласно условию "двухзначные числа")
    //-------------------------------------------------------------
    int rows = 0;
    int columns = 0;
    int sheets = 0;
    while(!exitUserChoise)
    {
        Console.Write("Количество слоев массива = ");
        sheets = int.Parse(Console.ReadLine());
        Console.Write("Количество строк в каждом слое = ");
        rows = int.Parse(Console.ReadLine());
        Console.Write("Количество столбцов в каждом слое = ");
        columns = int.Parse(Console.ReadLine());
        int arrSize = columns * rows * sheets;
        if (arrSize < 91) exitUserChoise = true;
        else 
        {
            Console.WriteLine("Размер массива > чем возможное количество 2-х значных чисел.\nВведите другой размер массива:");
        }
    }
    //-------------------------------------------------------------
    
    int minInt = 10;
    int maxInt = 99;
    int [] digitsTo3dArray = RandomArrayDigitNonRecurring(minInt,maxInt);
    int [,,] result3dArray = new int [rows,columns,sheets];

    int m = 0; //счетчик для массива случайных неповторяющихся двухзначных числел
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < sheets; k++)
            {
                result3dArray [i ,j ,k] = digitsTo3dArray[m];
                m ++;
            }
        }
    }

    Console.WriteLine("Получен 3-х мерный массив:");
    Show3dArrayInStringWithIndex(result3dArray);
}

//Функция ниже генерирует массив случайных неповторяющихся чисел 
int [] RandomArrayDigitNonRecurring (int minInt, int maxInt)
{
    int [] digitArray = new int [maxInt - minInt + 1]; 
    int [] resultArray = new int [maxInt - minInt + 1];
    int randomIndex = 0;

    //Формирование упорядоченного массива чисел от minInt до int maxInt
    digitArray[0] = minInt;
    for (int i = 1; i < digitArray.Length; i++)
    {
        digitArray[i] = digitArray[i-1] + 1;
    }
    
    //Создание выходного массива с рандомно расположенными неповторяющимися числами
    int j = 0;
    while (digitArray.Length > 0) //цикл продолжается до тех пор пока длина упоряоченного массива > 0
    {
            randomIndex = new Random().Next(0, digitArray.Length); //выбор случайного индекса
            resultArray[j] = digitArray[randomIndex]; //запись в выходной массив числа сооответсвующему случайному индекса
            j++;                                      //инкремент для выходного массива
            int tempDigit = digitArray[digitArray.Length - 1]; //запись последнего числа из упорядоченного массива
            digitArray[randomIndex] = tempDigit; //подстановка последнего числа в упорядоченный массив вместо числа попавшего в выходной массив
            Array.Resize(ref digitArray, digitArray.Length - 1); //сокращение упорядоченного массива на одну позицию
    }

    return resultArray;
}

void Show3dArrayInStringWithIndex (int [,,] array3D)
{

    for (int k = 0; k < array3D.GetLength(2); k++)
    {
        for (int i = 0; i < array3D.GetLength(0); i++)
        {
            for (int j = 0; j < array3D.GetLength(1); j++)
            {
              Console.Write($"{array3D[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }

}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи №62 (код является чуть переделанным кодом из задачи со звездочкой 6-го семинара)
void Task62 ()
{   
    Console.WriteLine("******************************************************");
    Console.WriteLine("Программа заполняет 2-х мерный массив 4 х 4 по спирали");
    Console.WriteLine("******************************************************");
    Console.Write("Введите стартовое число: ");
    int startDigit = int.Parse(Console.ReadLine());
    int stopValue = startDigit - 1; //стоп число для заполнения массива и сравнения
    int s = 4;                      //размерность 2-х мерного квадратного массива согласно условию
    int [,] spiralArray = InitMatrixInt(s,s,stopValue,stopValue); //заполнение массива стоп-числом (используется не самый оптимальный метод, но рабочий)
    int [] rowCountingOrder = {0,3,1,2};  //очередь обработки строк
    int [] columnCountingOrder = {3,0,2,1}; //очередь обработки столбцов
    bool switchRowColumn = false;
    bool switchDirection = false;
 
    
    
    int i = 0; //итератор для операций со строками и столбцами
    int n = 0; //итератор строк
    int m = 0; //итератор столбцов

    while (i < s*2-1) //s*2-1 определяет максимальное количество обработок строк и столбцов для массив
    {
        if (switchRowColumn == false)
        {
            if (switchDirection == false)
            {
                for (int k = 0; k < s; k ++)
                {   
                    if (spiralArray[rowCountingOrder[n], k] == stopValue)
                    {
                        spiralArray[rowCountingOrder[n], k] = startDigit;
                        startDigit += 1;
                    }
                }
                n ++;
                i ++;
                switchRowColumn = true;
                switchDirection = false;
                continue;
            }
            if(switchDirection == true)
            {
                for (int k = s - 1; k >= 0; k --)
                {
                    if (spiralArray[rowCountingOrder[n], k] == stopValue)
                    {
                        spiralArray[rowCountingOrder[n], k] = startDigit;
                        startDigit += 1;
                    }
                }
                n ++;
                i ++;
                switchRowColumn = true;
                switchDirection = true;
                continue;
            }
        }
        if (switchRowColumn == true)
        {
            if(switchDirection == false)
            {
                for (int k = 0; k < s; k ++)
                {
                    if(spiralArray[k, columnCountingOrder[m]] == stopValue)
                    {
                        spiralArray[k, columnCountingOrder[m]] = startDigit;
                        startDigit += 1;
                    }
                }
                m ++;
                i ++;
                switchRowColumn = false;
                switchDirection = true;
                continue;
            }
            if(switchDirection == true)
            {
                for (int k = s - 1; k >= 0; k --)
                {
                    if(spiralArray[k, columnCountingOrder[m]] == stopValue)
                    {
                        spiralArray[k, columnCountingOrder[m]] = startDigit;
                        startDigit += 1;
                    }
                }
                m ++;
                i ++;
                switchRowColumn = false;
                switchDirection = false;
                continue;
            }
        }
    }
    Console.WriteLine("Результат:");
    ShowMatrixInt(spiralArray);
}

//------------------------------------------------------------------------------------------------------------------------------------
//код задачи со звездочкой (не стояла задача сделать сверхбыстрый по возможности код, поэтому пошел по наипростому пути)

void taskExtra ()

{
    Console.WriteLine("************************************************************************************");
    Console.WriteLine("Программа вычисляет корень введенного числа, возвращая целую часть полученного числа");
    Console.WriteLine("************************************************************************************");
    Console.Write("Введите число из которого необходимо извлечь корень: ");
    int input = int.Parse(Console.ReadLine());
    
    // 1-й способ - перебор с инкрементом ++1
    int result = 0;
    int multiply = 0;

    Stopwatch stopWatch = new Stopwatch();
    stopWatch.Reset();

    stopWatch.Start();
    while (multiply < input)
    {
        result += 1;
        multiply = result * result;
    }
    if (multiply > input) result -= 1;
    stopWatch.Stop();
        
    Console.WriteLine($"Квадратный корень (1) = {result}");
    Console.WriteLine($"Метод перебора ticks = {stopWatch.ElapsedTicks}");
    stopWatch.Reset();

    // 2-й способ - метод Ньютона
    
    result = 1;
    int last = 0;

    stopWatch.Start();
    while (result != last)
    {
        last = result;
        result = (result + input/result) / 2;
    }
    stopWatch.Stop();
    
    Console.WriteLine($"Квадратный корень (2) = {result}");
    Console.WriteLine($"Метод Ньютона ticks = {stopWatch.ElapsedTicks}");
    stopWatch.Reset();

    // 3-й способ - метод бинарного поиска

    int left = 1;
    int right = input;
    int middle = 0;

    stopWatch.Start();
    while(left <= right)
    {
        middle = (left + right)/2;
        if (middle == input/middle) result = middle;
        if (middle < input/middle) left = middle + 1;
        else right = middle - 1;
    }
    stopWatch.Stop();

    Console.WriteLine($"Квадратный корень (3) = {result}");
    Console.WriteLine($"Метод бинарного поиска ticks = {stopWatch.ElapsedTicks}");
    stopWatch.Reset();
    


}