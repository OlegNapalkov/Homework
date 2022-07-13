Console.Write("Введите число_1: ");
int N1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число_2: ");
int N2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число_3: ");
int N3 = Convert.ToInt32(Console.ReadLine());
int max = 0;

if(N1>N2)
max = N1;
else
max = N2;
if(max > N3)
{
Console.WriteLine("max = ");
Console.WriteLine(max);
}
else
{
Console.WriteLine("max = ");
Console.WriteLine(N3);
}