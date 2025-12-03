public class EternalGoal : Goal
{
    

    public EternalGoal(string shortName, string description, int points) : base ( shortName, description, points)
    {
        

    }


    public override void RecordEvent()
    {
        
    }

    public override bool IsCompleted()
    {
        return true;
    }

    public override string GetStringRepresentation()
    {
      string sample = "";

        return sample;
    }

}