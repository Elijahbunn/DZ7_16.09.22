Console.WriteLine("Enter n: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter m: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Enter l: ");
int l = int.Parse(Console.ReadLine() ?? "0");
int[,,] arr4 = new int[n, m, l];
FillArray(arr4, 10, 100);
PrintArray(arr4);
Console.WriteLine();
//SearchMinimum(arr4);
Console.WriteLine();
//PrintArray(arr4);



void FillArray(int[,,] array0, int minimum, int maximum)
{
    Random random = new Random();
    int tmp;
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            for (int l = 0; l < array0.GetLength(2); l++)
            {
                tmp = random.Next(minimum, maximum);
                
                for (int e = 0; e < array0.GetLength(0); e++)
                {
                    for (int r = 0; r < array0.GetLength(1); r++)
                    {
                        for (int t = 0; t < array0.GetLength(2); t++)
                        {
                            if(tmp == array0[e, r, t])
                            {
                                tmp = random.Next(minimum, maximum);
                            }
                        }
                    }
                }
                array0[i,j,l] = tmp;
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int l = 0; l < array.GetLength(2); l++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{array[i, j, l]}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"({i},{j},{l}) ");
            }
        }
        Console.WriteLine();
    }
}
