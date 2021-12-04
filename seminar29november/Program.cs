// показать последнюю цифру 3 х значного числа

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
Console.WriteLine(res);