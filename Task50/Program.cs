/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
позиция i = 4, j = 2 -> такой позиции нет
позиция i = 1, j = 0 -> 5 */


Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = GetArray (rows,columns, 0, 30);
PrintArray(NewArray);

Console.WriteLine("Введите строку искомого элемента: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите стоблец искомого элемента: ");
int j = Convert.ToInt32(Console.ReadLine());

if (i-1 < rows)
{
    if (j-1 < columns)
    {
        Console.WriteLine($"{NewArray[i-1,j-1]}");
    }
    else
    {
        Console.WriteLine("Такого элемента не существует");
    }
}

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max+1);
        }

    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}