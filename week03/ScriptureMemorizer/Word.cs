public class Word
{
    private string _text; 
    private bool _isHiden;

    //Constructor
    public Word(string text)
    {
        _text = text;
    }

    public void HideWord()
    {
        _isHiden = true;
    }  

    public void ShowWord()
    {
        Console.WriteLine($"{_text}");
    }

    public bool IsHidden()
    {
            
        return _isHiden;
    }

    public string GetDisplayText()
    {
        string hiddenWord = "_";

        if (_isHiden == true)
        {
            return hiddenWord;
        }
        else 
        {
            return _text;
        }
    }
}