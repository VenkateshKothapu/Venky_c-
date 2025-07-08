using System;




class Arrays
{
    public static void Main(String[] args)
    {
        string[] Employees = { "NTR", "Chinaranjeevi", "Venkatesh" };
        Employees[2] = "balayya";
        Console.WriteLine(Employees[0]);
        Console.WriteLine("movie stars : " + string.Join(",", Employees));
        Console.WriteLine(Employees.Length);

        //Now we will see Declaring first and assigning later

        int[] StudentsMarks = new int[3];
        StudentsMarks[0] = 65;
        StudentsMarks[1] = 75;
        StudentsMarks[2] = 99;
        //StudentsMarks[3] = 85;
        //StudentsMarks[4] = 99;

        Console.WriteLine("Marks :" + string.Join(",", StudentsMarks));
        //to get length of the array
        Console.WriteLine(StudentsMarks.Length);

        //Acessing Array elements dynamically

        string[] Friends = { "Venkatesh", "Brad pitt", "JohnCena", "Misterio" };
        Console.WriteLine("Friend one " + Friends[2]);
        Console.WriteLine("Friend in Wrestling :" + Friends[Friends.Length - 1]);

        //modifying array values

        int[] marks = { 65, 75, 85 };
        marks[1] = 25;
        Console.WriteLine("Updated Marks :" + marks[1]);

        //storing 5 employee salaries

        int[] salaries = new int[5];
        salaries[0] = 25000;
        salaries[1] = 30000;
        salaries[2] = 40000;
        salaries[3] = 50000;
        salaries[4] = 60000;

        Console.WriteLine("Employe 3 Salary :" + salaries[2]);
        Console.WriteLine("Employe 2 salary :" + salaries[salaries.Length - 1]);

        //to get total elements in array
        Console.WriteLine("Total Employees :" + salaries.Length);


        //Array with var kryword

        var items = new string[] { "pen", "Book", "chair" };
        Console.WriteLine(items[1]);

        //Array with foreach 
        string[] tasks = { "code", "Test", "Deploy" };
        foreach (string task in tasks)
        {
            Console.WriteLine(task);

        }


    }
}

