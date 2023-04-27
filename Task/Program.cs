// Задача
// Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Решение

string[] symbols1 = new string[5] { "157", "2", "hello", "world", ";)" };
string[] symbols2 = new string[symbols1.Length];


void FillArray(string[] symbols1, string[] symbols2)
{
    int count = 0;
    for (int i = 0; i < symbols1.Length; i++)
    {
        if (symbols1[i].Length <= 3)
        {
            symbols2[count] = symbols1[i];
            count++;
        }
    }
}

void PrintArray(string[] symbols)
{
    for (int i = 0; i < symbols.Length; i++)
    {
        Console.Write($"{symbols[i]} ");
    }
    Console.WriteLine();
}

FillArray(symbols1, symbols2);
PrintArray(symbols2);
