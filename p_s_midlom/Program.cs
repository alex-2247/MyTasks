/* // Раздел: Почувствуй себя миддлом*
// Задача 23. Показать таблицу квадратов чисел от 1 до N
// Для начала надо определить, что значит показать таблицу квадратов
// Моё понимание такое: таблица из двух столбцов, числа и его квадрата
//
void PrintQuadTable(int length)
{
    int tmpNum;
    Console.WriteLine($"число   квадрат");
    for (int i = 0; i < length; i++)
    {
        tmpNum = i + 1;
        Console.WriteLine($"   {tmpNum}   {tmpNum*tmpNum}");
    }
}
// основной кодоблок задачи
int number = 15;
PrintQuadTable(number); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 24. Найти кубы чисел от 1 до N
// "Найти" - и чо? Принимаю, что еще и показать.
// Для этого использую функционал предыдущей задачки.
//
void PrintCubeTable(int length)
{
    int tmpNum;
    Console.WriteLine($"число   куб");
    for (int i = 0; i < length; i++)
    {
        tmpNum = i + 1;
        Console.WriteLine($"   {tmpNum}   {tmpNum * tmpNum * tmpNum}");
    }
}
// основной кодоблок задачи
int number = new Random().Next(10, 26);
PrintCubeTable(number); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 25. Найти сумму чисел от 1 до А
//
int SumMethod(int border)
{
    int tmpSum = 0;
    for (int i = 1; i <= border; i++)
    {
        tmpSum = tmpSum + i;
    }
    return tmpSum;
}
// основной кодоблок задачи
int border = 5;
Console.WriteLine($"Сумма чисел от 1 до {border}   = {SumMethod(border)}"); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 26. Возведите число А в натуральную степень B используя цикл
// (ну и показать, наверное? Постановка задач lvl-80)
//
int DegreeMethod(int argA, int argB)
{
    int tmpVal = 1;
    for (int i = 1; i <= argB; i++)
    {
        tmpVal = tmpVal * argA;
    }
    return tmpVal;
}
// основной кодоблок задачи
int a = 2;
int b = 10;
Console.WriteLine($"Число {a} в степени {b}   = {DegreeMethod(a,b)}"); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 27. Определить количество цифр в числе
// Для упрощения решения примем, что число натуральное
//
int AmountOfDigit(int arg)
{
    int tmpVal = 0;
    int minDecade = 1;
    int maxDecade = 1;
    while (true)
    {
        maxDecade = minDecade * 10;
        tmpVal++;
        if (arg >= minDecade && arg < maxDecade)
        {
            return tmpVal;
        }
        minDecade = minDecade * 10;
    }
} */
/* // основной кодоблок задачи
int number = 456553234;
Console.WriteLine($"В числе {number} количество цифр   = {AmountOfDigit(number)}"); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 28. Подсчитать сумму цифр в числе
// Задачка несколько сложней чем соседние
// Для определения числа цифр используем предыдущую задачу
// По прежнему считаем, что исходное число натуральное
//
int SumOfDigit(int arg, int length)
{
    int tmpDig;
    int sumDig = 0;
    for (int i = 0; i < length; i++)
    {
        tmpDig = arg % 10;
        arg = arg / 10;
        sumDig = sumDig + tmpDig;
        //Console.WriteLine($"шаг {i+1}, остаток {arg}  цифра {tmpDig}  сумма {sumDig}");
    }
    return sumDig;
}
// основной кодоблок задачи
int number = 123456789;
int amountDig = AmountOfDigit(number);
Console.Write($"В числе {number} количество цифр  = {amountDig}");
Console.WriteLine($", сумма цифр  = {SumOfDigit(number, amountDig)}"); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 29. Написать программу вычисления произведения чисел от 1 до N
//
int MultMethod(int arg) // это факториал, и возможно он есть в библиотеках, но сделаем как в условии задачи
{
    int tmpVal = 1;
    for (int i = 1; i <= arg; i++)
    {
        tmpVal = tmpVal * i;
    }
    return tmpVal;
}
// основной кодоблок задачи
int number = 5;
Console.WriteLine($"Произведение чисел от 1 до {number}  = {MultMethod(number)}"); */





/* // Раздел: Почувствуй себя миддлом*
// Задача 30. Показать кубы чисел, заканчивающихся на четную цифру
// Вообще-то если число заканчивается на чётную цифру, оно и есть чётное
//
void HoneyCube(int length)
{
    for (int i = 1; i <= length; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"Куб числа {i}  = {i*i*i}");
        }
    }
}
// основной кодоблок задачи
int number = 15;
HoneyCube(number); */
