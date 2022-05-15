int n = 8;
int m = 8;
int[,] mat;
mat = new int[n, m];
Random random = new Random();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mat[i, j] = random.Next(100);
        Console.Write("{0,4}", mat[i, j]);
    }
    Console.WriteLine();

}
for(int j = 0; j < n; j++)
            {
    int count = 0;
    for (int i = 0; i < m; i++)
        if (mat[i, j] == 1)
            count++;
    if (count == m)
        Console.WriteLine("column({0})", j + 1);
}
Console.WriteLine();
