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

    public  void DisplayStartingMessage()
    {

        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine($"{_description}"); 
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");  
       
       

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well done! ");
        Console.WriteLine($"You have completed another {_duration} seconds of {_name} Activity");   
      
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

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetName()
    {
        return _name;
    }



}