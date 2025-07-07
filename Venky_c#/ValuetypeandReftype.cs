using System;



class ValuetypeandReftype
{
    static void Main(string[] args)
    {
        //value type
        int a = 90;
        int b = a;
        b = 25;

        Console.WriteLine(b);
        Console.WriteLine(a);

        //a and b are seperate copies . changing b doesnt affect a.

        //refernce types
        int[] arra1 = { 1, 2, 5, 6 };
        int[] arra2 = arra1;
        arra2[0] = 90;
        Console.WriteLine(arra2[0]);
        Console.WriteLine(arra1[0]);

    }
}

