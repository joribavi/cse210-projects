class Activity
{
    private string _name;
    private string _description;

    private int _duration;


    protected Activity (string name, string description, int duration)
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
        
    }
     public void ShowSpinner(int seconds)
    {
        
    }

     public void ShowCountDown(int seconds)
    {
        
    }




}