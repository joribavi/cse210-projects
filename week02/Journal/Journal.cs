using System.Text.Json.Nodes;
using System.Text;
using System.IO;

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

        outputFile.WriteLine($"Date: {myDate}");   
        outputFile.WriteLine($"Prompt: {myPrompt}");  
        outputFile.WriteLine($"Entry: {myEntry}");          
                 
      }
             
   
    
    }
    


    }

  public void LoadFromFile(string filename)
  {

    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split("?", StringSplitOptions.RemoveEmptyEntries); //spliting with delimiter

      Console.WriteLine($"{line}");

    }

  }

  public void toCSV(string filename)
  {

    StringBuilder csvContent = new StringBuilder();

    string file = "myCSV.csv";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
    {
      string[] parts = line.Split("?", StringSplitOptions.RemoveEmptyEntries); //spliting with delimiter

      csvContent.AppendLine($"{line}");

    }
    using (StreamWriter writer = new StreamWriter(file, false, Encoding.UTF8))
{
    writer.Write(csvContent.ToString());
}
  }

        
  


}