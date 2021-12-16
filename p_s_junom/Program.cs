// Раздел: Почувствуй себя джуном*
// 





/* // Код Марии Липиной 
Console.WriteLine("18. Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y");

bool logic(bool x, bool y)
{
    return !(x || y) == (!x && !y); // Без скобок == выполняется до &&
}

// Write("Х - true или false? ");
// bool X = ToBoolean(ReadLine());
// Write("Y - true или false? ");
// bool Y = ToBoolean(ReadLine());
// WriteLine(logic(X, Y));
//WriteLine();

Console.WriteLine("Таблица истинности"); //первая попытка, которая хороша чисто тем, что она есть.

for (int i = 0; i < 2; i++)
{
    if (i == 0)
    {
       Console.WriteLine("При X - true, начиная с Y - true");
       Console.WriteLine($"{logic(true, true)} {logic(true, false)}"); 
    }
    else
    {
        Console.WriteLine("При X - false, начиная с Y - true");
        Console.WriteLine($"{logic(false, true)} {logic(false, false)}");;
    }
} */













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
