//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число_1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число_2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if(number1>number2)
{
    Console.WriteLine("max = "); 
    Console.WriteLine(number1);
    Console.WriteLine("min = "); 
    Console.WriteLine(number2);
    
}
else
{
    Console.WriteLine("max = "); 
    Console.WriteLine(number2);
    Console.WriteLine("min = "); 
    Console.WriteLine(number1);
}
