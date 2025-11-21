using System.Transactions;

public class Video
{
    //Member Attributes
    private string _title;
    private string _author;

    private int _seconds;

    private List <Comment> _videoComments = new();

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
      
       
         int NumOfComments = _videoComments.Count;   

      
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
    
        _videoComments.Add(newComment);

    }

    public void DisplayListContent() //turning to void after debug //change made in the Program Design
    {


         foreach(Comment myComment in _videoComments)
        {
          string  textContent = myComment.GetDisplayContent();
          Console.WriteLine($"{textContent}");  

        }





    

    }
}