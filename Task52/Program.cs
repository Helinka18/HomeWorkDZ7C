/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

Console.WriteLine("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] NewArray = GetArray(rows, columns, 0, 10);
PrintArray(NewArray); 

double sum = 0;
for (int j = 0; j < NewArray.GetLength(1); j++)
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        while ( i < rows)
        {
            sum += NewArray[i, j];
            i++;
        }
        double tmpavg = 0;
        tmpavg = sum / rows;
        Console.Write($"{Math.Round(tmpavg,1)} \t");
        sum = 0;
    }
}


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
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
            Console.Write($"{array[i, j]} \t");
        }
        Console.WriteLine();
    }
}
