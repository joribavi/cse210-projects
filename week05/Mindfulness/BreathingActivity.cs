using System.Diagnostics.CodeAnalysis;

class BreathingActivity : Activity
{
    
    private BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
      
    }

    public static void Run()
    {
      int duration = 0;   //initial default value
      string description =  "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

      BreathingActivity myBreathingActivity = new("Breathing", description, duration);  

      myBreathingActivity.DisplayStartingMessage();
     
      
   
      string durationString = Console.ReadLine();
      duration = int.Parse(durationString);
      myBreathingActivity.SetDuration(duration);
      Console.Clear();
  
      Console.WriteLine("Get ready...");  
      myBreathingActivity.ShowSpinner(5);
      Console.WriteLine("");
      Console.WriteLine(""); 
      Console.WriteLine("");    

     
      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(duration);
 
      if(duration%2 == 0)
        {
            
          while (DateTime.Now < endTime)
          {
       
          Console.Write("Breathe in...");
          myBreathingActivity.ShowCountDown(4); 
          Console.WriteLine("");    

        
          Console.Write("Now breathe out...");   
          myBreathingActivity.ShowCountDown(6); 
           Console.WriteLine("");
           Console.WriteLine(""); 
          } 
        }
        
        else
        {
          while (DateTime.Now < endTime)
          {
          Console.Write($"Breathe in...");
             
          myBreathingActivity.ShowCountDown(3); 
          Console.WriteLine("");    

          
          Console.Write("Now breathe out...");   
          myBreathingActivity.ShowCountDown(2); 
          Console.WriteLine("");  
          Console.WriteLine("");  
        

          }

 

        }
        string activityName = myBreathingActivity.GetName();

        myBreathingActivity.DisplayEndingMessage();

        myBreathingActivity.ShowSpinner(5);
        Console.Clear();
     
    

        
   


   
   
    }

}