using System.ComponentModel.Design;

class Activity
{
    private string _name;
    private string _description;

    private int _duration;


    public Activity (string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        Console.ReadLine();
        Console.WriteLine("Get ready...");

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! ");
    }
     public void ShowSpinner(int seconds)
    {
      List<string> animationStrings = new();
      animationStrings.Add("|");  
      animationStrings.Add("/"); 
      animationStrings.Add("-"); 
      animationStrings.Add("\\"); 
      animationStrings.Add("|"); 
      animationStrings.Add("/"); 
      animationStrings.Add("-"); 
      animationStrings.Add("\\"); 

      DateTime startTime = DateTime.Now;
      DateTime endTime = startTime.AddSeconds(seconds);

      int startingIndex = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[startingIndex];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            startingIndex++; 

            if(startingIndex >= animationStrings.Count)
            {
                startingIndex = 0;
            }

        }
    
    }

     public void ShowCountDown(int seconds)
    {
        for (int counter = seconds; counter > 0 ; counter-- )
        {
            Console.Write(counter);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }




}