// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] table = new int[5, 5];
FillTable(table);

Console.WriteLine("Массив до стортировки:");
PrintMatrix(table);

int temp = 0;
for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        for (int h = j + 1; h < table.GetLength(1); h++)
        {
            if (table[i, j] > table[i, h])
            {
                temp = table[i, j];
                table[i, j] = table[i, h];
                table[i, h] = temp;
            }
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Массив после стортировки:");
PrintMatrix(table);

void FillTable(int[,] matrix)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
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