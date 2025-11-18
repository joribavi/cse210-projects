using System.Transactions;

public class Video
{
    //Member Attributes
    private string _title;
    private string _author;

    private int _seconds;

    private List <Comment> _videoComments;

    //Constructor
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }


    //Behaviors or methods
    public int GetNumComments()
    {
        int NumOfComments = 0;
        foreach (Comment myComment in _videoComments)
        {
          NumOfComments = _videoComments.Count();

        }
        return NumOfComments;
    }

    public void GetDisplayContent()
    {
      Console.WriteLine($"Title: {_title}");
      Console.WriteLine($"Author: {_author}");
      Console.WriteLine($"Seconds: {_seconds}");

    }

    //Adding Comments to the list
    public void AddComments(Comment newComment)
    {
        _videoComments = new(); //initializing the list
        _videoComments.Add(newComment);

    }

    public string DisplayListContent()
    {
        string textContent = "";
        foreach(Comment myComment in _videoComments)
        {
            textContent = myComment.GetDisplayContent();
            

        }

        return textContent;
                   


    }
}