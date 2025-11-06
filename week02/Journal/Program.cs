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

        //Creating the Journal Object
        Journal myJournal = new Journal();



        Console.WriteLine("Welcome to the journal program");

        bool keepOn = false;

        do
        {
            foreach (Option option in myOptions)
            {
                option.DisplayOptions();
            }

            string userResponse = Console.ReadLine(); 

             if (!string.IsNullOrEmpty(userResponse)) // verifying that the user enters a valid prompt , if not, it will be handled
             {                                         //this after compiler error 
                int optionChosen = int.Parse(userResponse);

                switch (optionChosen)
                {
                    case 1:
                        string prompt = myPromptGenerator.GetRandomPrompt();
                        string newEntry = Console.ReadLine();
                        
                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();
                        Entry entry1 = new Entry(newEntry, dateText, prompt);
                        myJournal.AddEntry(entry1);
                        break;

                    case 2:
                        myJournal.DisplayEntries();
                        break;    

                    case 5:
                        Console.WriteLine("Thanks for coming!");
                        keepOn = true;
                        break;    
                }

   
             }


        } while (!keepOn);
      

     }

 }
