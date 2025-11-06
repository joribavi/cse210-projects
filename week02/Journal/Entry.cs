public class Entry
{
    private string myEntry = "";
    private string myDate = "";

    private string myPrompt = "";

    public Entry()
    {
        myEntry = "Sample Entry";

        myDate = "10-10-2025";

        myPrompt = "It was a great day";

    }
    
    public Entry(string theEntry, string theDate, string thePrompt)
    {
        _myEntry = theEntry;
        _myDate = theDate;
        _myPrompt = thePrompt;
    }

    public void DisplaySingleEntry()
    {
        Console.WriteLine($"{myEntry}");
        Console.WriteLine($"{myDate}");
        Console.WriteLine($"{myPrompt}");

    }

}