public class WritingAssignment: Assignment
{
    //Atributes 
    public string _title;

    //constructor
    public WritingAssignment( string topic, string title) : base(topic)
    {
        _title = topic;
        GetSummary();
    }

    //methods for the child class 
    public string GetWritingInformation()
    {
        return   _title;
    }



}