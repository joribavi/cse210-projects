public class MathAssignment : Assignment
{
    //attributes of the child class 
    public string _textBookSection;
    public string _problems;

    //constructor 
    public MathAssignment(string textBookSection, string problems, string studentName, string topic) : base(studentName, topic) 
    {

        _textBookSection = textBookSection;
        _problems = problems;

        GetSummary();

    }
    
    //unique methods to the child class 
    public string GetHomeworkList()
    {
        return "Section " + _textBookSection + " Problems " + _problems;
    }
}