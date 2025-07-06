using System;
using System.Security;
class Task2_params
    {
    public static int AddNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
        }
        return sum;

    }
    static void Main()
    {
        Console.WriteLine(AddNumbers(10, 20));
        Console.WriteLine(AddNumbers(1, 2, 3, 4, 5));
        Console.WriteLine(AddNumbers());
    }
}

