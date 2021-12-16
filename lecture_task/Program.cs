//==== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы "к" заменить большими "К",
// а большие "С" заменить маленькими "с".
// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012345
// s[3] // это "r"

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result + $"{newValue}";
        else result + $"";
    }

    return result;
}













/* // показать последнюю цифру 3 х значного числа

//(123/10)%10 = 12.3
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