// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] table = new int[4, 4];
FillTable(table);

PrintMatrix(table);

int min = table[0, 0];
int row = 0;
int column = 0;

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (min > table[i, j])
        {
            min = table[i, j];
            row = i;
            column = j;
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"Минимальное значение {min}, его индекс {row}, {column}");

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        if (row != i && column != j)
        {
            Console.Write($"{table[i, j]} ");
        }
    }
    Console.WriteLine();
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillTable(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 99);
        }
    }
}