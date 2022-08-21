Console.Clear();
Console.WriteLine("Введите число A: ");
int numberA=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB=int.Parse(Console.ReadLine());
if (numberA>numberB)
{
    Console.WriteLine($"А={numberA} B={numberB} Max={numberA}");
}
else
{
Console.WriteLine($"А={numberA} B={numberB} Max={numberB}");
}
