int number = new Random().Next(10, 100);
int max = int.MinValue;

Console.WriteLine(number);

while(number > 0)
{
    int lastDigit = number % 10;
    if(lastDigit > max)
    {
        max = lastDigit;
    }
    number = number / 10;
}

Console.WriteLine(max);