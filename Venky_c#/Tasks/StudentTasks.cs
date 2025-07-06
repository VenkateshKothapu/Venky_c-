using System;
using System.Threading.Tasks;

class StudentTasks
{
    static void Main()
    {
        //task1 preparing the string array
        string[] Employees = { "John", "Robert", "Chandra", "Peter" };

        Console.WriteLine(string.Join(",", Employees));

        //task2- get the third employee of the array

        Console.WriteLine(Employees[2]);
        //here index two gives the 2rd element of the array that is chandra .syntax is array[index]


        //task3 checking weather second and third employees are equal

        bool areequal = Employees[1] == Employees[2];
        Console.WriteLine(areequal);
        //output is false because robert is not equal to chandra

        //task4- checking the employee whos name starts with "j"

        foreach (string emp in Employees)
        {
            if (emp.StartsWith("J"))
            {
                Console.WriteLine(emp);
            }



        }

        //task5=convert employees list into single string
        string result = string.Join(",", Employees);
        Console.WriteLine(result);

        //task6 - replacing robert with peter in the string

        string updated = result.Replace("Robert", "Peter");
        Console.WriteLine(updated);


        //task7- get Employees with name length>4
        foreach (string emp in Employees)
        {
            if (emp.Length > 4)
            {
                Console.WriteLine(emp);
            }
        }

        //task8- difference between for and foreach
        //for loop

        for(int i=0; i < Employees.Length; i++)
        {
            Console.WriteLine(Employees[i]);
        }
        //foreach loop
        foreach(string emp in Employees)
        {
            Console.WriteLine(emp);
        }
        //task 9 - importance of looping system
        for (int i = 1; i <= 5; i++) 
        {
            Console.WriteLine("welcome" + i);
        }

        //task 10 floating data types

        float a = 6.5f;
        double b = 12.3456;
        decimal c = 1234.56m;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);


        //task 11 - Logical operators

        bool Result = (5 > 2) && (6 > 2);
        bool Result2 = (5 > 3) || (8 < 10);
        bool Result3 = !(5 > 3);

        Console.WriteLine(Result);
        Console.WriteLine(Result2);
        Console.WriteLine(Result3);

       







    }
}

