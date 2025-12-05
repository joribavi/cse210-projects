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

       string detailString = "."+ "" + "[]"+ shortName + "" + "(" + description + ")" + "---Curruntly Completed: 0/0";
        return detailString;

    }

    public override string GetStringRepresentation()
    {
      string representation = "";
      return representation;

    }
}