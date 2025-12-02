class ListingActivity : Activity
{

    private int _count;

    private List<string> _prompts = new List<string>();
    private ListingActivity(string name, string description, int duration) : base(name, description, duration)  
    {
        
    }

    public static void Run()
    {
      int duration = 0;   //initial default value
      string description =  "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

      ListingActivity myListingActivity = new("Listing", description, duration);  
      myListingActivity.DisplayStartingMessage();
      string durationString = Console.ReadLine();
      duration = int.Parse(durationString);
      myListingActivity.SetDuration(duration);
      Console.Clear();
      Console.WriteLine("Get ready...");  
      myListingActivity.ShowSpinner(5);

      Console.WriteLine("List as many responses you can to the following prompt: ");  
      myListingActivity.GetRandomPrompt();
      Console.Write("You may begin in... ");
      myListingActivity.ShowCountDown(7);
      Console.WriteLine("");  


      Console.WriteLine("");
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(duration);
      int numOfPrompts = 0;
       
      while (DateTime.Now < endTime)
      {

            myListingActivity.GetListFromUser();  
            numOfPrompts =  myListingActivity.GetNumOfPrompts();
           
            
      }  
     
      
      Console.WriteLine($"You have listed {numOfPrompts} items!")  ;
     
      Console.WriteLine("");
      Console.WriteLine("");


      


      
      myListingActivity.DisplayEndingMessage();

      myListingActivity.ShowSpinner(5);
      Console.Clear();

     




    }

    public void GetRandomPrompt()
    {
        string prompt1 = "Who are people that you appreciate?";
        string prompt2 = "What are personal strengths of yours?";
        string prompt3 = "Who are people that you have helped this week?";
        string prompt4 = "When have you felt the Holy Ghost this month?";
        string prompt5 = "Who are some of your personal heroes?"; 
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);

        


        string randomPrompt = "";


        foreach(string prompt in _prompts)
        {
            Random random = new();
            int randomIndex = random.Next(_prompts.Count);
            randomPrompt = _prompts[randomIndex];

        }
        Console.WriteLine($"--- {randomPrompt} ---");

    }
     List <string> userPrompts = new ();  
    public  List<string> GetListFromUser()
    {
      
       
       Console.Write(">");
       string promptFromUser = Console.ReadLine();
    
       userPrompts.Add(promptFromUser);
     
      


       return userPrompts;

    }

    public  int GetNumOfPrompts()
    {
        
        
        _count = userPrompts.Count();

        return _count;
    }
    




    
}