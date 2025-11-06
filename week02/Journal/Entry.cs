public class Entry
{
    public string myEntry = "";
    public string myDate = "";

    public string myPrompt = "";

    public void DisplaySingleEntry()
    {
        Console.WriteLine($"{myEntry}");
        Console.WriteLine($"{myDate}");
        Console.WriteLine($"{myPrompt}");

    }

}