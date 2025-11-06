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
        
   //filename = 'myJournal
 

    using (StreamWriter outputFile = new StreamWriter(filename))
        {     
        

     //   string? newEntry; 

    // Adding text to the file with  WriteLine method
  //  outputFile.WriteLine($"{newEntry}");
    
    }
    


    }
    
    public void LoadFromFile(string filename)
    {

       // string filename = "myFile.txt";
         string[] lines = System.IO.File.ReadAllLines(filename);

      foreach (string line in lines)
      {
      string[] parts = line.Split(",");

      string firstName = parts[0];
      string lastName = parts[1];
      }
        
    }
}