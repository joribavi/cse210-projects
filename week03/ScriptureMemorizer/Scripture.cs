using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word>_words; 

   
    public Scripture ()
    {
        
    }
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


    public void HideRandWords(int numberToHide) //number to hide is the number of Words element we want to hide at once
    {
     
       int amountOfWords = _words.Count(); //counting amount of elements of type Word
        
       if (amountOfWords>= numberToHide) //verifies that we will not hide a bigger number than number to Hide
        {

            Random randNum = new Random();

            for (int i= 0; i < numberToHide; i++)
            {
            
               int randIndex = randNum.Next(amountOfWords); //getting a random number smaller than the current text

               
                 _words[randIndex].HideWord();
                

                 _words[randIndex].GetDisplayText();
                

            }
              
           


        } 
        else
        {
            Console.WriteLine("The list is empty...");
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
      foreach (Word word in _words)
        {
            if(word.IsHidden() == false)
            {
                return false;
            }
       
        }  
        return true;
    
    }
}