/*      Задача
формировать случайным образом целочисленный массив A
из натуральных двузначных чисел.
Создать на его основе масcив B, отбрасывая те, которые
1  нарушают порядок возрастания
2  больше среднего арифметического элементов A
3  чётные        */

/*      Подзадача 1. Задать массив А
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

// метод печати массива
void PrintIntArrToConsole(int[] array)
{
    Console.WriteLine("");
    for (int index = 0; index < array.Length; index++)
    {
        Console.Write($"{array[index]}; ");
    }
}

// метод формирования второго массива возрастающими элементами
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

// метод вычисления среднего арифметического
/* double AverageMean(int[] array)
{
    double sum=0;
    for (int index = 0; index < array.Length; index++)
    {
        sum=sum+array[index];
    }
    return sum/array.Length;
} */

// метод формирования второго массива "вышесредними" элементами
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


// метод формирования второго массива нечётными элементами
// Создать на его основе масcив B, отбрасывая те, которые чётные
int OddHonest(int[] arrayA, int[] arrayB)
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
}



//основной кодоблок о чётности
int[] arrA = new int[25];
int[] arrB = new int[arrA.Length];
int sizeNewArray = 0;
FillSourceArray(arrA, 10, 99);
PrintIntArrToConsole(arrA);
sizeNewArray = OddHonest(arrA, arrB);
Console.WriteLine($"SizeOfB={sizeNewArray}");
PrintIntArrToConsole(arrB);
Array.Resize(ref arrB, sizeNewArray);   // ресайз/обрезка нового массива
PrintIntArrToConsole(arrB);



//основной кодоблок о среднем арифметическом
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


//основной кодоблок о возрастании элементов
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










/* double qq = 1 % 2;
Console.WriteLine(qq);
qq = 2 % 2;
Console.WriteLine(qq);
qq = 3 % 2;
Console.WriteLine(qq);
qq = 10 % 6;
Console.WriteLine(qq); */




