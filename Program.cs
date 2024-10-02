//task2
Console.WriteLine("ededi daxil edin:");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 2)
{
    Console.WriteLine("bu eded sade ededdir");
}
  else  if (n % 3 == 0 || n % 2 == 0 || n % 5 == 0)
    {
        Console.WriteLine("bu eded murekkeb ededdir");
    }
  else
{
    Console.WriteLine("bu eded sade ededdir");
}
   