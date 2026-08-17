using System;

int result1 = CalculateTotal(5, 10);
Console.WriteLine("Two ints: " + result1);

double result2 = CalculateTotal(1.5, 2.5, 3.5);
Console.WriteLine("Three doubles: " + result2);

int CalculateTotal(int a, int b)
{
    return a + b;
}

double CalculateTotal(double a, double b, double c)
{
    return a + b + c;
}