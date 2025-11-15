using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word>_words; 

   

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        
         _words = new List<Word>(); //it initializes the List 

         string [] wordList = text.Split(" ");

         if (string.IsNullOrEmpty(text)) //it verifies if there is a text 
        {
          return;
           
        }
        else
        {
             foreach (string singleWord in wordList)
           {

             Word word = new Word(singleWord);
             _words.Add(word);  
           } 
        }         

   
        
    }


    public void HideRandWords(int numberToHide)
    {
     
        Random hideWords = new Random();
        int randomIndex = numberToHide;

        foreach (Word word in _words)
        {
            Console.Clear();
            Console.WriteLine("_");
            
        }

    }


    public string GetDisplayText() 
    {
         List<string>wordList = new List<string>();
          
          foreach (Word word in _words)
        {
            string mytext = word.GetDisplayText();
            wordList.Add(mytext);

                      

        }   
        string text = string.Join(" ", wordList);

        return  text;
      
    }

    public bool IsCompletelyHidden()
    {
      return true;   
    
    }
}