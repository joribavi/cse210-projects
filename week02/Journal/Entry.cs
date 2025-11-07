public class Entry
{
    public string _myEntry;
    public string _myDate ;

    public string _myPrompt;

    public Entry()
    {
        _myEntry = "Sample Entry";

        _myDate = "10-10-2025";

        _myPrompt = "It was a great day";

    }
    
    public Entry(string theEntry, string theDate, string thePrompt)
    {
        _myEntry = theEntry;
        _myDate = theDate;
        _myPrompt = thePrompt;
    }

    public void DisplaySingleEntry()
    {

        Console.WriteLine($"Date: {_myDate}");
        Console.WriteLine($"Prompt: {_myPrompt}");
        Console.WriteLine($"Entry: {_myEntry}");

    }
    


}