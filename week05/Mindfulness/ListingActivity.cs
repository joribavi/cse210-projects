class ListingActivity : Activity
{

    private int _count;

    private List<string> _prompts;
    private ListingActivity(string name, string description, int duration) : base(name, description, duration)  
    {
        
    }

    public void Run()
    {
        
    }

    public void GetRandomPrompt()
    {
        
    }

    public List<string> GetListFromUser()
    {
        return _prompts; // just for starting without getting errors
        
    }
    
}