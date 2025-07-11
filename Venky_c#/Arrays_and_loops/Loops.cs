using System;

class Loops
{
    public static void Main(string[] args)
    {
        //for loop
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Number:" + i);
        }

        //printing all the elements in the array
        string[] fruits = { "Banana", "Apple", "Mango" };
        for (int i = 0; i <= fruits.Length; i++) 
        Console.WriteLine(fruits[i]);

    }
}

