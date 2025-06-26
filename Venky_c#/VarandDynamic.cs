using System;

class VarandDynamic
{
    static void Main(String[] args)
    {
        //var message = "Hey how are you buddy";
        //Console.WriteLine(message.ToUpper());

        ////message=100; error this will not work because string cannot be changed to int after declaring using var



        ////now we will se dynamic


        dynamic Message = "hey how are you ";
        Console.WriteLine("message :" + Message);

        Message = 256;
        Console.WriteLine(Message + 1);
        Message = true;
        Console.WriteLine("message :" + Message);

    }
}
