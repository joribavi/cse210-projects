using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Write your grade percentage.");
        string grade = Console.ReadLine();
        int gradeNumber = int.Parse(grade);
            
        if (gradeNumber >= 90)
        {
            int reminder = gradeNumber % 10;
            string letter = ("A");
            string minusSign = ("-");
            
            Console.WriteLine("Congratulations! You have passed the course");
            if (reminder < 3)
            {
                Console.WriteLine($"You got  {letter}{minusSign}");
            }
           
            else
            {
                 Console.WriteLine($"You got  {letter}");
            }
        

        }
        else if (gradeNumber >= 80 && gradeNumber < 90)
        {
            int reminder = gradeNumber % 10;
            string minusSign = ("-");
            string plusSign = ("+");
            string letter = ("B");
            Console.WriteLine("Congratulations! You have passed the course");

            if (reminder < 3)
            {
                Console.WriteLine($"You got  {letter}{minusSign}");
            }
            else if (reminder >= 7)
            {
                Console.WriteLine($"You got  {letter}{plusSign}");
            }

            else
            {
                Console.WriteLine($"You got  {letter}");
            }
        
            

        }
        else if (gradeNumber >= 70 && gradeNumber < 80)
        {
            int reminder = gradeNumber % 10;
            string minusSign = ("-");
            string plusSign = ("+");
            string letter = ("C");

            Console.WriteLine("Congratulations! You have passed the course");   


            if (reminder < 3)
            {
                Console.WriteLine($"You got {letter}{minusSign}");
            }
            else if (reminder >= 7)
            {
                Console.WriteLine($"You got {letter}{plusSign}");
            }

            else
            {
                Console.WriteLine($"You got {letter}");
            }
        

        }
        else if (gradeNumber >= 60 && gradeNumber < 70)
        {
            string letter = ("D");
            int reminder = gradeNumber % 10;
            string minusSign = ("-");
            string plusSign = ("+");
            Console.WriteLine("Unfortunately you have not passed the course");   
            
            if (reminder < 3)
            {
                Console.WriteLine($"You got {letter}{minusSign}");
            }
            else if (reminder >= 7)
            {
                Console.WriteLine($"You got {letter}{plusSign}");
            }

            else
            {
                Console.WriteLine($"You got {letter}");
            }
        


        } 
         else
        {
            string letter = ("F");
            Console.WriteLine("Unfortunately you have not passed the course");   
            Console.WriteLine($"You got {letter}");

        } 





    }
}