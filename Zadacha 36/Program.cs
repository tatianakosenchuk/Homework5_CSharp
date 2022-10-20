/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int Getnumber(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}

int[] GetArray(int length)
{
    int[] array = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
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

void GetSumOfEven(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    Console.Write($"-> {summ}");
    Console.WriteLine();
}

int length = Getnumber("Введите размерность массива");
int[] array = GetArray(length);
PrintArray(array);
GetSumOfEven(array);

