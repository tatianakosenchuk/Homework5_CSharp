/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int[] GetArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine() ?? "");
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

(int, int) DiffMaxMin(int[] array)
{
    int Min = array[0]; int Max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > Max) Max = array[i];
        if (array[i] < Min) Min = array[i];
    }
    return (Max, Min);
}


int[] array = GetArray(5);
(int Maximal, int Minimal) = DiffMaxMin(array);
PrintArray(array);
Console.Write($"-> {Maximal - Minimal}");
Console.WriteLine();
