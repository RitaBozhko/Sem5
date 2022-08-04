// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Какого размера вы хотите массив? ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

void PrintArray(int n)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(1,100);
        Console.Write($"{array[i]}, ");         
    }
}

int FindRange(int[] arr)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < n; i++)
    {
        if (array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    return max-min;
}

PrintArray(n);
Console.WriteLine($"\nРазница между максимальным и минимальным значениями в данном массиве равна {FindRange(array)}");