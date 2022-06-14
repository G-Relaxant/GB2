int number = GetRandomNumber();       //Задействуем функцию(метод) записи случайного числа в переменную

Console.WriteLine(number);

int maxDigit = FindMaxDigit();  //Задействуем функцию(метод) поиска макс числа делением; ПУСТОЙ ПАРАМЕТР(РАБОТАЕТ ТАКЖЕ) 

/*while(number > 0)                     ПЕРЕНЕСЛИ ЦИКЛ В МЕТОД НИЖЕ(24line)
{                                       Переменную max заменили переменной maxDigit
    int lastDigit = number % 10;
    if(lastDigit > max)
    {
        max = lastDigit;
    }
    number = number / 10;
}*/

Console.WriteLine(maxDigit);

int GetRandomNumber()                 //МЕТОД(ФУНКЦИЯ) ГЕНЕРАЦИИ СЛУЧАЙНОГО ЧИСЛА; ПУСТОЙ ПАРАМЕТР(РАБОТАЕТ ТАКЖЕ)
{
    return new Random().Next(10, 100);
}

int FindMaxDigit()          //МЕТОД(ФУНКЦИЯ) ПОИСКА МАКС ЧИСЛА ДЕЛЕНИЕМ
{
    int max = 0;
    while(number > 0)
    {
        int lastDigit = number % 10;
        if(lastDigit > max)
        {
            max = lastDigit;
        }
    number = number / 10;
    }
    return max;                     //Значение max записывается в ПУСТОЙ параметр (24line), РАБОТАЕТ ТАКЖЕ
}