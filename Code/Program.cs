/*
Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клаиватуры, либо задать на старте выполнения 
алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
массивами.
*/

Console.Clear();

Console.Write("Введите количество элементов в исходном массиве: ");
int num = int.Parse(Console.ReadLine()!);

string[] inArray = GetArray(num);

Console.Write("Исходный массив: ");
PrintArray(inArray);

Console.WriteLine();
Console.Write("Максимальное количество символов элементов в новом массиве: ");
int leng = int.Parse(Console.ReadLine()!);

string[] outArray = ArrayFromInArray(inArray);
Console.Write($"Массив из элементов исходного массива, длина которых не превышает {leng} символа(ов): ");
PrintArray(outArray);

string[] GetArray(int n)
{
    string[] result = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1}-й элемент: ");
        string el = Convert.ToString(Console.ReadLine()!);
        result[i] = el;
    }
    return result;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] ArrayFromInArray(string[] inArray)
{
    string[] result = new string[inArray.Length];
    int count = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length <= leng)
        {
            result[count] = inArray[i];
            count++;
        }
    }
    return result;
}