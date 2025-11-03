public class MathAssignment : Assignment
{
    //attributes of the child class 
    public string _textBookSection;
    public string _problems;

    //constructor 
    public MathAssignment() : base()
    {

        _textBookSection = "Sample Section";
        _problems = "Math Sample Problems";

        GetSummary();

    }
    
    //unique methods to the child class 
    public string GetHomeworkList()
    {
        return "Section " + _textBookSection + " Problems " + _problems;
    }
}