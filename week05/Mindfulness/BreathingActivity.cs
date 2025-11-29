using System.Diagnostics.CodeAnalysis;

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

      int firstNum = 2;
      int secondNum = 4;
       
      //Do loop to correct (infinite loop) 
      int sumCountDown = firstNum + secondNum;
      do      
        {
        Console.Write("Breathe in... ");
        myBreathingActivity.ShowCountDown(firstNum); 
        Console.Write("Now breathe out... ");   
        myBreathingActivity.ShowCountDown(secondNum); 

        } while(sumCountDown < duration);

        myBreathingActivity.DisplayEndingMessage();
        myBreathingActivity.ShowSpinner(5);

        
   


   
   
    }

}