using System.Reflection.Metadata.Ecma335;

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

    public int SetTop(int topNumber)
    {

        _top = topNumber;
        return _top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public int SetBottom(int bottomNumber)
    {
        _bottom = bottomNumber;
        return _bottom;
    }

    //Class Methods 

    public string GetFractionString()

    {
        string topNumber = _top.ToString();
        string bottomNumber = _bottom.ToString();

        string fractionString = $"{topNumber}/{bottomNumber}";

        return fractionString;

    }
    
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / (double)_bottom; //declaring both values from int to double to get decimals 
   
        
        return  decimalValue;
    }

}