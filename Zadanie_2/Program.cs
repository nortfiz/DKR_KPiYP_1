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

for (int i = 0; i < n; i++)
{
    int j = 0;
    for (int k = 0; k < m; k++)
    {
        
        if (mat[i,j]== mat[j,i])
        {
            Console.WriteLine("true");
            j++;
        }
        else
        
        {
            Console.WriteLine("folse");
            
        }
        break;
    }

}
