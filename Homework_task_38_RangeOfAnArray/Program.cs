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
    int max = arr[0];
    int min = arr[0];

    for (int i = 0; i < n; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    return max-min;
}

PrintArray(n);
Console.WriteLine($"\nРазница между максимальным и минимальным значениями в данном массиве равна {FindRange(array)}");