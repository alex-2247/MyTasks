
// Из лекции 2нояб "Функции продолжение" курса "Знакомство с ЯП"
//
/* //==== Работа с текстом
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
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + text[i];
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'С', 'с');
Console.WriteLine(newText); */





// сортировка массива методом выбора
/* int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */
//
// д/з: адаптировать код сортировки массива так, чтоб вначале были большие
/* void FillSourceArray(int[] array, int minValue, int maxValue) {
    for (int index = 0; index < array.Length; index++)
        array[index] = new Random().Next(minValue, maxValue); }
void PrintArray(int[] array) {
    for (int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine(); }
void SelectionSort(int[] array) {
    for (int i = 0; i < array.Length - 1; i++) {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] > array[maxPosition]) maxPosition = j;
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary; } }
// Основной кодоблок
int[] arr = new int[10];
FillSourceArray(arr, 1, 10);
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */
