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


    public override bool IsCompleted()
    {
        return true;

    }

    public override string  GetDetailsString()
    {
        string sample = "";
        return sample;

    }

    public override string GetStringRepresentation()
    {
      string representation = "";
      return representation;

    }
}