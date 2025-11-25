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
            Console.WriteLine("You chose option 1");
            }
          else if (optionChosen == "2")
            {
            Console.WriteLine("You chose option 2"); 
            }
          else if (optionChosen == "3")
            {
            Console.WriteLine("You chose option 3");   
            }
           else if (optionChosen == "4")
            {
            Console.WriteLine("You chose option 4");    
            break;
            }
      

        }
    }
}