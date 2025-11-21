using System;

class Program
{
    static void Main(string[] args)
    {
        // PROGRAM THAT CREATES 3-4 VIDEOS AND SET THE APPRORPIATE VALUES
        Video video1 = new("The Art of Coding","John Doe", 3000);
        Video video2 = new("C# Fundamentals", "Jane Doe", 10000);
        Video video3 = new("C# Loops", "Susan Brown", 5000);
        Video video4 = new("C# Vs Python", "Mc Gregor", 3500);


        //ADDING COMMENTS VIDEO 1
        Comment comment1Video1 = new("James Brown","Very interesting video. Thank you so much");
        Comment comment2Video1 = new("Mirta Smith","It it is a huge help for students. Thank you!");
        Comment comment3Video1 = new("Jacob Lehi","I liked the first part of the video, I learned a lot from there");
        Comment comment4Video1 = new("Sam Adams","I think the audio quatily could be improved");
        //ADDING COMMENTS VIDEO 2
        Comment comment1Video2 = new("David Jonson","We are waiting for more videos like this one!");
        Comment comment2Video2 = new("Susan Grekk","Thanks for sharing your experience!");
        Comment comment3Video2 = new("Patch Adams","I did not understand the last function you wrote.");
        Comment comment4Video2 = new("Martin Power","Can you write a video about Python too?");

        //ADDING COMMENTS VIDEO 3
        Comment comment1Video3 = new("Jose Gonzalez","Do you have videos in Spanish?");
        Comment comment2Video3 = new("Juan Perez","Great content, thank you!");
        Comment comment3Video3 = new("María Burton","Very good explained! thanks");
        Comment comment4Video3 = new("Julio Brown","Do you have another video explaining Classes?");


        //ADDING COMMENTS VIDEO 4
        Comment comment1Video4 = new("Jorge Ramirez","I fully agree with that");
        Comment comment2Video4 = new("Paula Johnson","I think both languages are meant for different purposes too");
        Comment comment3Video4 = new("Nephi Mc Clark ","I think Python is now the trend");
        Comment comment4Video4 = new("Sam Adams","Do you have github repo?");


        //ADDING COMMENTS TO VIDEO 1
        video1.AddComments(comment1Video1);
        video1.AddComments(comment2Video1);
        video1.AddComments(comment3Video1);
        video1.AddComments(comment4Video1);
    
        //ADDING COMMENTS TO VIDEO 2 
        video2.AddComments(comment1Video2);
        video2.AddComments(comment2Video2);
        video2.AddComments(comment3Video2);
        video2.AddComments(comment4Video2);
        
        //ADDING COMMENTS TO VIDEO 3
        video3.AddComments(comment1Video3);
        video3.AddComments(comment2Video3);
        video3.AddComments(comment3Video3);
        video3.AddComments(comment4Video3);
        //GETTING AMOUNT OF COMMENTS
     
        //ADDING COMMENTS TO VIDEO 4
        video4.AddComments(comment1Video4);
        video4.AddComments(comment2Video4);
        video4.AddComments(comment3Video4);
        video4.AddComments(comment4Video4);

    


        //CREATING LIST WITH ALL VIDEOS

        List <Video>myVideoList = new();

        myVideoList.Add(video1);   
        myVideoList.Add(video2);   
        myVideoList.Add(video3);   
        myVideoList.Add(video4);


        
        //ITERATION OVER ALL VIDEOS- EACH ONE WITH ITS COMMENT 
        
   
       

        foreach (Video myVideo in myVideoList)
        {
       
            Console.WriteLine("*********************");
            myVideo.GetDisplayContent();
            //GETTING AMOUNT OF COMMENTS
             myVideo.GetNumComments();
             int numOfComments = myVideo.GetNumComments();
            Console.WriteLine($"Number of Comments: {numOfComments}");
            Console.WriteLine("Comments: ");
            myVideo.DisplayListContent();
     
            
            Console.WriteLine("*********************");

            


        }


    }
}


