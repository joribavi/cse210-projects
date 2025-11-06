using System;

class Program
{
    static void Main(string[] args)
    {

     

        PromptGenerator myPromptGenerator = new PromptGenerator();

        myPromptGenerator.prompt1 = "Did you have an spiritual experience today?";

        myPromptGenerator.prompt2 = "Did you learn something new today?";

        myPromptGenerator.prompt3 = "What can you be grateful of today?";

        myPromptGenerator.prompt4 = "Did you meet someone you didn't see long time ago?";

        myPromptGenerator.prompt5 = "What was something special today for you?";

        //Creating prompt and options 
        Option option0 = new Option("Please choose one of the following options");
        Option option1 = new Option("1) Write a new entry ");
        Option option2 = new Option("2) Display the Journal");
        Option option3 = new Option("3) Save the Journal to a file");
        Option option4 = new Option("4) Load the Journal from a file");
        Option option5 = new Option("5) Quit");

        //Adding options to list 
        List<Option> myOptions = new List<Option>();

        myOptions.Add(option0);
        myOptions.Add(option1);
        myOptions.Add(option2);
        myOptions.Add(option3);
        myOptions.Add(option4);
        myOptions.Add(option5);


        Console.WriteLine("Welcome to the journal program");
        foreach (Option option in myOptions)
        {
            option.DisplayOptions();
        }

        string? userResponse = Console.ReadLine(); //trying to fix possible nullable argument 

        if (!string.IsNullOrEmpty(userResponse)) // verifying that the user enters a valid prompt , if not, it will be handled
        {                                         //this after compiler error 
            int optionChosen = int.Parse(userResponse);

            if (optionChosen == 1)
            {


            }
            else if (optionChosen == 2)

            {

            }

            else if (optionChosen == 3)
            {

            }

            else if (optionChosen == 4)

            {

            }

            else if (optionChosen == 5)
            {

            }
            else
            {
                Console.WriteLine("Please Enter a Valid response");
            }

        }
     }

 }
