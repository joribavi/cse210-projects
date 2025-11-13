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
        
    }

    public void ShowWord()
    {
        
    }

    public bool IsHidden()
    {
        _isHiden = true; 
        return _isHiden;
    }

    public string GetDisplayText()
    {
        
        return _text;
    }
}