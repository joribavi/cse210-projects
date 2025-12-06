public class EternalGoal : Goal
{
    

    public EternalGoal(string shortName, string description, int points) : base ( shortName, description, points)
    {
        

    }


    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
     string shortName = GetshortName();
     int points = GetPoints();

      string description = GetDescription(); 
      string representation = $"Eternal Goal: {shortName}, {description}, {points}" ;
      return representation;


    }

}