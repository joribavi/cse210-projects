public class Assignment
{
    //private atributes or member variables
    private string _studentName;
    private string _topic;

    //constructor 
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    
    //class modules
    public string GetSummary()
    {
  
        return _studentName + "-" + _topic;
    }
    


}