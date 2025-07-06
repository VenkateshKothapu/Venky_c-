using System;

class Task17
{
    public static void CheckStudentPerformance(int marks, string subject)
    {
        // Step 1: Grading based on marks (if-else-if)
        if (marks >= 90)
        {
            Console.WriteLine("Grade: Excellent");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade: Good");
        }
        else if (marks >= 35)
        {
            Console.WriteLine("Grade: Average");
        }
        else
        {
            Console.WriteLine("Grade: Fail");
        }

        // Step 2: Comment based on subject (switch-case)
        switch (subject)
        {
            case "Math":
                Console.WriteLine("Subject Comment: Practice daily to master concepts.");
                break;

            case "Science":
                Console.WriteLine("Subject Comment: Focus on experiments and understanding.");
                break;

            case "English":
                Console.WriteLine("Subject Comment: Improve your vocabulary and writing.");
                break;

            default:
                Console.WriteLine("Subject Comment: No specific comment.");
                break;
        }
    }

    static void Main()
    {
        CheckStudentPerformance(85, "Math");
        Console.WriteLine();

        CheckStudentPerformance(55, "Science");
        Console.WriteLine();

        CheckStudentPerformance(25, "History");
    }
}

