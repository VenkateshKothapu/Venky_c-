using System;
 class TypeConversion
 {
    static void Main(String[] args)
    {
        //implict conversion type - done by c# automatically

        string ageText = "25";
        int age = Convert.ToInt32(ageText);
        Console.WriteLine(age);

        //explicit conversion type -done manually

        //using Convert.ToInt32(),ToString()

        string ageinText = "32";
        int ageinNum = Convert.ToInt32(ageinText);
        Console.WriteLine(ageinNum);

        int ageinint = 26;
        string ageintext = Convert.ToString(ageinint);
        Console.WriteLine(ageintext);


        //using casting operator

        double Weight = 90.400;
        int roundedweight = (int)Weight;
        Console.WriteLine(roundedweight);

        //using parse() or TryParse()(from string)
        string salary = "50000";
        int sal = int.Parse(salary);
        Console.WriteLine(sal);
        string weight = "90.400";
        double weightindouble = double.Parse(weight);
        Console.WriteLine(weightindouble);

        //using TryParse()

        string Textage = "123";
        int numberage;

        bool Sucess = int.TryParse(Textage, out numberage);

        if (Sucess)
        {
            Console.WriteLine("Conversion Succesful :" + numberage);

        }
        else
        {
            Console.WriteLine("Conversion failed because invalid number input :");
        }


        string height = "6";
        int heightinfeet;

        bool sucess = int.TryParse(height, out heightinfeet);

        if (sucess)
        {
            Console.WriteLine("Conversation from string  to int is sucessful :" + heightinfeet);

        }
        else
        {
            Console.WriteLine("conversation is failed because invalid number input");
        }


        string Numberofcars = "25 cars";
        int countofcars;
        bool sucessful = int.TryParse(Numberofcars, out countofcars);

        if (sucessful)
        {
            Console.WriteLine(" Count of cars i sucessful:" + countofcars);

        }

        else
        {
            Console.WriteLine("count of cars is not sucess ");
        }






    }
 }

