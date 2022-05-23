// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
int[,] table = new int[4, 6];
FillTable(table);

Console.WriteLine("Массив:");
PrintMatrix(table);

int[] sum = new int[table.GetLength(0)];

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        sum[i] += table[i, j];
    }
}
PrintResult(sum);
int minValue = sum[0];
int minValueIndex = 0;
for (int b = 1; b < sum.Length; b++)
{
    if (minValue > sum[b])
    {
        minValueIndex = b;
        minValue = sum[b];
    }
}

Console.WriteLine($"Строка с наименьшей суммой под номером {minValueIndex + 1}");

void PrintResult(int[] array)
{
    for (int a = 0; a < array.Length; a++)
    {
        Console.WriteLine($"Сумма строки {a + 1} = {array[a]}");
    }
}

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