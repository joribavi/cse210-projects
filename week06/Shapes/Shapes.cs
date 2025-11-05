using System.Formats.Asn1;

public abstract class Shape
{
    //attributes 
    private string _color;
    
    //Constructor
    public Shape (string color)
    {
        _color = color;
    }


    public string GetColor()
    {
        return _color;

    }

    public void SetColor(string color)
    {
         _color = color;

    }
    
    public double _area; 
    public  virtual double GetArea()
    {
        return _area;
    }

}