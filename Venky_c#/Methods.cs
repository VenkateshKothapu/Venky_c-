using System;




class Methods
{
    static int Add(int a, int b)
    {
        return a + b;

    }
    static void Main()
    {

        int result = Add(4, 5);
        Console.WriteLine(result);
        greet();//no return type no parameters
        Bag("Skybags");//no return type with parameters
        int rent = rentpermonth();//return type with no parameters
        Console.WriteLine("Monthly rent of the pg is " + rent);

        int Sum = Addition(5, 8);//return type with parameters
        Console.WriteLine("Addition of two mumbers is "+Sum);



    }

    // now below is the method with no return type no parameters.
    static void greet()
    {
        Console.WriteLine("Hey how are you ");

    }

    //now we will see no return type with parameters

    static void Bag(string name)
    {
        Console.WriteLine("My Bag is " + name);
    }


    //now we will see return type with no parameters

    static int rentpermonth()
    {
        return 7500;
    }
    //now we will see return type with parameters
    static int Addition(int a, int b)
    {
        return a + b;
    }












}