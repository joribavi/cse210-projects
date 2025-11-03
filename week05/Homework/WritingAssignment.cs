public class WritingAssignment: Assignment
{
    //Atributes 
    public string _title;

    //constructor
    public WritingAssignment() : base()
    {
        _title = "Sample Assignment Title";
        GetSummary();
    }

    //methods for the child class 
    public string GetWritingInformation()
    {
        return   _title;
    }



}