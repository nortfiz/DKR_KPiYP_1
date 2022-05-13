string s, s1;
int r = 0;
Console.WriteLine("Введите текст");
s = Console.ReadLine();
Console.WriteLine("Введите слово которое необходимо найти");
s1 = Console.ReadLine();
string[] ss = s.Split(' ');
foreach (var str in ss)
{
    if (str == s1)
    {
        ++r;
    }
}
Console.WriteLine("Количество повторений: " + Convert.ToString(r));

