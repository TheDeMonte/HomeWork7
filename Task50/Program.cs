// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет
Console.WriteLine("Введите номер строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[5, 5];
void Search(int rows, int column, object search)
{
    if (rows > arr.GetLength(0) || column > arr.GetLength(1))
        Console.WriteLine("Такого элемента нет");
    else
        search = arr.GetValue(rows,column);
        Console.WriteLine($"В строке {rows} и столбце {column} находится элеменет = {search}");

}
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100) / 10;
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

FillArrayRandom(arr);
PrintArray(arr);
Search(rows, column, arr);

