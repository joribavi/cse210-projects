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
         int points = GetPoints();  
         Console.Write($"Congratulations! You have earned {points} points");
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
      int points = GetPoints();
      string shortName = GetshortName();

      string description = GetDescription(); 
      string representation = $"Check List Goal: {shortName}, {description}, {points}, {_amountCompleted}, {_target}, {_bonus}" ;
      return representation;

    }
}