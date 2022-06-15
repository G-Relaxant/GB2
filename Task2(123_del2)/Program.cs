// 1й способ
/*int number = Random3xNumber();

Console.WriteLine("Случайное число: " + number);

int num1 = number / 100;
int num2 = number % 10;

Console.WriteLine("Комбинация 1й и 3й цифр из случайного числа: " + num1 + num2);

int Random3xNumber()
{
    return new Random().Next(100, 1000);
}*/



// 2й способ
/*int number = Random3xNumber();

Console.WriteLine("Случайное число: " + number);

int num1 = Find1Digit(number);

int num2 = Find2Digit(number);

Console.WriteLine("Комбинация 1й и 3й цифр из случайного числа: " + num1 + num2);

int Find1Digit(int number)
{
    int accum = 0;
    while(number > 9)
    {
        number = number / 10;
    }
    accum = number;
    return accum;
}


int Find2Digit(int number)
{
    int accum = 0;
    int accum2 = 0;
    while(number > 99)
    {
        accum2 = number % 10;
        number = number / 10;
    }
    accum = accum2;
    return accum;
}


int Random3xNumber()
{
    return new Random().Next(100, 1000);
}*/



// 3й способ
int number = new Random().Next(100, 1000);
int digit3 = number % 10;
int digit1 = number / 100;
int onethree = digit1 * 10 + digit3;
Console.WriteLine("Случайное число: " + number);
Console.Write("1and3 number: " + onethree);
