public class Journal
{
    
    public List<Entry> _myEntryList = new List<Entry>();


    public void AddEntry(Entry newEntry)
    {
        _myEntryList.Add(newEntry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in _myEntryList)
        {
         entry.DisplaySingleEntry();
            
        }
     
          
    }

    public void SaveToFile(string filename)
    {
        
 

    using (StreamWriter outputFile = new StreamWriter(filename))
    {

      outputFile.WriteLine("Journal Entries: ");
      
     
      foreach (Entry entry in _myEntryList)
      {
        string myPrompt = entry._myPrompt;
        string myDate = entry._myDate;
        string myEntry = entry._myEntry;

        outputFile.WriteLine($"{myDate}");   
        outputFile.WriteLine($"{myPrompt}");  
        outputFile.WriteLine($"{myEntry}");          
                 
      }
             
   
    
    }
    


    }
    
    public void LoadFromFile(string filename)
  {

       // string filename = "myFile.txt";
  
      string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split("?", StringSplitOptions.RemoveEmptyEntries); //spliting with delimiter

      Console.WriteLine($"{line}");
           
    }
 
    }
}