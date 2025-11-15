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
        Console.Clear();
        _text = "_";
        Console.WriteLine(_text);
    }  

    public void ShowWord()
    {
        Console.WriteLine($"{_text}");
    }

    public bool IsHidden()
    {
        if (_text == "_")
        {
             _isHiden = true; 
        }
        else
        {
            _isHiden = false; 
        }
        return _isHiden;
    }

    public string GetDisplayText()
    {
        
        return _text;
    }
}