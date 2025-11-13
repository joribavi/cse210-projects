using System.Runtime.CompilerServices;

public class Scripture
{
    private string _reference;
    private List<Word>Words; 

    public Scripture(Reference reference, string text)
    {
        
    }


    public void HideRandWords(int numberToHide)
    {
        
    }

    public string GetDisplayText()
    {
        return _reference + Words; 
    }

    public bool IsCompletelyHidden()
    {
      return true;   
    
    }
}