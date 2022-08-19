int SumAllNumbers(int num)
{
    int index = num.ToString().Length;
    int count = 0;
    int result = 0;
    int digit = num;
    while (count < index)
    {
        digit = num % 10;
        result = digit + result;
        num = num / 10;
        count++;
    }
    return result;
}

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine()!);

if (number == 0)
{
    Console.WriteLine("0");
    return;
}
else if (number < 0)
{
    //  number = number * -1;
    Console.WriteLine("Введите положительное число");
    return;
}

Console.WriteLine(SumAllNumbers(number));