using System;




class While_dowhile
{
    static void Main()
    {
        //int a = 1;
        //while (a <= 5)
        //{
        //    Console.WriteLine("Number :" + a);
        //    a++;
        //}

        //another example
        //string password = "";
        //while (password != "VENKY")
        //{
        //    Console.WriteLine("Enter correct password");
        //    password=Console.ReadLine();
        //}
        //Console.WriteLine("Acess Granted");

        //asking age until valid age is enterd

        //int age = -1;
        //while(age<0 || age > 130) 
        //{
        //    Console.WriteLine("Enter the valid age(0-130) :");
        //    age=int.Parse(Console.ReadLine());

        //}
        //Console.WriteLine("Thank you ! your age is " + age);

        //menun driven program

        //int choice = 0;
        //while (choice != 4)
        //{
        //    Console.WriteLine("/Menu");
        //    Console.WriteLine("1. Say Hello");
        //    Console.WriteLine("2. Show Date");
        //    Console.WriteLine("3. SHow Time");
        //    Console.WriteLine("4. Exit");
        //    choice = int.Parse(Console.ReadLine());

        //    if (choice == 1) 
        //    Console.WriteLine(" Hello venkateshwar Reddy have a great day");
        //    else if (choice == 2) 
        //    Console.WriteLine("Todays Date is :" + DateTime.Now.ToShortDateString());
        //    else if (choice == 3) 
        //    Console.WriteLine("Now the Exact time is :" + DateTime.Now.ToShortTimeString());
        //    else if (choice == 4)
        //        Console.WriteLine("Exiting : Bye");

        //    else
        //        Console.WriteLine("Ivalid choice please choose from the menu");

        //calculator menu using while



        int choice = 0;
        while (choice != 5)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1.ADD");
            Console.WriteLine("2.Sub");
            Console.WriteLine("3.Mul");
            Console.WriteLine("4.Div");
            Console.WriteLine("5.Exit");

            Console.Write("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            if (choice >= 1 && choice <= 4)
            {
                Console.Write("Enter the First number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Second Number :");
                double num2 = double.Parse(Console.ReadLine());
            
                 if (choice == 1)
                    Console.WriteLine("Addition result :" + (num1 + num2));
                else if (choice == 2)
                    Console.WriteLine("Substracting result:" + (num1 - num2));
                else if (choice == 3)
                    Console.WriteLine("Multiplication result:" + (num1 * num2));
                else if (choice == 4)
                {
                    if (num2 != 0)
                        Console.WriteLine("Result :" + num1 / num2);
                    else
                        Console.WriteLine("Cannot divided by Zero");

                }

            }

            else if (choice == 5)
                Console.WriteLine("Exiting from the Calculator :Bye");
            else
                Console.WriteLine("invalid choice . try again");










        }











    }







}


