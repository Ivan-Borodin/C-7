Console.WriteLine("Введите кол-во строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите № строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите № столбца: ");
int b = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
Random rnd = new Random();
void FillArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            collection[i, j] = rnd.Next(-9, 10);
        }
    }
}
void PrintArray(int[,] col)
{
    for (int i = 0; i < col.GetLength(0); i++)
    {
        for (int j = 0; j < col.GetLength(1); j++)
        {
            Console.Write($"{col[i, j]} ");
        }
        Console.WriteLine();
    }
}
void Element(int[,] arr)
{
    if (a < m && b < n)
    {
        Console.WriteLine(arr[a, b]);
    }
    else Console.WriteLine("Такого элеиента в массиве нет");
}
FillArray(array);
PrintArray(array);
Element(array);
