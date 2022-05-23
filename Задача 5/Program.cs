// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента
int[,,] table = new int[2, 3, 4];
FillTable(table);
PrintMatrix(table);

void FillTable(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int h = 0; h < matrix.GetLength(2); h++)
            {
                table[i, j, h] = new Random().Next(10, 100);
                CheckMarix(matrix, i, j, h);
            }
        }
    }
}

void CheckMarix(int[,,] table, int a, int b, int c)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int h = 0; h < table.GetLength(2); h++)
            {
                if (table[i, j, h] == table[a, b, c])
                {
                    table[i, j, h] = new Random().Next(10, 100);
                }
            }
        }
    }
}

void PrintMatrix(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int h = 0; h < matr.GetLength(2); h++)
            {
                Console.WriteLine($"Значение: {matr[i, j, h]},  индексы {i}, {j}, {h}");
            }
        }
        Console.WriteLine();
    }
}