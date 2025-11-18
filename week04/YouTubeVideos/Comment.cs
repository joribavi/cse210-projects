public class Comment
{
    private string _name;
    private string _text;

    //constructor

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;

    }

    public string GetDisplayContent()
    {

       return _text;
    }

    

}