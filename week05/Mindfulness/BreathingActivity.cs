class BreathingActivity : Activity
{
    
    private BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
      
    }

    public static void Run()
    {
      int duration = 0;   //initial default value
      string description = ""; //default value
      BreathingActivity myBreathingActivity = new("Breathing Activity", description, duration);  
      myBreathingActivity.DisplayStartingMessage();
      
      description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
      Console.WriteLine(description);    
      Console.Write("How long, in seconds, would you like for your session? ");
      string durationString = Console.ReadLine();
      duration = int.Parse(durationString);
      myBreathingActivity.SetDuration(duration);
  
      Console.WriteLine("Get ready...");  
      myBreathingActivity.ShowSpinner(10);

      Console.WriteLine("Breathe in... "); 
      Console.WriteLine("Now breathe out... ");   

   
   
    }

}