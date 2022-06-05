int m = 3;
int n = 4;
double[,] array = new double[m, n];
Random rnd = new Random();
void FillArray(double[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = rnd.Next(-9, 10) + rnd.NextDouble();
        }
    }
}
void PrintArray(double[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(col[i, j], 1)} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
PrintArray(array);
