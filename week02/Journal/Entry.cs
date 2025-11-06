public class Entry
{
    private string _myEntry;
    private string _myDate ;

    private string _myPrompt;

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
        Console.WriteLine($"{_myEntry}");
        Console.WriteLine($"{_myDate}");
        Console.WriteLine($"{_myPrompt}");

    }

}