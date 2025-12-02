using System;

class Program
{
    static void Main(string[] args)
    {
         Console.WriteLine("******GOAL TRACKER*****");
        while(true)
        {
          Console.WriteLine("Menu Options:");
          Console.WriteLine("   1.Create a New Goal");
          Console.WriteLine("   2.List Goals");
          Console.WriteLine("   3.Save Goals");
          Console.WriteLine("   4.Load Goals");
          Console.WriteLine("   5.Save Goals");  
          Console.WriteLine("   6.Quit");


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
            }

             else if (optionChosen == "5")
            {
             Console.WriteLine("You chose option 5");
            }


        
           else if (optionChosen == "6")
            {
            Console.WriteLine("Thanks for coming!");    
            break;
            }
          

        }
    }
}