// Variant 1
/*Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int remnant = number1 % number2;
if(remnant == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Первое число не кратно второму. Остаток = " + remnant);
}*/



// Variant 2
int number1 = Input("Введите первое число: ");      // Применение метода ввода-вывода(32 строка)
int number2 = Input("Введите второе число ");
int remnant = number1 % number2;

if(remnant == 0)
{
    Console.WriteLine("Первое число кратно второму");
}
else
{
    Console.WriteLine("Первое число не кратно второму. Остаток = " + remnant);
}

int Input(string output)                           // Инициализация метода ввода-вывода(консоль)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}