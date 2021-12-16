/* Группа Dev1.     Задача
формировать случайным образом целочисленный массив A
из натуральных двузначных чисел.
Создать на его основе масcив B, отбрасывая те, которые
1  нарушают порядок возрастания
2  больше среднего арифметического элементов A
3  чётные */

/* Группа Dev2.     Задача
Имеется числовой массив A заполненный числами из отрезка 
[minValue; maxValue]. Создать на его основе масив B, отбрасывая те, 
которые нарушают порядок
1. возрастания
2. элементы, больше 8
3. знакочередования */



/*      (Группа Dev1) Подзадача 1. Задать массив А
Длину массива возьмем 25 элементов. Это достаточно много чтоб поиграться,
но не слишком, чтоб заипаться.      */
void FillSourceArray(int[] array, int minValue, int maxValue)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(minValue, maxValue);
        //Console.Write($"i={index}:{array[index]}; ");
    }
}

// (Группа Dev1) метод печати массива
void PrintIntArrToConsole(int[] array)
{
    Console.WriteLine("");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]}; ");
    }
}

// (Группа Dev1) метод формирования второго массива возрастающими элементами
/* int IncreaseElements(int[] arrayA, int[] arrayB)
{
    int oldElement = 0;
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if (arrayA[indexA] > oldElement)    //текущий больше предыдущего
        {
            arrayB[indexB] = arrayA[indexA];
            oldElement = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
} */

// (Группа Dev1) метод вычисления среднего арифметического
/* double AverageMean(int[] array)
{
    double sum=0;
    for (int index = 0; index < array.Length; index++)
    {
        sum=sum+array[index];
    }
    return sum/array.Length;
} */

// (Группа Dev1) метод формирования второго массива "вышесредними" элементами
// 2  больше среднего арифметического элементов A
/* int OverAverage(int[] arrayA, int[] arrayB, double borderValue)
{
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if (arrayA[indexA] > borderValue)    //текущий больше Ср/Арифм
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
} */


// (Группа Dev1) метод формирования второго массива нечётными элементами
// Создать на его основе масcив B, отбрасывая те, которые чётные
/* int OddHonest(int[] arrayA, int[] arrayB)
{
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if ((arrayA[indexA] % 2) != 0)    //текущий нечётный
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
} */



// (Группа Dev2) метод формирования второго массива элементами, больше 8
/* int OverSomeValue(int[] arrayA, int[] arrayB, int bordVal)
{
    int indexB = 0;
    for (int indexA = 0; indexA < arrayA.Length; indexA++)
    {
        if (arrayA[indexA] <= bordVal) // текущий не больше граничного значения
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
    }
    return indexB;
} */



// (Группа Dev2) метод формирования 2-го массива знакопеременными элементами
/* int SignAlternation(int[] arrayA, int[] arrayB)
{
    arrayB[0] = arrayA[0];  // первый элемент включаем без условий
    int indexB = 1;
    int oldVal = arrayA[0];
    for (int indexA = 0 + 1; indexA < arrayA.Length; indexA++)
    {
        if ( (oldVal<0 && arrayA[indexA]>=0) ||
            (oldVal>=0 && arrayA[indexA]<0) )    
            //текущий с предыдущим разного знака
        {
            arrayB[indexB] = arrayA[indexA];
            indexB++;
        }
        oldVal = arrayA[indexA];
    }
    return indexB;
} */



// (Группа Dev1) основной кодоблок о чётности
/* int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
int sizeNewArray = 0;
FillSourceArray(arrA, 10, 99);
PrintIntArrToConsole(arrA);
sizeNewArray = OddHonest(arrA, arrB);
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB); */



// (Группа Dev1) основной кодоблок о среднем арифметическом
/* int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
int sizeNewArray = 0;
double sredArif=0;
FillSourceArray(arrA, 10, 99);
PrintIntArrToConsole(arrA);
sredArif=AverageMean(arrA);     // метод вычисл сред/арифм
Console.WriteLine($"СредАрифм={sredArif}");
sizeNewArray = OverAverage(arrA, arrB, sredArif);   // метод формир 2го массива
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB); */


// (Группа Dev1 и Dev2) основной кодоблок о возрастании элементов
/* int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
int sizeNewArray = 0;
FillSourceArray(arrA, 10, 99);
PrintIntArrToConsole(arrA);
sizeNewArray = IncreaseElements(arrA, arrB);
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB); */



// (Группа Dev2) основной кодоблок об элеменах, больших 8
/* int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
int borderValue = 8;
int sizeNewArray = 0;
FillSourceArray(arrA, 1, 20);
PrintIntArrToConsole(arrA);
sizeNewArray = OverSomeValue(arrA, arrB, borderValue);
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB); */



// (Группа Dev2) основной кодоблок о знакочередовании
/* int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
//int borderValue = 8;
int sizeNewArray = 0;
FillSourceArray(arrA, -99, 100);
PrintIntArrToConsole(arrA);
sizeNewArray = SignAlternation(arrA, arrB);
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB); */
