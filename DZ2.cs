Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
int[,] arr4 = new int[n, m];
FillArray(arr4, -10, 10);
PrintArray(arr4);
Console.WriteLine();
SearchMinimum(arr4);
Console.WriteLine();
//PrintArray(arr4);



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

void SearchMinimum(int[,] array)
{
    int min = 0;
    int currentI = 0;
    int currentJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                currentI = i;
                currentJ = j;
            }
        }
    }
    Console.WriteLine($"{min} in {currentI} and {currentJ}");

    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         if (i == currentI || j == currentJ)
    //         {
    //             array[i, j] = 0;
    //         }
    //     }
    // }
    Console.WriteLine();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i != currentI && j != currentJ) Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}