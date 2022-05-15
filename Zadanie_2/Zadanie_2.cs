int n = 8;
int m = 8;
int[,] mat;
mat = new int[n, m];// { {1,1,1 },{1,1,1 },{ 1,1,1} };
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
for (int i = 0; i < n-1; ++i)
{
    for (int j = 0; j < m-1; ++j)
    {
        
        if (mat[i+1, j] == mat[i,j+1])
        {
            Console.WriteLine("Равны");
        }
        else
        {
            Console.WriteLine("Неравны");
        }
        //break;
    }
}
/*for (int j = 0; j < m; j++)
    {

    }
*/
