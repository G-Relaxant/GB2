Console.Write("Введите первое число: ");
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
}