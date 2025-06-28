using System;
class MembersStringClass
    {
    static void Main(String[] args)
    {
        string name = "venkatesh";
        Console.WriteLine("name : "+name.Length);
        Console.WriteLine("name Uppercase : " + name.ToUpper());
        Console.WriteLine("name Lowercase : " + name.ToLower());
        Console.WriteLine("Trim : " + name.Trim());
        Console.WriteLine("Contains : " + name.Contains("venkatesh"));
        Console.WriteLine("Contains : " + name.Contains("venky"));
        Console.WriteLine(" Name : " + name.StartsWith("ve"));
        Console.WriteLine("Name : " + name.EndsWith("sh"));


        string City = " Banglore";
        int Cityname = City.Length;
        Console.WriteLine(Cityname);


    }
 }

