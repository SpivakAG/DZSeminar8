// Заполните спирально массив 4 на 4
int[,] table = new int[4, 4];
int count = 0;

for (int i = 0; i < table.GetLength(1); i++)
{
    table[0, i] = i + 1;
    count++;
}
for (int j = 1; j < table.GetLength(0); j++)
{
    table[j, 3] = count + 1;
    count++;
}
int a = 2;
while (a > -1)
{
    table[3, a] = count + 1;
    count++;
    a -= 1;
}
a = 2;
while (a > 0)
{
    table[a, 0] = count + 1;
    count++;
    a -= 1;
}
a = 1;
while (a < 3)
{
    table[1, a] = count + 1;
    count++;
    a += 1;
}
a = 2;
while (a > 0)
{
    table[2, a] = count + 1;
    count++;
    a -= 1;
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