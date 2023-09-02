// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

string[] Input(string massage)
{
    Console.Write($"{massage} ");
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
    for (int i = 0; i < data.Length; i++)
    {
        if (data[i].Length <= 3)
            outputArray[i] = data[i];
    }
    return outputArray;
}