Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter l: ");
int l = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter k: ");
int k = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
int[,] arr5 = new int[l, k];
FillArray(arr4, -10, 10);
FillArray(arr5, -10, 10);
PrintArray(arr4);
Console.WriteLine();
PrintArray(arr5);

ProductArray(arr4, arr5);


void FillArray(int[,] array0, int minimum, int maximum)
{
    Random random = new Random();
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            array0[i, j] = random.Next(minimum, maximum);
        }
    }
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

void ProductArray (int[,] array1, int[,] array2)
{
    int product = 1;
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array1.GetLength(1); j++)
        {
            product = product * array1[i, j];
        }
    }
    int product1 = product;
    Console.WriteLine($"Product of array1 = {product1}");

    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            product = product * array2[i, j];
        }
    }
    int product2 = product;
    Console.WriteLine($"Product of array2 = {product2}");
    int arrayProduct = product1 * product2;
    Console.WriteLine($"Product of array1 and array2 = {arrayProduct}");
}