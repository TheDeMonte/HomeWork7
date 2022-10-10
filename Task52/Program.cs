// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.WriteLine("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] number = new int[rows, column];
FillArrayRandom(number);

for (int j = 0; j < number.GetLength(1); j++)
{
    double average = default;
    for (int i = 0; i < number.GetLength(0); i++)
    {
        average += number[i, j];
    }
    average /= rows;
    average = Math.Round(average, 2, MidpointRounding.ToZero);
    Console.WriteLine($"Cреднее арифметическое элементов столбца {j + 1} = {average}");
}
Console.WriteLine();
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 25);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}


PrintArray(number);
