using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Mindfulness Program");
        while(true)
        {
          Console.WriteLine("Menu Options:");
          Console.WriteLine("   1.Start breathing activity");
          Console.WriteLine("   2.Start reflecting activity");
          Console.WriteLine("   3.Start listing activity");
          Console.WriteLine("   4.Quit");
          Console.WriteLine("Select a Choice from the menu: ");

          string optionChosen = Console.ReadLine();  
         
          
          if (optionChosen == "1")
            {
            BreathingActivity.Run();
                
            }
          else if (optionChosen == "2")
            {
            ReflectionActivity.Run();  
            
            }
          else if (optionChosen == "3")
            {
            ListingActivity.Run();
            }
           else if (optionChosen == "4")
            {
            Console.WriteLine("Thanks for coming!");    
            break;
            }
          

        }
    }
}