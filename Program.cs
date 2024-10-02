//task1
Console.WriteLine("2 mertebeli ededi daxil edin:");
int num = Convert.ToInt32(Console.ReadLine());
int a, b;

a = num % 10;
b = num / 10;
if(a>b)
{
    int max = a;
    Console.WriteLine(max);
}
if (b > a)
{
    int max = b;
    Console.WriteLine(max);
}
