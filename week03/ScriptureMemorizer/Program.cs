using System;

class Program
{
    static void Main(string[] args)
    {


        string text = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.";
        

        Reference myReference = new Reference("1 Nephi",3,7);
        Scripture myScripture = new Scripture(myReference,text);

        Console.WriteLine(myReference.GetDisplayText());
        Console.WriteLine(myScripture.GetDisplayText());
        
        Console.WriteLine("Hit enter key to continue, type quit to end");
        string response = Console.ReadLine();

        if (response == "quit")
        {
            return;
        }

        else
        {
            myScripture.HideRandWords(4);
            
        }

     







      /*
        foreach (string singleWord in wholeText)
        {
            Word word = new Word(singleWord);
         //   word.ShowWord(); 
              word.HideWord();
            

        } 
        */



        /*

         Reference myReference = new Reference("1Nephi",3,7);

         Scripture myScripture = new Scripture(myReference, text); 
  

        string response = Console.ReadLine();    
        do
        {
        myScripture.GetDisplayText();
        Console.WriteLine("Type quit if you want to stop"); 

            
        } while (response != "quit");

        */
    }

    /* 
    When user types quit program ends
    
    HiderClass

    Display Class

    RandomScripture

    Mentor Guidance 
  
    
    */
}