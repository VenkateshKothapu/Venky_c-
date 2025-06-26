using System;
class BoolExample
{
    static void Main(string[] args)
    {
        bool paidtoll = true;
        bool hasliecense = false;

        Console.WriteLine("paidtoll :" + paidtoll);
        Console.WriteLine("liecense" + hasliecense);

        //conditional check

        if(paidtoll)
        {
            Console.WriteLine("Access granted to move");

        }
        else
        {
            Console.WriteLine("Pay the toll fee and move");
        }


    }

}

