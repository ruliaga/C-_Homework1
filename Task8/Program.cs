Console.Clear();
bool Check (int A)
{
    int B=A%2;
    if (B==0)
    {
        return true;
    }
    else{return false;}
}

int counter=1;

Console.WriteLine("Введите число: ");
int number=int.Parse(Console.ReadLine());


Console.Write($"{number} -> ");
while (counter<=number){

    if (Check(counter)==true)
    {
        Console.Write($"{counter} ");
         }
         counter++;

}