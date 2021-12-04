// Это остатки упражнений с Сергеем К на семинаре 29ноября
// мои задачки ниже

/* //(123/10)%10 = 12.3
//12%10 = 2
//123%10 = 3
string MyMethod(int a)
{
    int b = 0;
    if (a<100 || a>999)
    {
        return "число не трехзначное";
    }
    else
    {
        b = (a/10)%10;
        return $"{b}";
    }
}
int a = 999;
string res = MyMethod(a);
Console.WriteLine(res); */







// чтобы разблокировать любую задачку, 
// надо убрать обрамляющие её символы "/*    ...    */"





/* // Раздел: Почувствуй себя интерном*
// Задача 0. Вывести квадрат числа
//
double SquareCalc(double arg)   // Метод, возвращающий квадрат аргумента
{
    return arg * arg;
}
// основной кодоблок задачи
string userInput;
double argument = 0;
double result = 0;
Console.Write("Введите число: ");
userInput = Console.ReadLine();
argument = Convert.ToDouble(userInput);//альтернатива = double.Parse(userInput)
result = SquareCalc(argument);
Console.WriteLine($"Квадрат введённого числа равен: {result}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 1. По двум заданным числам проверять является ли первое 
// квадратом второго
//
// метод, возвращающий строку ответа, является ли первое квадратом второго
string SquareCheck(int arg1, int arg2)
{
    if (arg1 == (arg2 * arg2))
    {
        return $"{arg1} это квадрат числа {arg2}";
    }
    else
    {
        return $"{arg1} не является квадратом числа {arg2}";
    }

}
// основной кодоблок задачи
int number1 = 80;
int number2 = 9;
string result = SquareCheck(number1, number2);
Console.WriteLine(result); */





/* // Раздел: Почувствуй себя интерном*
// Задача 2. Даны два числа. Показать большее и меньшее число
//
// метод, сравнивающий числа, и возвращающий строку с описанием сравнения
string MinMaxCheck(int arg1, int arg2)
{
    if (arg1>arg2)
    {
        return $"Большее число: {arg1};   Меньшее число: {arg2}";
    }
    else
    {
        return $"Большее число: {arg2};   Меньшее число: {arg1}";
    }
}
// основной кодоблок задачи
int number1 = 15;
int number2 = 10;
string result = MinMaxCheck(number1, number2);
Console.WriteLine(result); */





/* // Раздел: Почувствуй себя интерном*
// Задача 3. По заданному номеру дня недели вывести его название
//
// метод возвращает имя дня недели
string DayNameMethod(string[] weekArray, int dayNumber)
{
    return weekArray[dayNumber - 1];    // -1 для перехода с сишарпного на человеческий
}
// основной кодоблок задачи
int weekDayNumber = 6;    // нумерация нормальная, общечеловеческая
string[] weekDayName = {"Понедельник", "Вторник", "Среда", "Четверг",
    "Пятница", "Суббота", "Воскресенье"};
string result = DayNameMethod(weekDayName, weekDayNumber);
Console.WriteLine($"День {weekDayNumber}: {result}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 4. Найти максимальное из трех чисел
//
int MaxOfThree(int arg1, int arg2, int arg3)
{
    if (arg1>arg2)
    {
        if (arg1>arg3)
        {
            return arg1;
        }
        else
        {
            return arg3;
        }
    }
    else    // arg1<=arg2
    {
        if (arg2>arg3)
        {
            return arg2;
        }
        else
        {
            return arg3;
        }
    }
}
// основной кодоблок задачи
int number1 = 26;
int number2 = 17;
int number3 = 26;
int result = MaxOfThree(number1, number2, number3);
Console.WriteLine($"Из {number1}, {number2}, {number3} максимальное = {result}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 5. Написать программу вычисления значения функции y = f(a)
// функция рекомендована - Sin. Встроенный системный метод принимает 
// аргументы в радианах, поэтому чтобы работать с человеческими единицами,
// их надо конвертить. Но в этой задачке заниматься этим не будем.
//
double MySin(double arg)
{
    return Math.Sin(arg);
}
// основной кодоблок задачи
double angle = 0.5;   // 
double result = MySin(angle);
Console.WriteLine($"Угол = {angle} радиан, его Sin = {result}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 6. Выяснить является ли число чётным
//
string OddHonest2(int arg)
{
    if (arg%2==0)
        return "чётное";
    else
        return "нечётное";
}
// основной кодоблок задачи
int Number = 35164564;
string result = String.Empty;
result = OddHonest2(Number);
Console.WriteLine($"Число {Number} {result}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 7. Показать числа от -N до N
// поскольку нет уточнений, всю логику включая печать,
// сделаем в void-методе, а передадим в него лишь начальное число.
//
void Task7method(int arg)
{
    for (int index = -arg; index <= arg; index++)
    {
        Console.Write($"{index}, ");
    }
}
// основной кодоблок задачи
int Number = 5;
Task7method(Number); */





/* // Раздел: Почувствуй себя интерном*
// Задача 8. Показать четные числа от 1 до N
//
Boolean OddHonest3(int arg)
{ return arg % 2 == 0; }
// основной кодоблок задачи
int Number = 25;
for (int index = 0; index <= Number; index++)
{
    if (OddHonest3(index))
    {
        Console.Write($"{index}, ");
    }
} */





/* // Раздел: Почувствуй себя интерном*
// Задача 9. Показать последнюю цифру трёхзначного числа
//
int LastDigitMethod(int arg)
{ return arg%10; }
// основной кодоблок задачи
int Number = 123;
int LastDigit = LastDigitMethod(Number);
Console.WriteLine($"Последняя цифра числа {Number} - {LastDigit}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 10.Показать вторую цифру трёхзначного числа
//
int SecDigMethod(int arg)
{ return (arg/10)%10; }
// основной кодоблок задачи
int Number = 123;
int SecondDigit = SecDigMethod(Number);
Console.WriteLine($"В числе {Number} вторая цифра: {SecondDigit}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
//
int MaxDigitMethod(int arg)
{
    int dig1 = arg/10;
    int dig2 = arg%10;
    if (dig1>dig2)
        return dig1;
    else
        return dig2;
}
// основной кодоблок задачи
int Number = new Random().Next(10, 100);
int MaxDigit = MaxDigitMethod(Number);
Console.WriteLine($"В числе {Number} наибольшая цифра: {MaxDigit}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 12. Удалить вторую цифру трёхзначного числа
//
int RemSecDig(int arg)
{
    int digit3 = arg % 10;
    int digit1 = arg / 100;
    return digit1 * 10 + digit3;
}
// основной кодоблок задачи
int Number = new Random().Next(100, 1000);
int NewNumber = RemSecDig(Number);
Console.WriteLine($"Исходное число {Number}, преобразованное: {NewNumber}"); */





/* // Раздел: Почувствуй себя интерном*
// Задача 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
// Оба число сгенерим путём Random().Next
//
String CheckMultiples(int arg1, int arg2)
{
    int reminder = arg1%arg2;
    if (reminder == 0)
        return $"Число {arg1} кратно {arg2}";
    else
        return $"Число {arg1} не кратно {arg2}, остаток от деления: {reminder}";
}
// основной кодоблок задачи
int number = new Random().Next(10, 100);
int divider = new Random().Next(1, 10);
Console.WriteLine(CheckMultiples(number, divider)); */





/* // Раздел: Почувствуй себя интерном*
// Задача 14. Найти третью цифру числа или сообщить, что её нет
// Я понял и принял это так, что есть 3х и 2х значные числа,
// так и задам в генераторе Random/Next
//
string Task14method(int arg)
{
    if (arg<100)
        return $"число {arg} двухзначное, третьей цифры нет";
    else
    {
        return $"У числа {arg} третья цифра: {arg%10}";
    }
}
// основной кодоблок задачи
int number = new Random().Next(10, 1000);
Console.WriteLine(Task14method(number)); */
