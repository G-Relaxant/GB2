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
/*Console.Write("Введите число: ");
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
}*/



// Variant 3
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(CheckMultiple(number, 7) && CheckMultiple(number, 23))    // Применяем метод сравнения(53 строка)
{
    Console.WriteLine("Yes, divisible");
}
else
{
    Console.WriteLine("No, undivisible");
}

bool CheckMultiple(int a, int b)                     // Инициализируем метод сравнения
{
    return a % b == 0;
}