// Задача 36: 
// Задайте одномерный массив, 
// заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Какого размера вы хотите массив? ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int sum = 0;
for (int i = 0; i < n; i++)
{
    array[i] = new Random().Next(-99,100);
    Console.Write($"{array[i]}, ");
    if (i%2 == 1) sum += array[i];
}

Console.WriteLine($"\nСумма элементов на нечётных позициях в данном массиве равна {sum}");