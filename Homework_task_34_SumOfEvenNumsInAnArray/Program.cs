// Задача 34: 
// Задайте массив 
// заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Какого размера вы хотите массив? ");
bool userEnter = int.TryParse(Console.ReadLine(), out int n);
int[] array = new int[n];

int count = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write($"{array[i]}, ");
    if (array[i]%2 == 0) count ++;
}

Console.WriteLine($"\nКоличество четных чисел в данном массиве равно {count}");