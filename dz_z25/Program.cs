int AdegreeB(int A, int B)
{
    int result = 1;

    for (var index = 1; index <= B; index++)
        result = result * A;

    return result;
}

Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, для возведения А в натуральную степень B:");
int B = int.Parse(Console.ReadLine()!);

int result = AdegreeB(A, B);
if (B < 0)
    Console.WriteLine("Степень должна быть натураньным числом");
else if (B == 0)
    Console.WriteLine("1");
else
    Console.WriteLine(result);