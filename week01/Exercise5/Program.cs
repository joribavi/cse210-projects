using System;


class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
       // PromptUserName();
       // PromptUserNumber();
        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNum = SquareNumber(favoriteNumber);
        DisplayResult(userName, squaredNum );

    }


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int favoriteNumber = int.Parse(userNumber);
        return favoriteNumber;

    }

    static int SquareNumber(int myNumber)
    {
        double squaredNum = Math.Pow(myNumber, 2);
        int intNum = (int)squaredNum;
        return intNum;
    }
    
    static void DisplayResult(string name, int number)
    {
        Console.WriteLine($"{name}, the square of your number is {number}");    
    }
}