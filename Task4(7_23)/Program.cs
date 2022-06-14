//VARIANT 1
/*Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int divrem7 = number % 7;
int divrem23 = number % 23;
if(divrem7 == 0)
{
    if(divrem23 == 0)
    {
        Console.WriteLine("Да, кратно");
    }
    else
    {
        Console.WriteLine("Нет, не кратно");
    }
}
else
    {
        Console.WriteLine("Нет, не кратно");
    }*/



//VARIANT 2
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int divrem7 = number % 7;
int divrem23 = number % 23;
if(divrem7 == 0 && divrem23 == 0)
{
    Console.WriteLine("Yes, divisible");
}
else
{
    Console.WriteLine("No, undivisible");
}