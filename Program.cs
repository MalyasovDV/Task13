void ThirdDigit(int num)
{
    int digit = -1;
    if (num / 100 > 1)
    {
        while (num / 100 > 1)
        {
            digit = num % 10;
            num /= 10;
        }
        Console.WriteLine(digit);
    }
    else 
        Console.WriteLine("Третьей цифры нет");
}

int num = 645;
ThirdDigit(num);

num = 78;
ThirdDigit(num);

num = 32679;
ThirdDigit(num);