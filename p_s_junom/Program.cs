/* // Задача 12. Удалить вторую цифру трёхзначного числа
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










/* // Раздел: Почувствуй себя джуном*
// 15. Дано число. Проверить кратно ли оно 7 и 23
//
string CheckMultiples15(int num, int div)
{
    if (num % div == 0)
        return $"кратно {div}";
    else
        return $"НЕкратно {div}";
}
// основной кодоблок задачи
int number = new Random().Next(10, 100);
int divider1 = 7;
int divider2 = 23;
string output = $"Проверяемое число {number}:  "
        + $"{CheckMultiples15(number, divider1)};   "
        + $"{CheckMultiples15(number, divider2)}";
Console.WriteLine(output); */





/* // Раздел: Почувствуй себя джуном*
// 16. Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным.
//
string CheckDayoff(int day)
{
    if (day==6||day==7)
        return "выходной";
    else
        return "рабочий";
}
// основной кодоблок задачи
int weekDay = new Random().Next(1, 8);  // maxvalue-1
Console.WriteLine($"День недели {weekDay} - {CheckDayoff(weekDay)}"); */





/* // Раздел: Почувствуй себя джуном*
// 17. По двум заданным числам проверять является ли одно квадратом другого
//
string SquareCheck(int maxN, int minN)
{
    if (maxN == (minN * minN))
        return $"Число {maxN} это квадрат числа {minN}";
    else
        return $"Число {maxN} не является квадратом числа {minN}";
}
// основной кодоблок задачи
int maxNumber = new Random().Next(16, 82);
int minNumber = new Random().Next(4, 10);
Console.WriteLine(SquareCheck(maxNumber, minNumber)); */





/* // Раздел: Почувствуй себя джуном*
// 18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
// "∨" - дизъюнкция, логическое сложение
// "∧" - конъюнкция, логическое умножение
// Данная задача оперирует ТОЛЬКО логическим типом переменных, 
// аргументов, выражений и результатов.
// В методе пропишем проверяемое выражение, подадим ему на вход все 
// комбинации значений аргументов, и посмотрим на результаты.
//
bool CheckBoolTerm(bool argX, bool argY)
{
    return !(argX || argY) == (!argX && !argY);
}
string CreateResult(bool arg1, bool arg2)
{
    return $"X={arg1}, Y={arg2},   результат={CheckBoolTerm(arg1, arg2)}";
}
// Основной кодоблок
Console.WriteLine(CreateResult(true, true)); 
Console.WriteLine(CreateResult(true, false)); 
Console.WriteLine(CreateResult(false, true)); 
Console.WriteLine(CreateResult(false, false)); */





/* // Раздел: Почувствуй себя джуном*
// 19. Определить номер четверти плоскости, в которой находится      2 1
// точка с координатами Х и У, причем X≠0 и Y≠0, номера четвертей:   3 4
//
string DekartKvadrant(int argX, int argY)
{
    if (argX > 0 && argY > 0) return "I";
    if (argX < 0 && argY > 0) return "II";
    if (argX < 0 && argY < 0) return "III";
    if (argX > 0 && argY < 0) return "IV";
    if (argX == 0 && argY == 0) return "??";
    return "Што-то пошло не так... :-(("; // без этой строки не работает
}
// основной кодоблок задачи
int x = 0;
int y = 0;
string KvadrantNumber = "";
while (true)    // цикл для отсечения нулевых координат
{
    x = new Random().Next(-19, 20);
    y = new Random().Next(-19, 20);
    if (x != 0 && y != 0)
    {
        KvadrantNumber = DekartKvadrant(x, y);
        break;
    }
}
Console.WriteLine(
    $"Для точки с координатами X={x} и Y={y} номер четверти: {KvadrantNumber}"); */





/* // Раздел: Почувствуй себя джуном*
// 20. Задать номер четверти, показать диапазоны для возможных координат
//
string QuadrantScope(int quadrant)
{
    if (quadrant==1)
        return $"Четверть I:  X=(0, +oo)  Y=(0, +oo)";
    if (quadrant==2)
        return $"Четверть II:  X=(-oo, 0)  Y=(0, +oo)";
    if (quadrant==3)
        return $"Четверть III:  X=(-oo, 0)  Y=(-oo, 0)";
    if (quadrant==4)
        return $"Четверть IV:  X=(0, +oo)  Y=(-oo, 0)";
    return "Што-то пошло не так... :-(("; // без этой строки не работает
}
// основной кодоблок задачи
int quadrant = new Random().Next(1, 5);
Console.WriteLine(QuadrantScope(quadrant)); */





/* // Раздел: Почувствуй себя джуном*
// 21. Программа проверяет пятизначное число на палиндромом.
string CheckPalindrom(int arg)
{
    int dig5 = arg % 10;
    int tmpVal = arg / 10;  // осталось 4 цифры
    int dig4 = tmpVal % 10;
    tmpVal = tmpVal / 10;  // осталось 3 цифры
    //int dig3 = tmpVal % 10; // эта переменная не нужна
    tmpVal = tmpVal / 10;  // осталось 2 цифры
    int dig2 = tmpVal % 10;
    int dig1 = tmpVal / 10;
    //Console.WriteLine($"{dig1} {dig2} * {dig4} {dig5}");
    if (dig1 == dig5 && dig2 == dig4) return "- ПАЛИНДРОМ !";
    else return "не является палиндромом.";
}
// основной кодоблок задачи
int number = new Random().Next(10000, 100000);
//number=12521;
Console.WriteLine($"Число {number} {CheckPalindrom(number)}"); */





/* // Раздел: Почувствуй себя джуном*
// 22. Найти расстояние между точками в пространстве 2D/3D
double Distance2d(int xA, int yA, int xB, int yB)
{
    return
    Math.Sqrt((xB - xA) * (xB - xA) + (yB - yA) * (yB - yA));
}
double Distance3d(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt((xB - xA) * (xB - xA) 
        + (yB - yA) * (yB - yA) + (zB - zA) * (zB - zA));
}
// основной кодоблок задачи
int xA = new Random().Next(0, 100);
int yA = new Random().Next(0, 100);
int zA = new Random().Next(0, 100);
int xB = new Random().Next(0, 100);
int yB = new Random().Next(0, 100);
int zB = new Random().Next(0, 100);
Console.WriteLine(
    $"Расстояние между точками ({xA},{yA}) и ({xB},{yB}) на плоскости = {Distance2d(xA, yA, xB, yB)}");
Console.WriteLine(
    $"Расстояние между точками ({xA},{yA},{zA}) и ({xB},{yB},{zB}) в пространстве = {Distance3d(xA, yA, zA, xB, yB, zB)}"); */
