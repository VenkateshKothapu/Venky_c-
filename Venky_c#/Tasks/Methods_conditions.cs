using System;
using System.Net;



class Methods_conditions
    {
    public static string getgrade(int marks)
    {
        if (marks >= 90)
        {
            return "Excellent";

        }
        else if (marks >= 60)
        {
            return "Good";

        }
        else if (marks >= 35)
        {
            return "Avarage";
        }
        else
        {
            return "Fail";

        }
    }
    static void Main()
    {
        Console.WriteLine("Marks :95" + getgrade(95));
        Console.WriteLine("Marks :65 " + getgrade(65));
        Console.WriteLine("Marks :40 " + getgrade(40));
        Console.WriteLine("Marks :20 " + getgrade(20));
    }
}

