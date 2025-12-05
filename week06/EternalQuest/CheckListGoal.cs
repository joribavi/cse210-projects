public class CheckListGoal : Goal
{
    private int _amountCompleted;
    private int _target;

    private int _bonus;


    public CheckListGoal(string shortName, string description, int points, int amountCompleted, int target, int bonus) : base (shortName, description, points)
    {
        _amountCompleted = amountCompleted;

        _target = target; 

        _bonus = bonus;



    }


      public override void RecordEvent()
    {
        
    }


    public override bool IsComplete()
    {
        return true;

    }

    public override string  GetDetailsString()
    {

       string shortName = GetshortName();

       string description = GetDescription(); 

       string detailString = "."+ "" + "[]"+ shortName + "" + "(" + description + ")" + "---Curruntly Completed: " + _amountCompleted +  "/" + _target ;
       return detailString;

    }

    public override string GetStringRepresentation()
    {
      string shortName = GetshortName();

      string description = GetDescription(); 
      string representation = $"Goal Name: {shortName}, Goal Description: {description}, Amount Completed: {_amountCompleted}, Target: {_target}, Bonus: {_bonus}" ;
      return representation;

    }
}