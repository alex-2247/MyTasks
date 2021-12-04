// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// первый опыт работы с рекурсией, на семинаре 2дек в зале с Ольгой Вериной



string Numbers(int x) => x>=1?$"{x} {Numbers(x-1)}":string.Empty; 
    /* if (x >= 1)
    {

        return $"{x} {Numbers(x-1)}";
    }
    else
        return string.Empty; */
//}  
Console.WriteLine(Numbers(8)); 

// 68. Показать натуральные числа от M до N, N и M заданы




/*
int m = 5;
int n = 15;

int Numbers(int arg1, arg2)
{
    if (arg1<=arg2)
    {
        WriteLine()
    }
}
*/


//WriteLine(Numbers(m, n));