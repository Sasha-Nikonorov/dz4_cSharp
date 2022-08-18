Console.WriteLine("Введите число:");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число, для возведения А в натуральную степень B:");
int B = int.Parse(Console.ReadLine()!);

var result = Math.Pow(A, B);

Console.WriteLine(result);