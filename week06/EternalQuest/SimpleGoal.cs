public class SimpleGoal : Goal
{
    private bool _isComplete;

        public SimpleGoal(string shortName, string description, int points) : base ( shortName, description, points)
    {
        
    }


        public  override  void RecordEvent()
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
      string representation = $"Simple Goal: {shortName}, {description}, {points} , {_isComplete}" ;
      return representation;
    }

}