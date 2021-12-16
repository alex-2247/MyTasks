


















/* //Написать программу масштабирования фигуры
//Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
//например: "(0,0) (2,0) (2,2) (0,2)"
//коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
//В результате показать координаты, которые получатся.
//при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" */
/* string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
*/
// string s = "qwerty"
//             012345
// s[3] // это "r"
/*
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
*/









// задачка копирования массива
/*string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        att[i] = new Random().Next()
    }
} */

string[] CopyArray(string[] arr1, string[] arr2)
{
    for (int i = 0; i < arr1.Length; i++)
    {
        arr2[i] = arr1[i];
    }
    return arr2;
}
//
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

string[] array1 = {"qwe", "rty","uio","asd","fgh"};
string[] array2 = new string[5];
PrintArray(array1);
array2 = CopyArray(array1, array2);
Console.WriteLine();
PrintArray(array2);










// первый опыт работы с рекурсией, на семинаре 2дек в зале с Ольгой Вериной
// и помощью Сергея Каменецкого
//
//string Numbers(int x) => x>=1?$"{x} {Numbers(x-1)}":string.Empty; 
    /* if (x >= 1)
    {

        return $"{x} {Numbers(x-1)}";
    }
    else
        return string.Empty; */
//}  
//Console.WriteLine(Numbers(8)); 





// 68. Показать натуральные числа от M до N, N и M заданы
/* string MyMethod(int arg1, int arg2)
{
    if (arg2>=arg1)
    {
        return $"{MyMethod(arg1, arg2-1)} {arg2}";
    }
    else
    {
        return string.Empty;
    }
}
//основной кодоблок задачи
int m = 5;
int n = 25;
Console.WriteLine(MyMethod(m, n)); */




/*
// 69.Найти сумму элементов от M до N, N и M заданы
int Task69method(int m, int n)
{
    if (m<n)
    {
        Console.WriteLine($"Before {m}");
        return m + Task69method(m+1, n);
    }
    else
    {
        Console.WriteLine($"проход else return {n}");
        return n;
    }
}
//основной кодоблок задачи
int m = 1;
int n = 5;
Console.WriteLine($"конец {Task69method(m, n)}");
//Раскрытие погружений в уровни стека, на примере m=1, n=5
//Работа строки   ' return m + Task69method(m+1, n); '
//, вызываем ее "извне", и далее она сама себя вызывает:
//  1 + {снизу 14} = 15;   уходим с этим результат вовне, "наверх"
//   (1+1)=2 + {снизу 12} = 14
//      (2+1)=3 + {снизу 9} = 12
//          (3+1)=4 + {снизу 5} = 9
//              (5 из Else)
// итоговый результат наверху, в конце, =15, как и должно быть

*/













