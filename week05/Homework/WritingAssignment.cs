public class WritingAssignment: Assignment
{
    //Atributes 
    public string _title;

    //constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName,topic)
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