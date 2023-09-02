// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

using System.Text;

string[] Input(string massage)
{
    Console.Write($"{massage} ");
    Console.InputEncoding = System.Text.Encoding.GetEncoding("utf-16");
    string[] input = Console.ReadLine()!.Split(new char[] { ' ', ',' });
    return input;
}

string[] Search(string[] data)
{
    int count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= 3)
            count++;
    }
    string[] outputArray = new string[count];
    count = 0;
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= 3)
        {
            outputArray[count] = data[i];
            count++;
        }
    }
    return outputArray;
}

void PrintArray(string massage, string[] inputArray)
{

    Console.Write($"{massage} ");
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i == inputArray.Length - 1)
            Console.Write($"{inputArray[i]}");
        else
            Console.Write($"{inputArray[i]}, ");
    }
}


string[] inputArray = Input("Введите строки через запятую или пробел:");
if (inputArray.Length == 1 && inputArray[0] == "")
{
    Console.Write("Исходный массив пуст");
}
else
{
    string[] searchArray = Search(inputArray);
    PrintArray("Исходный массив строк: ", inputArray);
    Console.WriteLine();
    if (searchArray.Length == 0)
        Console.Write("Исходный массив не содержит слов с длиной менее трех символов");
    else
        PrintArray("Результат обработки: ", searchArray);
}

