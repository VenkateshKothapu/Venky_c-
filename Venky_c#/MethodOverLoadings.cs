using System;

class MethodOverLoadings
{
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }
    static double Add(double a, double b)
    {
        return a + b;

    }
    static void Main()
    {
        Console.WriteLine("Adding two numbers " + Add(5, 10));
        Console.WriteLine("Adding three numbers " + Add(5, 10, 15));
        Console.WriteLine("Adding two double " + Add(5.5 ,10.5));
    }
}

