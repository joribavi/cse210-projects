using System;

class Program
{
    static void Main(string[] args)
    {


        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        

        Reference myReference = new Reference("1 Nephi",3,7);
        Scripture myScripture = new Scripture(myReference,text);
        string reference = myReference.GetDisplayText();
        string scripture = myScripture.GetDisplayText();
        do {
        Console.WriteLine(reference);
        Console.WriteLine(scripture);
        
        Console.WriteLine("Hit enter key to continue, type quit to end");
        string response = Console.ReadLine();

        if (response == "quit")
        {
            return;
        }

        else if (response == "")
      
        {

            myScripture.HideRandWords(5);
            Console.Clear();
            scripture = myScripture.GetDisplayText();
    

        }

        else
        {
            Console.WriteLine("Please Enter a valid answer");
        }

     

        } while (myScripture.IsCompletelyHidden()==false);





     
    }


}