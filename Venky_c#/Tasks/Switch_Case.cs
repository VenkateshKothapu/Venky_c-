using System;
class Switch_Case
{
    public static string getdaymessage(string day)
    {
        switch (day)
        {
            case "Monday":
                return "start your week!";

            case "Friday":
                return "Weekend is near!";

            case "sunday":
                return "Relax it's Sunday";
                    default:
                return "Just another day";


        }
    }
    static void Main()
    {
        Console.WriteLine(getdaymessage("Monday"));
        Console.WriteLine(getdaymessage("Friday"));
        Console.WriteLine(getdaymessage("Wednesday"));
        Console.WriteLine(getdaymessage("sunday"));




    }

}

