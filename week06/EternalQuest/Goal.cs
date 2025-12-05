using System.Collections.Concurrent;

public class Goal
{
    
    private string _shortName;
    private string _description;

    private int _points;

    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;

    }


    public virtual void RecordEvent()
    {
        
    }


    public virtual bool IsComplete()
    {
        return true;

    }

    public virtual string GetDetailsString()
    {
        string detailString = "."+ "" + "[]"+ _shortName + "" + "(" + _description + ")";
        return detailString;

    }

    public virtual string GetStringRepresentation()
    {
      string representation = "";
      return representation;

    }

    //getters 
    public string GetshortName()
    {
        return _shortName;
    } 

    public string GetDescription()
    {
        return _description;
    } 


}
