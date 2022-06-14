
/*int number = Random3xNumber();

Console.WriteLine("Случайное число: " + number);

int num1 = number / 100;
int num2 = number % 10;

Console.WriteLine("Комбинация 1й и 3й цифр из случайного числа: " + num1 + num2);

int Random3xNumber()
{
    return new Random().Next(100, 1000);
}*/


int number = Random3xNumber();

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
}