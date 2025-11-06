using System.Collections.Generic; 
using System.Linq;

public class PromptGenerator
{

   

    public string prompt1 = "";
    public string prompt2 = "";
    public string prompt3 = "";
    public string prompt4 = "";
    public string prompt5 = "";


    public List<string> _prompts = new List<string>();




    public void GetRandomPrompt()
    {
        
        _prompts.Add(prompt1);
        _prompts.Add(prompt2);
        _prompts.Add(prompt3);
        _prompts.Add(prompt4);
        _prompts.Add(prompt5);

        foreach (string prompt in _prompts)
        
        {
            Random randomPrompt = new Random(); // call random method to use it in the next lines 
            int randomIndex = randomPrompt.Next(_prompts.Count);

            string randomElement = _prompts[randomIndex]; //getting a random element of the list , according to its index 

            Console.WriteLine($"{randomElement}");
            break; 

        }

    }

}