using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assignment1 = new Assignment();
        string summary1 = assignment1.GetSummary();

        Console.WriteLine($"{summary1}");

        MathAssignment mathAssignment1 = new MathAssignment();

        string summary2 = mathAssignment1.GetSummary();

        string list1 = mathAssignment1.GetHomeworkList();

        Console.WriteLine($"Test of the math Assignment Class");
        Console.WriteLine($"{summary2}");
        Console.WriteLine($"{list1}");

        WritingAssignment writingAssignment1 = new WritingAssignment();
        string summary3 = writingAssignment1.GetSummary();
        string list2 = writingAssignment1.GetWritingInformation();
        Console.WriteLine($"Test of the math Writing Assignment Class");
        Console.WriteLine($"{summary3}");
        Console.WriteLine($"{list2}");
         
        
    }
}