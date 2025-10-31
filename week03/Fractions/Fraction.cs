public class Fraction
{
    //Atributes

    private int _top;
    private int _bottom;

    //Constructors

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;

        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    //Setters and Getters 


    public int GetTop()
    {

        return _top;
    }

    public void SetTop(int topNumber)
    {

        _top = topNumber;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
    }

}