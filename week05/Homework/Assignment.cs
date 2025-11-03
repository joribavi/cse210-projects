public class Assignment
{
    //private atributes or member variables
    private string _studentName;
    private string _topic;

    //constructor 
    public Assignment()
    {
        _studentName = "Oliver Cowdery";
        _topic = "Book of Mormon";
    }
    
    public string GetSummary()
    {
  
        return _studentName + "-" + _topic;
    }
    


}