/* // Раздел: Почувствуй себя сеньором*
// Задача 31. Задать массив из 8 элементов и вывести их на экран
// ..."задать" - это значит, не заполнять? Ладно, было бы сказано.
//
// метод печати массива в консоль
void PrintIntArrToConsole(int[] argArray)
{
    // вывод первого элемента отдельно, для блокировки замыкающего ";"
    Console.Write($"{argArray[0]}");
    for (int index = 1; index < argArray.Length; index++)
    {
        Console.Write($"; {argArray[index]}");
    }
    Console.WriteLine("");
}
// основной кодоблок задачи
int arrLength = 8;
int[] myArr = new int[arrLength];
PrintIntArrToConsole(myArr); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 32. Задать массив из 8 элементов, заполненных нулями 
// и единицами вывести их на экран
//
void FillIntArray(int[] argArray, int minValue, int maxValue)
{
    for (int index = 0; index < argArray.Length; index++)
    {
        argArray[index] = new Random().Next(minValue, maxValue);
    }
}
// основной кодоблок задачи
int arrLength = 8;
int[] myArr = new int[arrLength];
FillIntArray(myArr, 0, 2);
PrintIntArrToConsole(myArr); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 33. Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива.
// Блин, ну и постановщики задач... Где отрицательные в [0,9] ???
// Придётся менять условие задачи под обеспечение логики. ==> [-9,9]
//
string PosNegSum(int[] argArray)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (argArray[i] < 0)
            negSum = negSum + argArray[i];
        else
            posSum = posSum + argArray[i];
    }
    return $"Сумма элементов, положительных: {posSum};  отрицательных: {negSum}";
}
// основной кодоблок задачи
int arrLength = 12;
int[] myArr = new int[arrLength];
FillIntArray(myArr, -9, 10);
PrintIntArrToConsole(myArr);
Console.WriteLine(PosNegSum(myArr)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 34. Написать программу замену элементов массива на противоположные
// Противоположные это как? Другого знака? Ну ок.
//
void AnotherSign(int[] argArray)
{
    for (int i = 0; i < argArray.Length; i++)
        argArray[i] = argArray[i] * -1;
}
// основной кодоблок задачи
int arrLength = 15;
int[] myArr = new int[arrLength];
FillIntArray(myArr, -9, 10);
PrintIntArrToConsole(myArr);
AnotherSign(myArr);
PrintIntArrToConsole(myArr); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 35. Определить, присутствует ли в заданном массиве, некоторое число
//
string FindInArray(int[] argArray, int argNumber)
{
    for (int i = 0; i < argArray.Length; i++)
    {
        if (argArray[i]==argNumber)
            return $"Искомое число {argNumber} присутствует в приведённом массиве на позиции {i+1}";
    }
    return $"Искомое число {argNumber} отсутствует в приведённом массиве";
}
// основной кодоблок задачи
int arrLength = 25;
int findNumber = new Random().Next(1, 100);
int[] myArr = new int[arrLength];
FillIntArray(myArr, 1, 100);
PrintIntArrToConsole(myArr);
Console.WriteLine(FindInArray(myArr, findNumber)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 36. Задать массив, заполнить случайными положительными трёхзначными
// числами. Показать количество нечетных\четных чисел
//
string OddHoneyDisplay(int[] argArray)
{
    int oddTemp = 0;
    int honeyTemp = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (argArray[i] % 2 == 0)   // если оно чётное
            honeyTemp++;
        else
            oddTemp++;
    }
    return $"В приведённом массиве {honeyTemp} чётных чисел, нечётных - {oddTemp}.";
}
// основной кодоблок задачи
int arrLength = 25;
int[] myArr = new int[arrLength];
FillIntArray(myArr, 100, 1000);
PrintIntArrToConsole(myArr);
Console.WriteLine(OddHoneyDisplay(myArr)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 37. В одномерном массиве из 123 чисел найти количество элементов
// из отрезка [10,99]
// Хм... Постановка задач... Ладно, берем исходное из [1,99]
//
string IntervalCount(int[] argArray, int minVal, int maxVal)
{
    int countVal = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (minVal <= argArray[i] && argArray[i] <= maxVal)
            countVal++;
    }
    return $"В массиве {countVal} чисел из интервала [10,99]";
}
// основной кодоблок задачи
int arrLength = 123;
int[] myArr = new int[arrLength];
FillIntArray(myArr, 1, 100);
PrintIntArrToConsole(myArr);
Console.WriteLine(IntervalCount(myArr, 10, 99)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
//
string OddPositionSum(int[] argArray)
{
    int tmpSum = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (i % 2 != 0)     // нечётный индекс, первый (i=0) это чётный
            tmpSum = tmpSum + argArray[i];
    }
    return $"Сумма чисел на нечётной позиции = {tmpSum}.";
}
// основной кодоблок задачи
int arrLength = 10;
int[] myArr = new int[arrLength];
FillIntArray(myArr, 1, 10);
PrintIntArrToConsole(myArr);
Console.WriteLine(OddPositionSum(myArr)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 39. Найти произведение пар чисел в одномерном массиве. Парой
// считаем первый и последний элемент, второй и предпоследний и т.д.
// ...опять нечеткая постановка. Наверно "произведениЯ"?
// то есть последовательность произведений всех имеющихся пар.
// В случае нечетного числа элементов, один средний остается без пары.
//
string PareMultiples(int[] argArray)
{
    string retVal = "";
    int maxIndex = argArray.Length-1;
    for (int minIndex = 0; minIndex < maxIndex; minIndex++)
    {
        retVal = retVal + $"{argArray[minIndex]}*{argArray[maxIndex]}=";
        retVal = retVal + $"{argArray[minIndex]*argArray[maxIndex]},  ";
        maxIndex--;
    }
    return retVal;
}
// основной кодоблок задачи
int arrLength = 10;
int[] myArr = new int[arrLength];
FillIntArray(myArr, 1, 10);
PrintIntArrToConsole(myArr);
Console.WriteLine(PareMultiples(myArr)); */





/* // Раздел: Почувствуй себя сеньором*
// Задача 40. В Указанном массиве вещественных чисел найдите разницу между
// максимальным и минимальным элементом
// Здесь будет 3 метода, ибо стандартные заполнения и печати не годятся
//
void FillDoubleArray(double[] argArray, double minValue, double maxValue)
{
    maxValue--;
    for (int index = 0; index < argArray.Length; index++)
    {
        argArray[index] = new Random().NextDouble() * maxValue / minValue + minValue;
    }
}
void PrintDoubleArrToConsole(double[] argArray)
{
    // вывод первого элемента отдельно, для блокировки замыкающего ";"
    Console.Write($"{argArray[0]}");
    for (int index = 1; index < argArray.Length; index++)
    {
        Console.Write($"; {argArray[index]}");
    }
    Console.WriteLine("");
}
string MinMaxDifference(double[] argArray, double minValue)
{
    double maxValue = 0;
    for (int i = 0; i < argArray.Length; i++)
    {
        if (maxValue < argArray[i])
            maxValue = argArray[i];
        if (argArray[i] < minValue)
            minValue = argArray[i];
    }
    return $"Наименьшее число {minValue},  наибольшее {maxValue},  разница между ними {maxValue - minValue}";
}
// основной кодоблок задачи
int arrLength = 10;
double[] myArr = new double[arrLength];
FillDoubleArray(myArr, 1, 10);
PrintDoubleArrToConsole(myArr);
Console.WriteLine(MinMaxDifference(myArr, 10)); */
