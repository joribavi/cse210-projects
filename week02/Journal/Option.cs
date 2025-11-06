public class Option
{
    private string _optionToChoose;

    public Option(string optionToChoose)
    {
        _optionToChoose = optionToChoose;
    }

    public string GetOption()
    {
        return _optionToChoose;
    }

    public string SetOption(string optionToChoose)
    {
        _optionToChoose = optionToChoose;
        return _optionToChoose;

    }
     
     public void DisplayOptions()
    {
        Console.WriteLine($"{_optionToChoose}");
    }



}