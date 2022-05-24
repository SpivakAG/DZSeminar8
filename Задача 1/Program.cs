// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

int[,] table = new int[4, 4];
FillTable(table);
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

PrintMatrix(table);
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

int[,] newTable = new int[3, 3];
int a = 0;
int b = 0;
for (int i = 0; i < newTable.GetLength(0); i++)
{
    if(a==row & a<table.GetLength(0)) a+=1;
    for (int j = 0; j < newTable.GetLength(1); j++)
    {
        if(b==column & b<table.GetLength(1)) b+=1; //так и не понял как сделать чтобы выводилась корректно не только первая строка :'(
        newTable[i,j]=table[a,b];
        if (b<table.GetLength(1)-1) b++;
    }
    if(a<table.GetLength(0)-1) a++;
}

PrintMatrix(newTable);