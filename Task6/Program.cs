Console.Clear();
Console.WriteLine("Введите число: ");
int number=int.Parse(Console.ReadLine());
int x=number%2;
if (x==0) 
{
    Console.WriteLine($"{number} -> чётное");
}
else 
{
    Console.WriteLine($"{number} -> нечётное");
}