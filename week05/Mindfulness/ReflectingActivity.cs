class ReflectionActivity : Activity
{

     private List<string>_prompts = new List<string>();

     private List<string>_questions = new List<string>();
     private ReflectionActivity(string name, string description, int duration) : base(name, description, duration)
    {
        name = "Breathing Activity";
    }

     public static void Run()
    {
        
      int duration = 0;   //initial default value
      string description =  "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";

      ReflectionActivity myReflectingActivity = new("Reflecting", description, duration);  
      myReflectingActivity.DisplayStartingMessage();
      string durationString = Console.ReadLine();
      duration = int.Parse(durationString);
      myReflectingActivity.SetDuration(duration);
      Console.Clear();
      myReflectingActivity.DisplayPrompt(); 
      string response = Console.ReadLine();

      if (response == "")
        {
         Console.WriteLine("Now ponder on each of the following questions as they related to this experience");
         Console.Write("You may begin in: ");   
         myReflectingActivity.ShowCountDown(5);
         DateTime startTime = DateTime.Now;
         DateTime endTime = startTime.AddSeconds(duration);
         while (DateTime.Now < endTime)
        {
             myReflectingActivity.DisplayQuestions();
             myReflectingActivity.ShowSpinner(5);
        }

      Console.WriteLine("");
      
      myReflectingActivity.DisplayEndingMessage();

      myReflectingActivity.ShowSpinner(5);
      Console.Clear();

     



        }
      else
        {
            Console.WriteLine("That is not a valid value. Please hits enter to continue");
        }  



    }
    
    public string GetRandomPrompt()  
    {
        string prompt1 = "Think of a time when you stood up for someone else.";
        string prompt2 = "Think of a time when you did something really difficult.";
        string prompt3 = "Think of a time when you helped someone in need.";
        string prompt4 = "Think of a time when you did something truly selfless.";
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);

        


        string randomPrompt = "";


        foreach(string prompt in _prompts)
        {
            Random random = new();
            int randomIndex = random.Next(_prompts.Count);
            randomPrompt = _prompts[randomIndex];

        }

        return randomPrompt;

    }

    

    public string GetRandomQuestion()
    {
        string question1 = "Why was this experience meaningful to you?";
        string question2 = "Have you ever done anything like this before?";
        string question3 = "How did you get started?";
        string question4 = "How did you feel when it was complete?";
        string question5 = "What made this time different than other times when you were not as successful?";
        string question6 = "What is your favorite thing about this experience?";
        string question7 = "What could you learn from this experience that applies to other situations?";
        string question8 = "What did you learn about yourself through this experience?";
        string question9 = "How can you keep this experience in mind in the future?";

        _questions.Add(question1);
        _questions.Add(question2);
        _questions.Add(question3);
        _questions.Add(question4);
        _questions.Add(question5);
        _questions.Add(question6);  
        _questions.Add(question7); 
        _questions.Add(question8);
        _questions.Add(question9);     

        


        string randomQuestion= "";


        foreach(string question in _questions)
        {
            Random random = new();
            int randomIndex = random.Next(_questions.Count);
            randomQuestion = _questions[randomIndex];

        }

        return randomQuestion;
    }

   

    public void DisplayPrompt()
    {
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"---{randomPrompt} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have somthing in mind press enter to continue.");


    }

    public void DisplayQuestions()
    {
        string randomQuestion = GetRandomQuestion();
        Console.WriteLine($">{randomQuestion}"); 


        

        
    }
    
}