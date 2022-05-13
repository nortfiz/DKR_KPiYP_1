Console.WriteLine("Введите а");
int a = int.Parse(s: Console.ReadLine());

Console.WriteLine("Введите b");
int b = int.Parse(s: Console.ReadLine());

Console.WriteLine("Введите h");
int h = int.Parse(s: Console.ReadLine());

int k = 1;
Console.WriteLine("Введите N");
int n = int.Parse(Console.ReadLine());

double q = 0;

for (int x = a + h; x <= b; x += h)
{
    Console.WriteLine("Х равно:" + x);
    double S = x;
    for (int i = 0; i < n; i++)
    {
        double r = (Math.Pow(-1, k + 1)) * (Math.Pow(S, 2 * k)) / (2 * k * (2 * k - 1));
        k++;
        q = q + r;
       
    }
     Console.WriteLine("S(x)=  "+q);
    
        double r_2 = S * Math.Atan(S) - Math.Log(Math.Sqrt(1 + Math.Pow(S, 2)), 10);
        Console.WriteLine("Y(x) = " + r_2);

        double r_3 = Math.Abs(r_2 - q);
        Console.WriteLine("Y(x)-S(x) = " + r_3);
 }
