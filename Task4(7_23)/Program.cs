Console.Write("Введите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int divrem7 = number1 % 7;
int divrem23 = number1 % 23;
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
    }